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
    public partial class SlanjePoruka : Form
    {
        Form1 glavnaForma;
        Korisnik prijavljeniKorisnik;
        public SlanjePoruka(Form1 glavna, Korisnik korisnik)
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            glavnaForma = glavna;
            prijavljeniKorisnik = korisnik;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
