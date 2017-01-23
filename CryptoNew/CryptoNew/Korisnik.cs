using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CryptoNew
{

    public class UspjehRegistracije
    {
        public string Tip { get; set; }
        public int PotvrdaKorisnika { get; set; }

        public UspjehRegistracije()
        {
            Tip = "UspjehRegistracije";
        }
    }
    public class Korisnik
    {
        public string Tip { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string DatumRodjenja { get; set; }
        public string Kljuc2FA { get; set; }
        public string JavniKljuc { get; set; }
        public int Status { get; set; }
        public string TipKorisnika { get; set; }

        public Korisnik()
        {
            Tip = "Korisnik";
            Kljuc2FA = "null";
            JavniKljuc = "null";
        }

        private void ZapisiKljuceveUBazu(SqlConnection connection)
        {
            var command = new SqlCommand();
            Enkripcija enkripcija = new RsaEnkripcija();
            enkripcija.AssignRsaKeys();
            JavniKljuc = enkripcija.DohvatiJavniKljuc();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE Korisnik SET JavniKljuc = @JavniKljuc WHERE Username=@Username";
            command.Parameters.AddWithValue("@JavniKljuc", JavniKljuc);
            command.Parameters.AddWithValue("@Username", Username);
            command.ExecuteNonQuery();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO PrivatniKljucevi(Username,PrivatniKljuc) VALUES (@Username,@PrivatniKljuc)";
            command.Parameters.AddWithValue("@PrivatniKljuc", enkripcija.DohvatiPrivatniKljuc());
            command.Parameters.AddWithValue("@Username", Username);
            command.ExecuteNonQuery();

            if (Kljuc2FA == "DA")
            {
                Verficiranje2FA verificiranje = new Verficiranje2FA();
                Kljuc2FA = verificiranje.GenerirajKljuc2FA();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Korisnik SET Kljuc2FA = @Kljuc2FA WHERE Username=@Username";
                command.Parameters.AddWithValue("@Kljuc2FA", Kljuc2FA);
                command.Parameters.AddWithValue("@Username", Username);
                command.ExecuteNonQuery();
            }
        }

        public string RegistrirajKorisnika(SqlConnection connection)
        {
            string rezultat;
            int tip_korisnika = 1;
            UspjehRegistracije uspjeh = new UspjehRegistracije();
            uspjeh.PotvrdaKorisnika = 1;
            if (TipKorisnika == "Korisnik")
            {
                tip_korisnika = 2;
            }

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT into Korisnik (Username, Password, Ime, Prezime, Email, BrojTelefona, DatumRodjenja, Status, TipKorisnika) VALUES(@Username, @Password, @Ime, @Prezime, @Email, @BrojTelefona, @DatumRodjenja, @Status, @tip_korisnika)";
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Ime", Ime);
            command.Parameters.AddWithValue("@Prezime", Prezime);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@BrojTelefona", BrojTelefona);
            command.Parameters.AddWithValue("@DatumRodjenja", DatumRodjenja);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@tip_korisnika", tip_korisnika);
            try
            {
                command.ExecuteNonQuery();
                ZapisiKljuceveUBazu(connection);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                uspjeh.PotvrdaKorisnika = 0;
            }
            rezultat = JsonPretvarac.Serijalizacija(uspjeh);
            return rezultat;
        }
    }
}
