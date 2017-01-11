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
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            //txtKorisnik.Text = korisnik.Username;
            trenutniKorisnik = korisnik;
        }

        public FormaPrijavljen Reset()
        {
            return new FormaPrijavljen(trenutniKorisnik); ;
        }
    }
}
