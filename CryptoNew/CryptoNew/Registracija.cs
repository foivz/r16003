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

        private void PostaviAutoComplete()
        {
            unosGodina.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            unosGodina.AutoCompleteSource = AutoCompleteSource.ListItems;

            unosMjesec.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            unosMjesec.AutoCompleteSource = AutoCompleteSource.ListItems;

            unosDan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            unosDan.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public Registracija(Form1 forma)
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            glavnaForma = forma;
            unosPassword.PasswordChar = '*';
            unosGodina.DataSource = Enumerable.Range(1900, DateTime.Now.Year - 1900).ToList();
            unosMjesec.DataSource = Enumerable.Range(1, 12).ToList();
            unosGodina.SelectedItem = 1976;
            IzracunajDan((int)unosGodina.SelectedItem, (int)unosMjesec.SelectedItem);
            PostaviAutoComplete();
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
            trenutni.DatumRodjenja = unosGodina.Text + "/" + unosMjesec.Text + "/" + unosDan.Text;
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

                TcpKlijent klijent = new TcpKlijent();
                klijent.PosaljiServeru(trenutni,"REGISTRACIJA");
                UspjehRegistracije uspjeh = new UspjehRegistracije();
                uspjeh = (UspjehRegistracije)klijent.PrimiOdServera();
                if (uspjeh.PotvrdaKorisnika == 0)
                {
                    MessageBox.Show("Korisnik već postoji, odaberite drugo korisničko ime");
                }
                else
                {
                    glavnaForma.NotifyMe(registrirani); //odi na login formu
                }
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
            ValidateGodina();
            ValidateMjesec();
            IzracunajDan((int)unosGodina.SelectedItem, (int)unosMjesec.SelectedItem);
            unosDan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            unosDan.AutoCompleteSource = AutoCompleteSource.ListItems;
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
            bool vaTelefon = ValidateTelefon();
            bool vaGodina = ValidateGodina();
            bool vaMjesec = ValidateMjesec();
            bool vaDan = ValidateDan();

            if (vaUsername && vaPassword && vaEmail && vaTelefon && vaGodina && vaMjesec && vaDan)
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
            else if (unosUsername.Text.Count() > 20)
            {
                errorProvider1.SetError(unosUsername, "Korisničko ime ne može imati više od 20 znakova");
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

        /// <summary>
        /// Validacija telefona na registracijskoj formi
        /// </summary>
        /// <returns></returns>
        private bool ValidateTelefon()
        {
            bool result = true;
            if (unosTelefon.Text == "")
            {
                errorProvider1.SetError(unosTelefon, "Unesite Broj Mobitela!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(unosTelefon, "");
            }
            return result;
        }

        /// <summary>
        /// Validacija godine na registracijskoj formi
        /// </summary>
        /// <returns></returns>
        private bool ValidateGodina()
        {
            bool result = true;
            if (unosGodina.Text == "")
            {
                errorProvider1.SetError(unosGodina, "Odaberite Godinu!");
                result = false;
            }
            else if (int.Parse(unosGodina.Text) < 1900)
            {
                unosGodina.Text = "1900";
            }
            else if (int.Parse(unosGodina.Text) > 2017)
            {
                unosGodina.Text = "2017";
            }
            else
            {
                errorProvider1.SetError(unosGodina, "");
            }
            return result;
        }

        /// <summary>
        /// Validacija mjeseca na registracijskoj formi
        /// </summary>
        /// <returns></returns>
        private bool ValidateMjesec()
        {
            bool result = true;
            if (unosMjesec.Text == "")
            {
                errorProvider1.SetError(unosMjesec, "Odaberite Mjesec!");
                result = false;
            }
            else if (int.Parse(unosMjesec.Text) < 1)
            {
                unosMjesec.Text = "1";
            }
            else if (int.Parse(unosMjesec.Text) > 12)
            {
                unosMjesec.Text = "12";
            }
            else
            {
                errorProvider1.SetError(unosMjesec, "");
            }
            return result;
        }

        private bool ValidateDan()
        {
            bool result = true;
            if (unosDan.Text == "")
            {
                errorProvider1.SetError(unosDan, "Odaberite Dan");
                result = false;
            }
            else if (int.Parse(unosDan.Text) < 1)
            {
                unosDan.Text = "1";
            }
            else if (int.Parse(unosDan.Text) > unosDan.Items.Count)
            {
                unosDan.Text = (unosDan.Items.Count).ToString();
            }
            else
            {
                errorProvider1.SetError(unosDan, "");
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

        private void unosTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void unosTelefon_Validating(object sender, CancelEventArgs e)
        {
            ValidateTelefon();
        }

        private void unosGodina_Validating(object sender, CancelEventArgs e)
        {
            ValidateGodina();
        }

        private void unosMjesec_Validating(object sender, CancelEventArgs e)
        {
            ValidateMjesec();
        }

        private void unosDan_Validating(object sender, CancelEventArgs e)
        {
            ValidateDan();
        }
    }
}