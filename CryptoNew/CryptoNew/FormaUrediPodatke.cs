using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoNew
{
    /// <summary>
    /// Klasa koja predstavlja formu za uređivanje korisničkih podataka
    /// </summary>
    public partial class FormaUrediPodatke : Form
    {
        Korisnik prijavljeniKorisnik;

        /// <summary>
        /// Konstruktor forme
        /// </summary>
        /// <param name="korisnik"></param>
        public FormaUrediPodatke(Korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
            PostaviPocetnePostavke();
        }

        /// <summary>
        /// Postavlja početne postavke kontroli na formi
        /// </summary>
        private void PostaviPocetnePostavke()
        {
            urediIme.Text = prijavljeniKorisnik.Ime;
            urediPrezime.Text = prijavljeniKorisnik.Prezime;
            urediEmail.Text = prijavljeniKorisnik.Email;
            urediBrojTelefona.Text = prijavljeniKorisnik.BrojTelefona.Substring(4);
        }

        /// <summary>
        /// Dohvaća podatke sa forme i šalje ih prema serveru radi ažuriranja podataka
        /// </summary>
        private void DohvatiIPosalji()
        {
            TcpKlijent klijent = new TcpKlijent();
            prijavljeniKorisnik.Ime = urediIme.Text;
            prijavljeniKorisnik.Prezime = urediPrezime.Text;
            prijavljeniKorisnik.Email = urediEmail.Text;
            prijavljeniKorisnik.BrojTelefona = "+385" + urediBrojTelefona.Text;
            klijent.PosaljiServeru(prijavljeniKorisnik,"UrediPodatke");
            prijavljeniKorisnik = (Korisnik)klijent.PrimiOdServera();
        }

        /// <summary>
        /// Validacija emaila na formi za uređivanje podataka
        /// </summary>
        /// <returns></returns>
        private bool ValidateEmail()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            Regex ValidEmailRegex = new Regex(validEmailPattern, RegexOptions.IgnoreCase);

            bool result = true;
            if (urediEmail.Text == "")
            {
                errorProvider1.SetError(urediEmail, "Unesite email!");
                result = false;
            }
            else if (!ValidEmailRegex.IsMatch(urediEmail.Text))
            {
                errorProvider1.SetError(urediEmail, "Neispravan format Email adrese");
                result = false;
            }
            else
            {
                errorProvider1.SetError(urediEmail, "");
            }
            return result;
        }

        /// <summary>
        /// Validacija telefona na formi za uređivanje podataka
        /// </summary>
        /// <returns></returns>
        private bool ValidateTelefon()
        {
            bool result = true;
            if (urediBrojTelefona.Text == "")
            {
                errorProvider1.SetError(urediBrojTelefona, "Unesite Broj Mobitela!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(urediBrojTelefona, "");
            }
            return result;
        }

        /// <summary>
        /// Validacija cjelokupne forme
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {

            bool vaEmail = ValidateEmail();
            bool vaTelefon = ValidateTelefon();

            if (vaEmail && vaTelefon)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Event handler koji šalje nove podatke prema serveru i nakon toga zatvara formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbPosalji_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DohvatiIPosalji();
                Close();
            }
        }
    }
}
