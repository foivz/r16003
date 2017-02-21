using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    /// <summary>
    /// Klasa koja upravlja adminskim radnjama na serveru i na bazi podataka
    /// </summary>
    static class AdminPanel
    {
        static ListaKorisnika listaKorisnika;
        /// <summary>
        /// Metoda koja ažurira status korisnika u bazi podataka na temelju poslanih podataka od strane klijenta
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="korisnik"></param>
        /// <returns></returns>
        public static string PromijeniStatusKorisnika(SqlConnection connection, Korisnik korisnik)
        {
            string rezultat = "";
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE Korisnik SET Status = @Status WHERE Username=@Username";
            command.Parameters.AddWithValue("@Status", korisnik.Status);
            command.Parameters.AddWithValue("@Username", korisnik.Username);
            command.ExecuteNonQuery();

            listaKorisnika = new ListaKorisnika();
            rezultat = listaKorisnika.DohvatiKorisnike(connection);

            return rezultat;
        }

        /// <summary>
        /// Metoda koja šalje svim korisnicima aplikacije adminski mail - mail vezan uz aplikaciju. Prvo se dohvaćaju
        /// svi mailovi iz baze podataka te se zatim salje mail svim korisnicima
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="adminMail"></param>
        /// <returns></returns>
        public static string PosaljiAdminMail(SqlConnection connection, AdminMail adminMail)
        {
            List<string> emailovi = new List<string>();
            string rezultat = "";

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT Email from Korisnik";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    emailovi.Add(reader["Email"].ToString());
                }
            }

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("protect1zu95@gmail.com", "crypto2101pi#"),
                EnableSsl = true
            };

            MailMessage msg = new MailMessage();
            msg.Subject = "Admin Poruka - Crypto Aplikacija";
            msg.Body = adminMail.Sadrzaj;
            msg.From = new MailAddress("protect1zu95@gmail.com");
            foreach (var item in emailovi)
            {
                msg.To.Add(item);
            }
            try
            {
                client.Send(msg);
                adminMail.Status = 1;
            }
            catch
            {
                adminMail.Status = 0;
            }
            rezultat = JsonPretvarac.Serijalizacija(adminMail);
            return rezultat;
        }
    }
}
