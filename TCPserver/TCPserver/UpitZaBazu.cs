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

        public void dohvatiElementeIzPoruke()
        {
            if(identitetPoruke == "LOGIN")
                StvoriLoginUpit();

            if (identitetPoruke == "REGISTER")
                StvoriRegisterUpit();
        }

        private void StvoriLoginUpit()
        {
            elementiPoruke = poruka.Split(',');
            upit = "Select * from korisnik where username = '" + elementiPoruke[1] + "' and password = '" + elementiPoruke[2] + "'";
            Console.WriteLine("Upit: " + upit);
            //Baza baza = new Baza(upit); proslijedi upit bazi
        }

        private void StvoriRegisterUpit()
        {
            //
        }
    }
}
