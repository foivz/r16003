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
            unosGodina.DataSource = Enumerable.Range(1900, 2018-1800).ToList();
            unosMjesec.DataSource = Enumerable.Range(1, 12).ToList();
            IzracunajDan((int)unosGodina.SelectedItem,(int)unosMjesec.SelectedItem);
            unosGodina.SelectedItem = 1976;
        }

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
            trenutni.Status = 1;
            trenutni.TipKorisnika = "Korisnik";

            //pitanje hoce li se kljucevi generirati na serveru ili klijentu (bolja opcija je server)
        }

        private void gumbRegistracija_Click(object sender, EventArgs e)
        {
            Korisnik registrirani = new Korisnik();
            Korisnik trenutni = new Korisnik();
            PridruziPodatkeKorisniku(trenutni);
            glavnaForma.NotifyMe(registrirani);
        }

        private void unosGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            unosMjesec.SelectedItem = 1;
        }

        private void unosMjesec_SelectedIndexChanged(object sender, EventArgs e)
        {
            IzracunajDan((int)unosGodina.SelectedItem, (int)unosMjesec.SelectedItem);
        }
    }
}
