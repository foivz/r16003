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
    public partial class LokalnaEnkripcija : Form
    {
        Enkripcija trenutna;
        public LokalnaEnkripcija()
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            odabirAlgoritam.DataSource = new List<string> {"AES","RSA" };
        }

        private void gumbGeneriraj_Click(object sender, EventArgs e)
        {
            if (odabirAlgoritam.SelectedValue == (object)"AES")
            {
                Enkripcija aesEnkripcija = new AesEnkripcija();
                aesEnkripcija.GenerirajKljucIV();
                odabirPrvo.Text=aesEnkripcija.DohvatiAESKljuc();
                odabirDrugo.Text = aesEnkripcija.DohvatiIV();
                trenutna = aesEnkripcija;
            }
            gumbEnkriptiraj.Enabled = true;
        }

        private void gumbEnkriptiraj_Click(object sender, EventArgs e)
        {
            if (odabirAlgoritam.SelectedValue == (object)"AES")
            {
                byte[] podaci = trenutna.EncryptData(prikazOriginal.Text);
                prikazEnkriptirano.Text = trenutna.PrikazEnkriptiranihPodataka(podaci);
            }
        }
    }
}
