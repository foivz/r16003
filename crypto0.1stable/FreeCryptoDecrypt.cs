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
    public partial class FreeCryptoDecrypt : Form
    {
        public FreeCryptoDecrypt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = EncryptionHelper.CaesarStringEncrypt(textBox1.Text, int.Parse(textBox3.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Pogresan unos kljuca (kljuc nije unesen?)");
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                    outputFile.WriteLine(textBox2.Text);
                }

            }
        }

        //      private void button4_Click(object sender, EventArgs e)
        //     {
        //  using (Aes myAes = Aes.Create())
        //   {
        // byte[] encrypted = EncryptionHelper.AesStringEncrypt(txtText.Text, myAes.Key, myAes.IV); //treba spremiti key i IV u vanjsku datoteku kako bi se moglo dekriptirati
        //+   string roundtrip = EncryptionHelper.AesStringDecrypt(EncryptionHelper.GetBytes(textBox1.Text), EncryptionHelper.GetBytes(textBox4.Text), EncryptionHelper.GetBytes(textBox5.Text));
        //   textBox2.Text = EncryptionHelper.GetString(encrypted);
        // lblAesKey.Text += " " + EncryptionHelper.GetString(myAes.Key);
        //  lblAesIV.Text += " " + EncryptionHelper.GetString(myAes.IV);
        //+       textBox2.Text = roundtrip;
        // MessageBox.Show("Aes radi na razini byteova pa je reprezentacija malo nezgodna, probajte s datotekom :), ovo je roundtrip: " + roundtrip);
        //         }
    }
}

