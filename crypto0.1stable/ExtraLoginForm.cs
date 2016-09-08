using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crypto0._1stable
{
    public partial class ExtraLoginForm : Form
    {
        //DriveInfo drives = DriveInfo.GetDrives().Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable);
        string curFile = @"f:\twoFactor.txt";
        string provjera;
        public ExtraLoginForm(string lozinka)
        {
            this.ControlBox = false;
            InitializeComponent();
            provjera = lozinka;
        }

        private void ExtraLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(curFile))
            {
                MessageBox.Show("Uspješno izvršena 2fa autentifikacija");
                this.Close();
            }
            else
            {
                MessageBox.Show("Neuspješno izvršena 2fa autentifikacija");
                this.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (File.Exists(curFile))
            {
                textBox1.Text = "USB pogon je aktivan";
            }

        }
    }
}
