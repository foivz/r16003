using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crypto0._1stable
{
    public partial class ProfilUpdateForm : Form
    {
        public ProfilUpdateForm(string username,string password,string email)
        {
            InitializeComponent();
            tbUsername.Text = username;
            tbUsername.Enabled = false;
            tbPassword.Text = password;
            tbEmail.Text = email;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TcpKlijent tcpKlijent = new TcpKlijent();
            byte[] poruka = new byte[1024];
            poruka = Encoding.ASCII.GetBytes("PRUPDATE," + tbUsername.Text + "," + tbPassword.Text + "," + tbEmail.Text + "," + dtDatumRodenja.Value.Date.ToString("yyyyMMdd") + ",");
            tcpKlijent.PosaljiServeru(poruka);
            byte[] primitak = tcpKlijent.PrimiOdServera();
            if (primitak != null)
            {
                string odgovorOdServera = Encoding.ASCII.GetString(primitak);
                MessageBox.Show(odgovorOdServera);
            }
            tcpKlijent.ZatvoriSocket();
        }
    }
}
