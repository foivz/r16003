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
    public partial class OtkZakForm : Form
    {
        public OtkZakForm()
        {
            InitializeComponent();
        }

        private void OtkZakForm_Load(object sender, EventArgs e)
        {
            listaKorisnika.View = View.Details;
            string[] row = { "s1", "s2", "s3" };
            var listViewItem = new ListViewItem(row);
            listaKorisnika.Items.Add(listViewItem);
        }
    }
}
