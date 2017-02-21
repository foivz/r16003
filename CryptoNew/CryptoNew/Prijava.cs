using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoNew
{
    /// <summary>
    /// Klasa forme preko koje se korisnik prijavljuje u aplikaciju
    /// </summary>
    public partial class Prijava : Form
    {
        Form1 glavnaForma;
        string validacijskaPoruka;

        /// <summary>
        /// Konstruktor klase Prijava
        /// </summary>
        /// <param name="forma"></param>
        public Prijava(Form1 forma)
        {
            InitializeComponent();
            unosPassword.PasswordChar = '*';
            Dizajner.FormaBezOkna(this);
            Dizajner.SetDefaultButton(this, gumbLogin);
            glavnaForma = forma;
        }


        /// <summary>
        /// Metoda koja provjerava sadrži li korisničko ime i lozinka bilo kakve podatke - ti podaci ne mogu biti prazni
        /// </summary>
        /// <returns></returns>
        public bool Validacija ()
        {
            bool rezultat = true; ;
            if (unosUsername.Text == "")
            {
                validacijskaPoruka = "Neispravno korisničko ime (prazno)";
                rezultat = false;
            }

            if (unosPassword.Text == "")
            {
                validacijskaPoruka = "Neispravna lozinka (prazno)";
                rezultat = false;
            }
            return rezultat;
        }

        /// <summary>
        /// Metoda koja prilagovađava veličinu forme veličini panela
        /// </summary>
        /// <param name="panel"></param>
        public void napraviResize(Panel panel)
        {
            this.Width = panel.Width;
            this.Height = panel.Height;
        }

        /// <summary>
        /// Event Handler koji se aktivira prilikom klika na gumb Login - validira se unos i šalju se podaci prema serveru te
        /// se čeka odgovor od strane servera. Postoje 3 slučaja - obavještava se glavna forma sa praznim korisničkim podacima
        /// što znači da su podaci neispravni, obavještava se glavna forma sa ispravnim korisničkim podacima te se korisnik 
        /// prijavljuje u aplikaciju, a 3. slučaj odnosi se na otvaranje 2fa forme kako bi se potvrdila prijava unosom 2fa koda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbLogin_Click(object sender, EventArgs e)
        {
            if (Validacija() == false)
            {
               MessageBox.Show(validacijskaPoruka);
               return;
            }

            Korisnik trenutniKorisnik = new Korisnik();
            trenutniKorisnik.Username = unosUsername.Text;
            trenutniKorisnik.Password = unosPassword.Text;

            try
            {
                TcpKlijent klijent = new TcpKlijent();
                klijent.PosaljiServeru(trenutniKorisnik, "PRIJAVA");
                trenutniKorisnik = null;
                trenutniKorisnik = (Korisnik)klijent.PrimiOdServera();
                if (trenutniKorisnik.Kljuc2FA == "DA")
                {
                    Forma2FA forma2FA = new Forma2FA(trenutniKorisnik, glavnaForma);
                    forma2FA.Show();
                }
                else
                {
                    glavnaForma.NotifyMe(trenutniKorisnik);
                }
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// Resetiranje forme - ovo uopćne nije potrebno zapravo
        /// </summary>
        /// <returns></returns>
        public Prijava Reset()
        {
            return new Prijava(glavnaForma);
        }

        /// <summary>
        /// Event handler koji se aktivira prilikom klika na hyperlink za registraciju korisnika - obavještava se glavna forma te
        /// će glavna forma pozvati registracijsku formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkRegistracija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            glavnaForma.NotifyRegistracija();
        }
    }
}
