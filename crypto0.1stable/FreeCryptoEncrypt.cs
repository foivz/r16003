using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crypto0._1stable
{
    public partial class FreeCryptoEncrypt : Form
    {
        public FreeCryptoEncrypt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtModified.Text = EncryptionHelper.CaesarStringEncrypt(txtText.Text, int.Parse(txtCaesarKey.Text));
            }
            catch (Exception )
            {
                MessageBox.Show("Pogresan unos kljuca (kljuc nije unesen?)");
            }
        }

        private void btnExporttxt_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.DefaultExt = "txt";
            dialog.CreatePrompt = true;
            dialog.OverwritePrompt = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter outputFile = new StreamWriter(dialog.FileName))
                {
                    outputFile.WriteLine(txtModified.Text);
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Aes myAes = Aes.Create())
            {
                byte[] encrypted = EncryptionHelper.AesStringEncrypt(txtText.Text, myAes.Key, myAes.IV); //treba spremiti key i IV u vanjsku datoteku kako bi se moglo dekriptirati, oni se automatski generiraju
                string roundtrip = EncryptionHelper.AesStringDecrypt(encrypted, myAes.Key, myAes.IV);
                txtModified.Text = EncryptionHelper.GetString(encrypted);
                textBox1.Text = EncryptionHelper.GetString(myAes.Key);
                textBox2.Text = EncryptionHelper.GetString(myAes.IV);
                MessageBox.Show("Aes radi na razini byteova pa je reprezentacija malo nezgodna, probajte s datotekom :), ovo je roundtrip: " + roundtrip);
            }
        }
    }
}
