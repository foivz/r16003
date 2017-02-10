using Dropbox.Api;
using Dropbox.Api.Files;
using System;
using System.Collections.Generic;
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
                    listaDatoteka.Add(nova);
                }
            }
            return listaDatoteka;
        }

        /// <summary>
        /// Metoda koja uploada datoteku na dropbox na temelju putanje datoteke. Username Pošiljatelja datoteke služi za
        /// formiranje imena datoteke kako bi se znalo tko je datoteku poslao, dok username primatelja služi za formiranje isprave
        /// lokacije gdje će se datoteka uploadati
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="posiljatelj"></param>
        /// <param name="primatelj"></param>
        public async Task<int> Upload(string filePath, string posiljatelj, string primatelj)
        {
            string fileName = Path.GetFileName(filePath);
            string uploadFilePath = path + primatelj + "/primljeno/" + posiljatelj + "_" + fileName;
            byte[] fileToUpload = File.ReadAllBytes(filePath);
            using (var dbx = new DropboxClient(token))
            {
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
        /// Metoda koja preuzima datoteku sa dropbox servera
        /// </summary>
        /// <param name="primatelj"></param>
        /// <param name="posiljatelj"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public async Task<byte[]> Download(string primatelj ,string posiljatelj, string fileName)
        {
            byte[] file;
            string fullName = posiljatelj + "_" + fileName;
            string downloadFilePath = path + primatelj + "/primljeno/" + fullName;
            using (var dbx = new DropboxClient(token))
            {
                using (var response = await dbx.Files.DownloadAsync(downloadFilePath))
                {
                    file = await response.GetContentAsByteArrayAsync();
                }
            }
            return file;
        }

        /// <summary>
        /// Metoda koja briše određenu datoteku sa dropbox servera
        /// </summary>
        /// <param name="primatelj"></param>
        /// <param name="posiljatelj"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public async Task<int> DeleteFile(string primatelj, string posiljatelj, string fileName)
        {
            string fullName = posiljatelj + "_" + fileName;
            string deletePath = path + primatelj + "/primljeno/" + fullName;
            using (var dbx = new DropboxClient(token))
            {
                await dbx.Files.DeleteAsync(deletePath);
            }
            return 1;
        }
    }
}
