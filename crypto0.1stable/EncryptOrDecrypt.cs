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
    public partial class EncryptOrDecrypt : Form
    {
        public EncryptOrDecrypt()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (radbtnEncrypt.Checked && radbtnText.Checked)                    //encrypt text
            {
               
                var FreeCryptoEncrypt = new FreeCryptoEncrypt();
                FreeCryptoEncrypt.Show();
                this.Close();
            }

            if (radbtnDecrypt.Checked && radbtnText.Checked)                     //decrypt text
            {
               
                var FreeCryptoDecrypt = new FreeCryptoDecrypt();
                FreeCryptoDecrypt.Show();
                Close();
            }

            if (radbtnEncrypt.Checked && radbtnDatoteka.Checked)               //encrypt file    
            {
          
                DialogResult resultEncrypt = openFileDialog1.ShowDialog();
                if (resultEncrypt == DialogResult.OK)
                {

                    if (Path.GetExtension(openFileDialog1.FileName) == ".txt")        //????
                    {
                        string secretKey = EncryptionHelper.GenerateDESKey();
                        EncryptionHelper.EncryptFileDES(openFileDialog1.FileName, @"E:\Encrypted.txt", secretKey);
                        textBox1.Text = secretKey;
                    }


                }
            }
            if (radbtnDecrypt.Checked && radbtnDatoteka.Checked)                //decrypt file
            {
            
                DialogResult resultDecrypt = openFileDialog2.ShowDialog();
                if (resultDecrypt == DialogResult.OK)
                {

              //      if (Path.GetExtension(openFileDialog2.FileName) == ".txt")        //????
                //    {

                        string secretKey = textBox1.Text;
                        EncryptionHelper.DecryptFileDES(openFileDialog2.FileName, @"E:\Decrypted", secretKey);
             //       }

                }
            }
        }
    }
}

