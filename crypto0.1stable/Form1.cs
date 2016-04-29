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
    public partial class frmCrypto : Form
    {
        public frmCrypto()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form loginForm = new Form();
            loginForm.Show();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            Form registracijaForm = new Form();
            registracijaForm.Show();
        }

        private void btnFreeCrypto_Click(object sender, EventArgs e)
        {
            Form freeCryptoForm = new Form();
            freeCryptoForm.Show();
        }

        private void btnC2C_Click(object sender, EventArgs e)
        {
            Form C2CForm = new Form();
            C2CForm.Show();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            Form chatForm = new Form();
            chatForm.Show();
        }
    }
}
