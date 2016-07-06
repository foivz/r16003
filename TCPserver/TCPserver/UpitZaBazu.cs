using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPserver
{
    class UpitZaBazu
    {
        private string identitetPoruke;
        private string poruka;
        private string[] elementiPoruke;
        private string upit;

        public UpitZaBazu(string item, string poruka)
        {
            identitetPoruke = item;
            this.poruka = poruka;
        }

        public List<string> dohvatiElementeIzPoruke()
        {
            List<string> result = new List<string>();
            if (identitetPoruke == "LOGIN")
            {
                result = StvoriLoginUpit();
                return result;
            }

            if (identitetPoruke == "REGISTER")
            {
                result = StvoriRegisterUpit();
                return result;
            }
            return result;
        }

        private List<string> StvoriLoginUpit()
        {
            List<string> podaciKorisnik;
            elementiPoruke = poruka.Split(',');
            upit = "Select * from Korisnici where username = '" + elementiPoruke[1] + "' and password = '" + elementiPoruke[2] + "'"; //bilo bi kvalitetno hashirati ovo nekako(?)
            //Console.WriteLine("Upit: " + upit);
            Baza baza = new Baza(upit); //proslijedivanje upita bazi
            podaciKorisnik = baza.GeneriranjeOdgovora(upit); //vraća 1 ako je korisnik pronađen, vraća 0 ako nije pronađen
            return podaciKorisnik;
        }

        private List<string> StvoriRegisterUpit()
        {
            List<string> podaciKorisnik = new List<string>();
            //Ovdje će se kreirati upit koji ce omoguciti dodavanje korisnika u bazu
            return podaciKorisnik;
        }
    }
}
