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
    public partial class FormaPrijavljen : Form
    {
        Korisnik trenutniKorisnik;
        public FormaPrijavljen(Korisnik korisnik)
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            trenutniKorisnik = new Korisnik();
            trenutniKorisnik = korisnik;
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
