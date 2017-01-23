using Dropbox.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    class DropboxManager
    {
        string token = "kU5cuLun14AAAAAAAAAADuqHTOzUyYuSfqbF0ekL2tcaiqfQiuRcYrpjbrvxBbDQ";
        string path = "/crypto/";

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
