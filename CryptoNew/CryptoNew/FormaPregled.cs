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
    public partial class FormaPregled : Form
    {
        Form1 glavnaForma;
        Korisnik prijavljeniKorisnik;
        public FormaPregled(Form1 forma, Korisnik korisnik)
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            glavnaForma = forma;
            prijavljeniKorisnik = korisnik;
        }
    }
}
