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
    public partial class Prijava : Form
    {
        Form1 glavnaForma;
        string validacijskaPoruka;

        public Prijava(Form1 forma)
        {
            InitializeComponent();
            unosPassword.PasswordChar = '*';
            Dizajner.FormaBezOkna(this);
            glavnaForma = forma;
        }

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

        public void napraviResize(Panel panel)
        {
            this.Width = panel.Width;
            this.Height = panel.Height;
        }

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
            TcpKlijent klijent = new TcpKlijent();
            klijent.PosaljiServeru(trenutniKorisnik, "PRIJAVA");
            trenutniKorisnik = (Korisnik)klijent.PrimiOdServera();
            glavnaForma.NotifyMe(trenutniKorisnik);
        }

        public Prijava Reset()
        {
            return new Prijava(glavnaForma);
        }

        private void linkRegistracija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            glavnaForma.NotifyRegistracija();
        }
    }
}
