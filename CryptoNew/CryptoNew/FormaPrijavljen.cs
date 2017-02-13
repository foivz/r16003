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
    /// Klasa forme koja je zapravo ekran dobrodošlice za korisnika koji se prijavi u aplikaciju
    /// </summary>
    public partial class FormaPrijavljen : Form
    {
        Korisnik trenutniKorisnik;
        /// <summary>
        /// Konstruktor FormaPrijavljen koja postavlja na ekran dobrodošlice Username i Tip Korisnika
        /// </summary>
        /// <param name="korisnik"></param>
        public FormaPrijavljen(Korisnik korisnik)
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            trenutniKorisnik = new Korisnik();
            trenutniKorisnik = korisnik;
            prikazKorIme.Text = trenutniKorisnik.Username;
            prikazTipKorisnika.Text = trenutniKorisnik.TipKorisnika;
        }

        /// <summary>
        /// Resetiranje forme, zapravo ovo uopće nije potrebno
        /// </summary>
        /// <returns></returns>
        public FormaPrijavljen Reset()
        {
            return new FormaPrijavljen(trenutniKorisnik); ;
        }

        /// <summary>
        /// Event handler koji se aktivira nakon što se forma učita, samo prikazuje trenutnu Username korisnika na ekran zajedno
        /// sa Tipom Korisnika (admin ili obični korisnik)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormaPrijavljen_Load(object sender, EventArgs e)
        {
            prikazKorIme.Text = trenutniKorisnik.Username;
            prikazTipKorisnika.Text = trenutniKorisnik.TipKorisnika;
        }

        /// <summary>
        /// Event handler koji se aktivira prilikom klika na gumb "Uredi podatke" te otvara formu za uređivanje podataka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbUrediPodatke_Click(object sender, EventArgs e)
        {
            FormaUrediPodatke novaForma = new FormaUrediPodatke(trenutniKorisnik);
            novaForma.StartPosition = FormStartPosition.CenterParent;
            novaForma.ShowDialog();
        }
    }
}
