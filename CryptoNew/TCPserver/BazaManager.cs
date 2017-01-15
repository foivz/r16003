using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TCPserver
{
    static class BazaManager
    {
        static SqlConnection connection;
        static SqlCommand command;
        static SqlDataReader reader;

        private static string IzvadiTipPoruke(string json)
        {
            string tipPoruke = CryptoNew.JsonPretvarac.Parsiranje(json, "tipPoruke");
            return tipPoruke;
        }

        private static void OtvaranjeKonekcijeSBazom()
        {
            connection = new SqlConnection("Server = tcp:crypto.database.windows.net,1433; Data Source = crypto.database.windows.net; Initial Catalog = CryptoBaza; Persist Security Info = False; User ID = ivauzarev; Password =crypto2101!; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            connection.Open();
        }

        private static void ZatvaranjeKonekcijeSBazom()
        {
            connection.Close();
            if (reader != null) reader.Close();
        }

        public static string IzvrsiUpitNaBazi(string json)
        {
            string result = "";
            OtvaranjeKonekcijeSBazom();
            if (IzvadiTipPoruke(json) == "REGISTER")
            {
                CryptoNew.Korisnik noviKorisnik = new CryptoNew.Korisnik();
                noviKorisnik = (CryptoNew.Korisnik)CryptoNew.JsonPretvarac.Deserijalizacija(json);
                result = noviKorisnik.RegistrirajKorisnika(connection);

            }
            ZatvaranjeKonekcijeSBazom();
            return result;
        }
    }
}
