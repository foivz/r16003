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
    public partial class ClientToClientForm : Form
    {
        string username;
        public ClientToClientForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form citajC2CPoruke = new CitanjePorukeForm(username);
            citajC2CPoruke.Show();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            Form saljiC2CPoruku = new PosaljiPorukuForm(username);
            saljiC2CPoruku.Show();
        }
    }
}
