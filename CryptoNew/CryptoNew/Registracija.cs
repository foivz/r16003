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
        public Registracija(Form1 forma)
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            glavnaForma = forma;
        }

        private void gumbRegistracija_Click(object sender, EventArgs e)
        {
            Korisnik trenutni = new Korisnik();
            glavnaForma.NotifyMe(trenutni);
        }
    }
}
