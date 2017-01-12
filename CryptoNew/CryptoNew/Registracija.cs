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
        private void gumbRegistracija_Click(object sender, EventArgs e)
        {
            Korisnik registrirani = new Korisnik();
            Korisnik trenutni = new Korisnik();
            glavnaForma.NotifyMe(trenutni);
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
