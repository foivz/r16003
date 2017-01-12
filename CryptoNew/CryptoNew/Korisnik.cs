using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    public class Korisnik
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        DateTime DatumRodjenja { get; set; }
        public string BrojTelefona { get; set; }
        public string Kod2FA { get; set; }

        public void Ispuni(string username, string password, string ime, string prezime, string email, DateTime datumRodjenja, string telefon, string kod2FA)
        {
            Username = username;
            Password = password;
            Ime = ime;
            Prezime = prezime;
            Email = email;
            DatumRodjenja = datumRodjenja;
            BrojTelefona = telefon;
            Kod2FA = kod2FA;
        }
    }
}
