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
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string email = tbEmail.Text;
            string datum = tbDatum.Text;
            string upit = "update Korisnici set username='"+username+"',password='"+password+ "',email='" + email + "',datumRodjenja='" + datum + "' where username='" + username +"';";
            SqlConnection connection = new SqlConnection("Server = tcp:crypto.database.windows.net,1433; Data Source = crypto.database.windows.net; Initial Catalog = CryptoBaza; Persist Security Info = False; User ID = ivauzarev; Password =crypto2101!; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            SqlCommand commandUpdate = new SqlCommand(upit,connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = commandUpdate.ExecuteReader();
                MessageBox.Show("Vaši podaci su uspješno ažurirani");
            }
            catch (Exception)
            {
                MessageBox.Show("Vaši podaci nisu uspješno ažurirani");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
