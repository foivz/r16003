using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    static class AdminPanel
    {
        public static string PromijeniStatusKorisnika(SqlConnection connection, Korisnik korisnik)
        {
            ListaKorisnika listaKorisnika = new ListaKorisnika();
            string rezultat = "";
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE Korisnik SET Status = @Status WHERE Username=@Username";
            command.Parameters.AddWithValue("@Status", korisnik.Status);
            command.Parameters.AddWithValue("@Username", korisnik.Username);
            command.ExecuteNonQuery();

            rezultat = listaKorisnika.DohvatiKorisnike(connection);

            return rezultat;
        }
    }
}
