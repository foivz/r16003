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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnPotvrdi_Click_1(object sender, EventArgs e)
        {
            //Povezivanje sa serverom pomocu TCP-a, server obavlja provjeru

            if (txtUser.Text.Length > 3 && txtPass.Text.Length > 3)
            {
                TcpKlijent tcpKlijent = new TcpKlijent();
                byte[] poruka = new byte[1024];
                poruka = Encoding.ASCII.GetBytes("[LOGIN]," + txtUser.Text + "," + txtPass.Text + ",");
                tcpKlijent.PosaljiServeru(poruka);
                byte[] novo = tcpKlijent.PrimiOdServera();
                frmCrypto obrada = new frmCrypto();
                obrada.promijeniPristup(1);
                tcpKlijent.ZatvoriSocket();
            }
            else MessageBox.Show("Username i password moraju imati vise od 3 charactera");
        }
    }
}
