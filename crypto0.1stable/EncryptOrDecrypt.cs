using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            if(radbtnDecrypt.Checked && radbtnText.Checked)                     //decrypt text
            {
                throw new NotImplementedException();
            }
        }
    }
}
