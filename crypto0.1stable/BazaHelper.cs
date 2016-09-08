using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypto0._1stable
{
    class BazaHelper
    {

        public void ConnectToDatabase(string connectionString)    { throw new NotImplementedException(); }
        public Korisnik GetKorisnik()
        {
            Korisnik k = new Korisnik();
            k.username = GetUsernameFromDatabase();
            k.password = GetPasswordFromDatabase();
            k.email = GetEmailFromDatabase();
            k.datumRodjenja = GetBirthDateFromDatabase();
            k.razinaPristupa = GetRazinaPristupaFromDatabase();
            return k;
        }

        public Korisnik AddKorisnikToDatabase()
        {
            throw new NotImplementedException();
        }

        public string GetUsernameFromDatabase() { throw new NotImplementedException(); }
        public string GetPasswordFromDatabase() { throw new NotImplementedException(); }
        public string GetEmailFromDatabase() { throw new NotImplementedException(); }
        public DateTime GetBirthDateFromDatabase() { throw new NotImplementedException(); }
        public int GetRazinaPristupaFromDatabase() { throw new NotImplementedException(); }
        public Poruka GetPorukaFromDatabase() { throw new NotImplementedException(); }
        
        public Poruka AddPorukaToDatabase() { throw new NotImplementedException(); }

    }
}

