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

        public FormaPrijavljen Reset()
        {
            return new FormaPrijavljen(trenutniKorisnik); ;
        }

        private void FormaPrijavljen_Load(object sender, EventArgs e)
        {
            prikazKorIme.Text = trenutniKorisnik.Username;
            prikazTipKorisnika.Text = trenutniKorisnik.TipKorisnika;
        }
    }
}
