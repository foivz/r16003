using Dropbox.Api;
using Dropbox.Api.Files;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    /// <summary>
    /// Klasa za rad sa dropbox-om, sadrži metode za kreiranje mapa te preuzimanje u upload sadržaja na dropbox
    /// </summary>
    class DropboxManager
    {
        string token = "kU5cuLun14AAAAAAAAAADuqHTOzUyYuSfqbF0ekL2tcaiqfQiuRcYrpjbrvxBbDQ";
        string path = "/crypto/";

        /// <summary>
        /// Metoda koja kreira folder na dropboxu prilikom registracije korisnika kako bi mu bila omogućena
        /// razmjena datoteka
        /// </summary>
        /// <param name="name"></param>
        public async void CreateANewFolder(string name)
        {
            string patrRecieve = path + name + "/primljeno";
            string pathSend = path + name + "/poslano";
            using (var dbx = new DropboxClient(token))
            {
                var createdRecieve = await dbx.Files.CreateFolderAsync(patrRecieve);
                var createdSend = await dbx.Files.CreateFolderAsync(pathSend);
                //var endCreated = await dbx.Files.EndCreateFolder();
            }
        }

        /// <summary>
        /// Metoda koja na dropbox serveru pronalazi datoteke koje je korisnik sam sebi poslao ili primio od drugih korisnika.
        /// Datotekama se pridružuju metapodaci te se takve datoteke dodaju u listu datoteka koja predstavlja izlaz ove metode.
        /// U listu datoteka se ne dodaju takozvane .crypto datoteke koje samo predstavljaju pomoćne datoteke koje služe za
        /// dekriptiranje datoteka.
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="listaKorisnika"></param>
        /// <returns></returns>
        public async Task<List<Datoteka>> ListRootFolder(string Username, List<Korisnik> listaKorisnika)
        {
            string input, ime;
            List<Datoteka> listaDatoteka = new List<Datoteka>();

            using (var dbx = new DropboxClient(token))
            {
                string completePath = path + Username + "/primljeno/";
                var list = await dbx.Files.ListFolderAsync(path:completePath);
                foreach (var item in list.Entries.Where(i => i.IsFile))
                {
                    Datoteka nova = new Datoteka();
                    input = item.Name;
                    ime = input.Substring(input.IndexOf('_') + 1);
                    nova.ImeDatoteke = ime;
                    nova.IzracunajVelicinu(item.AsFile.Size);
                    nova.Datum = item.AsFile.ClientModified.AddMinutes(60);
                    foreach (var korisnik in listaKorisnika)
                    {
                        if (item.Name.Contains(korisnik.Username))
                        {
                            nova.Posiljatelj = korisnik.Username;
                            break;
                        }
                    }
                    if (Path.GetExtension(nova.ImeDatoteke) != ".crypto")
                    {
                        listaDatoteka.Add(nova);
                    }
                }
            }
            return listaDatoteka;
        }

        /// <summary>
        /// Metoda koja uploada datoteku na dropbox na temelju putanje datoteke. Username Pošiljatelja datoteke služi za
        /// formiranje imena datoteke kako bi se znalo tko je datoteku poslao, dok username primatelja služi za formiranje ispravne
        /// lokacije gdje će se datoteka uploadati. Datoteka se prije uploada enkriptira hibridnom enkripcijom. Uz glavnu datoteku
        /// šalje se i pomoćna .crypto datoteka koja sadrži enkriptirani AES ključ i inicijalizacijski vektor.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="posiljatelj"></param>
        /// <param name="primatelj"></param>
        public async Task<int> Upload(string filePath, string posiljatelj, string primatelj, string javniKljuc)
        {
            EnkripcijskiPaket paket;

            string fileName = Path.GetFileName(filePath);
            string uploadFilePath = path + primatelj + "/primljeno/" + posiljatelj + "_" + fileName;
            paket = HibridnaEnkripcija.EncryptFile(File.ReadAllBytes(filePath), javniKljuc);
            byte[] fileToUpload = paket.VratiDatoteku();

            string fileName2 = posiljatelj + "_" + Path.GetFileNameWithoutExtension(filePath)+ ".crypto";
            string uploadFilePath2 = path + primatelj + "/primljeno/" + fileName2;
            byte[] fileToUpload2 = null;
            using (var ms = new MemoryStream())
            {
                TextWriter tw = new StreamWriter(ms);
                tw.WriteLine(paket.EnkriptiraniKljuc);
                tw.WriteLine(Convert.ToBase64String(paket.Iv));
                tw.Flush();
                ms.Position = 0;
                fileToUpload2 = ms.ToArray();
            }

            using (var dbx = new DropboxClient(token))
            {

                using (var mem = new MemoryStream(fileToUpload2))
                {
                    var updated = await dbx.Files.UploadAsync(uploadFilePath2,
                        WriteMode.Add.Instance, autorename: true,
                        body: mem);
                    uploadFilePath = path + primatelj + "/primljeno/" + Path.GetFileNameWithoutExtension(updated.AsFile.Name) + Path.GetExtension(fileName);
                }

                using (var mem = new MemoryStream((fileToUpload)))
                {
                    var updated = await dbx.Files.UploadAsync(uploadFilePath,
                        WriteMode.Add.Instance,autorename:true,
                        body: mem);
                }
            }
            return 1;
        }

        /// <summary>
        /// Metoda koja preuzima datoteku sa dropbox servera. Prvo se skida pomoćna .crypto datoteka te se iz nje čita inicijalizacijski
        /// vektor i ključ. Zatim se dohvaća glavna datoteka sa dropbox servera koja se na kraju dekriptira uz pomoć inicijalizacijskoga
        /// vektora, aes ključa i privatnoga ključa prijavljenoga korisnika.
        /// </summary>
        /// <param name="primatelj"></param>
        /// <param name="posiljatelj"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public async Task<byte[]> Download(string primatelj ,string posiljatelj, string fileName)
        {
            EnkripcijskiPaket paket = new EnkripcijskiPaket();
            byte[] file;
            byte[] helpFile;
            string fullName = posiljatelj + "_" + fileName;

            string downloadFilePath = path + primatelj + "/primljeno/" + fullName;
            string helpFilePath = path + primatelj + "/primljeno/" + Path.GetFileNameWithoutExtension(fullName) + ".crypto";

            using (var dbx = new DropboxClient(token))
            {
                using (var response = await dbx.Files.DownloadAsync(helpFilePath))
                {
                    helpFile = await response.GetContentAsByteArrayAsync();

                    using (var ms = new MemoryStream(helpFile))
                    {
                        StreamReader msReader = new StreamReader(ms);
                        paket.EnkriptiraniKljuc = msReader.ReadLine();
                        paket.Iv = Convert.FromBase64String((msReader.ReadLine()));
                    }
                }

                using (var response = await dbx.Files.DownloadAsync(downloadFilePath))
                {
                    file = await response.GetContentAsByteArrayAsync();
                }
            }

            file = HibridnaEnkripcija.DecryptFile(file, paket.EnkriptiraniKljuc, paket.Iv, DohvatiPrivatniKljuc(primatelj));
            return file;
        }

        /// <summary>
        /// Metoda koja briše određenu datoteku sa dropbox servera zajedno sa pomoćnom .crypto datotekom
        /// </summary>
        /// <param name="primatelj"></param>
        /// <param name="posiljatelj"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public async Task<int> DeleteFile(string primatelj, string posiljatelj, string fileName)
        {
            string fullName = posiljatelj + "_" + fileName;
            string deletePath = path + primatelj + "/primljeno/" + fullName;
            string helpFilePath = path + primatelj + "/primljeno/" + Path.GetFileNameWithoutExtension(fullName) + ".crypto";
            using (var dbx = new DropboxClient(token))
            {
                await dbx.Files.DeleteAsync(helpFilePath);
                await dbx.Files.DeleteAsync(deletePath);
            }
            return 1;
        }

        private string DohvatiPrivatniKljuc(string username)
        {
            string rezultat = "";
            SqlConnection connection = new SqlConnection("Server=tcp:cryptoserver01.database.windows.net,1433;Initial Catalog=PICryptoBaza;Persist Security Info=False;User ID=ivan.uzarevic;Password=crypto2101#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            connection.Open();
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM PrivatniKljucevi WHERE Username=@Username";
            command.Parameters.AddWithValue("@Username", username);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    rezultat = reader["PrivatniKljuc"].ToString();
                }
                reader.Close();
            }
            connection.Close();
            return rezultat;
        }
    }
}
