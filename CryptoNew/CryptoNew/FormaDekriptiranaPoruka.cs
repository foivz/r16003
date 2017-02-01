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

namespace CryptoNew
{
    public partial class FormaDekriptiranaPoruka : Form
    {
        public FormaDekriptiranaPoruka(Poruka poruka)
        {
            InitializeComponent();
            prikazEnkriptiran.Text = poruka.Paket.EnkriptiraniPodaci;
            string privatniKljuc = DohvatiPrivatniKljuc(poruka.Primatelj);
            string dekriptiranaPoruka = HibridnaEnkripcija.DecryptData(poruka, privatniKljuc);
            prikazDekriptiran.Text = dekriptiranaPoruka;
        }

        private string DohvatiPrivatniKljuc(string username)
        {
            string rezultat = "";
            SqlConnection connection = new SqlConnection("Server=tcp:cryptoserver01.database.windows.net,1433;Initial Catalog=PICryptoBaza;Persist Security Info=False;User ID=ivan.uzarevic;Password=crypto2101#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            connection.Open();
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM PrivatniKljucevi WHERE Username=@Username";
            command.Parameters.AddWithValue("@Username", username);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    rezultat = reader["PrivatniKljuc"].ToString();
                }
                reader.Close();
            }
            connection.Close();
            return rezultat;
        }
    }
}
