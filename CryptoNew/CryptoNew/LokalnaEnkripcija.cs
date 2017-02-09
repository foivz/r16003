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
            odabirAlgoritam.DataSource = new List<string> {"AES","RSA","DES","TripleDES" };
        }

        private void Ocisti()
        {
            odabirPrvo.Clear();
            odabirDrugo.Clear();
            prikazEnkriptirano.Clear();
            gumbEnkriptiraj.Enabled = false;
        }

        private void gumbGeneriraj_Click(object sender, EventArgs e)
        {
            if (odabirAlgoritam.SelectedValue == (object)"AES")
            {
                Enkripcija aesEnkripcija = new AesEnkripcija();
                aesEnkripcija.GenerirajKljucIV();
                odabirPrvo.Text=Convert.ToBase64String(aesEnkripcija.DohvatiAESKljuc());
                odabirDrugo.Text = Convert.ToBase64String(aesEnkripcija.DohvatiIV());
                trenutna = aesEnkripcija;
            }
            if (odabirAlgoritam.SelectedValue == (object)"RSA")
            {
                Enkripcija rsaEnkripcija = new RsaEnkripcija();
                rsaEnkripcija.AssignRsaKeys();
                odabirPrvo.Text = rsaEnkripcija.DohvatiJavniKljuc();
                odabirDrugo.Text = rsaEnkripcija.DohvatiPrivatniKljuc();
                trenutna = rsaEnkripcija;
            }
            if (odabirAlgoritam.SelectedValue == (object)"DES")
            {
                Enkripcija des = new DesEnkripcija();
                des.GenerirajKljucIV();
                odabirPrvo.Text = Convert.ToBase64String(des.DohvatiAESKljuc());
                odabirDrugo.Text = Convert.ToBase64String(des.DohvatiIV());
                trenutna = des;
            }
            if (odabirAlgoritam.SelectedValue == (object)"TripleDES")
            {
                Enkripcija tripleDes = new TripleDesEnkripcija();
                tripleDes.GenerirajKljucIV();
                odabirPrvo.Text = Convert.ToBase64String(tripleDes.DohvatiAESKljuc());
                odabirDrugo.Text = Convert.ToBase64String(tripleDes.DohvatiIV());
                trenutna = tripleDes;
            }
            gumbEnkriptiraj.Enabled = true;
        }

        private void gumbEnkriptiraj_Click(object sender, EventArgs e)
        {
            if (odabirAlgoritam.SelectedValue == (object)"AES")
            {
                string podaci = trenutna.EncryptData(prikazOriginal.Text);
                prikazEnkriptirano.Text = podaci;
            }
            if (odabirAlgoritam.SelectedValue == (object)"RSA")
            {
                string podaci = trenutna.EncryptData(prikazOriginal.Text);
                prikazEnkriptirano.Text = podaci;
            }
            if (odabirAlgoritam.SelectedValue == (object)"DES")
            {
                string podaci = trenutna.EncryptData(prikazOriginal.Text);
                prikazEnkriptirano.Text = podaci;
            }
            if (odabirAlgoritam.SelectedValue == (object)"TripleDES")
            {
                string podaci = trenutna.EncryptData(prikazOriginal.Text);
                prikazEnkriptirano.Text = podaci;
            }
        }

        private void odabirAlgoritam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (odabirAlgoritam.SelectedValue == (object)"RSA")
            {
                labelaPrvo.Text = "Javni:";
                labelaDrugo.Text = "Privatni:";
                Ocisti();
            }
            if (odabirAlgoritam.SelectedValue == (object)"AES" || odabirAlgoritam.SelectedValue == (object)"DES"
                || odabirAlgoritam.SelectedValue == (object)"TripleDES")
            {
                labelaPrvo.Text = "Key:";
                labelaDrugo.Text = "IV:";
                Ocisti();
            }
        }
    }
}