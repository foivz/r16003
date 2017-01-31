using Dropbox.Api;
using System;
using System.Collections.Generic;
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
    }
}
