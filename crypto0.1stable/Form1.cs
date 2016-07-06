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
        private string pristup = "Guest";
        public frmCrypto()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Udi u login formu
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            Form registracijaForm = new Form();
            registracijaForm.Show();
        }

        private void btnFreeCrypto_Click(object sender, EventArgs e)
        {
            var EncryptOrDecrypt = new EncryptOrDecrypt();
            EncryptOrDecrypt.Show();

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

        private void frmCrypto_Load(object sender, EventArgs e)
        {
            lblPristup.Text = pristup;
        }

        private void updateProfil_Click(object sender, EventArgs e)
        {
            var updateForm = new ProfilUpdateForm();
            updateForm.Show();
        }

        public void promijeniPristup(int razinaAkt)
        {
            if (razinaAkt == 1)
            {
                this.pristup = "Admin";
            }
            else if (razinaAkt == 2)
            {
                this.pristup = "Moderator";
            }
            else
            {
                this.pristup = "Korisnik";
            }
        }
    }
}
