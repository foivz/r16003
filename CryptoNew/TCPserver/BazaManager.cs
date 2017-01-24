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
            CryptoNew.JsonPretvarac.IzbaciTipPoruke(json);
            return tipPoruke;
        }

        private static void OtvaranjeKonekcijeSBazom()
        {
            connection = new SqlConnection("Server=tcp:cryptoserver01.database.windows.net,1433;Initial Catalog=PICryptoBaza;Persist Security Info=False;User ID=ivan.uzarevic;Password=crypto2101#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
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
            if (IzvadiTipPoruke(json) == "REGISTRACIJA")
            {
                CryptoNew.Korisnik noviKorisnik = new CryptoNew.Korisnik();
                noviKorisnik = (CryptoNew.Korisnik)CryptoNew.JsonPretvarac.Deserijalizacija(json);
                result = noviKorisnik.RegistrirajKorisnika(connection);

            }
            if (IzvadiTipPoruke(json) == "PRIJAVA")
            {
                CryptoNew.Korisnik noviKorisnik = new CryptoNew.Korisnik();
                noviKorisnik = (CryptoNew.Korisnik)CryptoNew.JsonPretvarac.Deserijalizacija(json);
                result = noviKorisnik.PrijavaKorisnika(connection);

            }
            if (IzvadiTipPoruke(json) == "Potvrda2FA")
            {
                CryptoNew.Korisnik noviKorisnik = new CryptoNew.Korisnik();
                noviKorisnik = (CryptoNew.Korisnik)CryptoNew.JsonPretvarac.Deserijalizacija(json);
                result = noviKorisnik.PotvrdaKljuca2FA(connection);

            }
            ZatvaranjeKonekcijeSBazom();
            return result;
        }
    }
}
