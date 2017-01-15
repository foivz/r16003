using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CryptoNew
{
    public class Korisnik
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        DateTime DatumRodjenja { get; set; }
        public string Kljuc2FA { get; set; }
        public string JavniKljuc { get; set; }
        public int Status { get; set; }
        public string TipKorisnika { get; set; }

        public void Ispuni(string username, string password, string ime, string prezime, string email, DateTime datumRodjenja, string telefon, string kod2FA)
        {
            Username = username;
            Password = password;
            Ime = ime;
            Prezime = prezime;
            Email = email;
            DatumRodjenja = datumRodjenja;
            BrojTelefona = telefon;
            Kljuc2FA = kod2FA;
        }

        public string RegistrirajKorisnika(SqlConnection connection)
        {
            string rezultat = "Korisnik je uspjesno registriran";
            string upit = $@"INSERT INTO Korisnik (Username, Password, Ime, Prezime, Email, BrojTelefona, DatumRodjenja,
                            Kljuc2FA, JavniKljuc,Status,TipKorisnika) values 
                            ({Username},{Password},{Ime},{Prezime},{Email},{BrojTelefona},
                            {DatumRodjenja},{Kljuc2FA},{JavniKljuc},{Status},{TipKorisnika})";
            SqlCommand command = new SqlCommand(upit, connection);
            try
            {
                command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                rezultat = "Registracija Neuspješna. Postojeći Korisnik!!!";
            }
            return rezultat;
        }
    }
}
