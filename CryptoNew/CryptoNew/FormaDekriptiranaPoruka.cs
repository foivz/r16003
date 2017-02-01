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
    /// <summary>
    /// Klasa forme koja prikazuje enkriptirani i dekriptirani tekst poruka koje je korisnik primio od drugih korisnika
    /// </summary>
    public partial class FormaDekriptiranaPoruka : Form
    {
        /// <summary>
        /// Konstruktor forme koji za parametar ima objekt 'Poruka' kako bi se uopce mogao prikazati enkriptirani i
        /// dekriptirani tekst
        /// </summary>
        /// <param name="poruka"></param>
        public FormaDekriptiranaPoruka(Poruka poruka)
        {
            InitializeComponent();
            prikazEnkriptiran.Text = poruka.Paket.EnkriptiraniPodaci;
            string privatniKljuc = DohvatiPrivatniKljuc(poruka.Primatelj);
            string dekriptiranaPoruka = HibridnaEnkripcija.DecryptData(poruka, privatniKljuc);
            prikazDekriptiran.Text = dekriptiranaPoruka;
        }

        /// <summary>
        /// Metoda koja dohvaća privatni ključ iz baze podataka na temelju prijavljenoga korisnika
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
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
