using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypto0._1stable
{
    class Korisnik
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public DateTime datumRodjenja { get; set; }
        public int razinaPristupa { get; set; } //moze biti 1,2,3 (ovisno je li admin,moderator,korisnik)
        public bool aktivnost { get; set; }

        public void Dodaj(string username1, string password1, string email1, DateTime datum1, int razina1, bool aktivnost1)
        {
            username = username1;
            password = password1;
            email = email1;
            datumRodjenja = datum1;
            razinaPristupa = razina1;
            aktivnost = aktivnost1;
        }

        public string GetUsername()
        {
            return this.username;
        }

        public string GetPassword()
        {
            return this.password;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public DateTime GetDatumRodjenja()
        {
            return this.datumRodjenja;
        }

        public int GetRazinaPristupa()
        {
            return this.razinaPristupa;
        }

        public bool GetAktivnost()
        {
            return this.aktivnost;
        }
    }
}
