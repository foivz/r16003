using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace CryptoNew
{
    public partial class Registracija : Form
    {
        Form1 glavnaForma;
        public void IzracunajDan(int godina, int mjesec)
        {
            unosDan.DataSource = Enumerable.Range(1, DateTime.DaysInMonth(godina, mjesec)).ToList();
        }

        public Registracija(Form1 forma)
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            glavnaForma = forma;
            unosGodina.DataSource = Enumerable.Range(1900, 2018 - 1800).ToList();
            unosMjesec.DataSource = Enumerable.Range(1, 12).ToList();
            IzracunajDan((int)unosGodina.SelectedItem, (int)unosMjesec.SelectedItem);
            unosGodina.SelectedItem = 1976;
            unosUsername.Focus();
        }

        /// <summary>
        /// Pridruživanje podataka sa forme korisniku koji se želi registrirati
        /// </summary>
        /// <param name="trenutni"></param>
        private void PridruziPodatkeKorisniku (Korisnik trenutni)
        {
            trenutni.Ime = unosIme.Text;
            trenutni.Prezime = unosPrezime.Text;
            trenutni.Username = unosUsername.Text;
            trenutni.Password = unosPassword.Text;
            trenutni.Email = unosEmail.Text;
            trenutni.BrojTelefona = unosTelefon.Text;
            string datumRodjenja = unosDan.Text + "/" + unosMjesec.Text + "/" + unosGodina.Text;
            trenutni.DatumRodjenja = Convert.ToDateTime(datumRodjenja);
            trenutni.Status = 1; //korisnik je otkljucan
            trenutni.TipKorisnika = "Korisnik";

            //pitanje hoce li se kljucevi generirati na serveru ili klijentu (bolja opcija je server)
        }

        private void gumbRegistracija_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                Korisnik registrirani = new Korisnik();
                Korisnik trenutni = new Korisnik();
                PridruziPodatkeKorisniku(trenutni);
                glavnaForma.NotifyMe(registrirani);
            }
            else
            {
                MessageBox.Show("Postoje neispravni podaci na formi - provjerite ih!");
            }
        }

        private void unosGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            unosMjesec.SelectedItem = 1;
        }

        private void unosMjesec_SelectedIndexChanged(object sender, EventArgs e)
        {
            IzracunajDan((int)unosGodina.SelectedItem, (int)unosMjesec.SelectedItem);
        }

        /// <summary>
        /// Validacija cjelokupne forme
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            bool vaUsername = ValidateUsername();
            bool vaPassword = ValidatePassword();
            bool vaEmail = ValidateEmail();
            if (vaUsername && vaPassword && vaEmail )
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validacija Korisničkoga imena na formi
        /// </summary>
        /// <returns></returns>
        private bool ValidateUsername()
        {
            bool result = true;
            if (unosUsername.Text == "")
            {
                errorProvider1.SetError(unosUsername, "Unesite korisničko ime!");
                result = false;
            }
            else if (unosUsername.Text.Count() < 5)
            {
                errorProvider1.SetError(unosUsername, "Korisničko ime mora imati najmanje 5 znakova");
                result = false;
            }
            else
            {
                errorProvider1.SetError(unosUsername, "");
            }
            return result;
        }

        /// <summary>
        /// Validacija lozinke na registracijskoj formi
        /// </summary>
        /// <returns></returns>
        private bool ValidatePassword()
        {
            bool result = true;
            if (unosPassword.Text == "")
            {
                errorProvider1.SetError(unosPassword, "Unesite lozinku!");
                result = false;
            }
            else if (unosPassword.Text.Count() < 5)
            {
                errorProvider1.SetError(unosPassword, "Lozinka mora imati najmanje 5 znakova");
                result = false;
            }
            else
            {
                errorProvider1.SetError(unosPassword, "");
            }
            return result;
        }

        /// <summary>
        /// Validacija emaila na registracijskoj formi
        /// </summary>
        /// <returns></returns>
        private bool ValidateEmail()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            Regex ValidEmailRegex = new Regex(validEmailPattern, RegexOptions.IgnoreCase);

            bool result = true;
            if (unosEmail.Text == "")
            {
                errorProvider1.SetError(unosEmail, "Unesite email!");
                result = false;
            }
            else if (!ValidEmailRegex.IsMatch(unosEmail.Text))
            {
                errorProvider1.SetError(unosEmail, "Neispravan format Email adrese");
                result = false;
            }
            else
            {
                errorProvider1.SetError(unosEmail, "");
            }
            return result;
        }

        private void unosUsername_Validating(object sender, CancelEventArgs e)
        {
            ValidateUsername();
        }

        private void unosPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void unosPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidatePassword();
        }

        private void unosEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void unosEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmail();
        }
    }
}