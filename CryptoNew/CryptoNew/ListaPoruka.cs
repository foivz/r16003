using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    class ListaPoruka
    {
        public string Username { get; set; }
        public string Tip { get; set; }
        public List<Poruka> Poruke { get; set; }

        public ListaPoruka()
        {
            Tip = "ListaPoruka";
            Poruke = new List<Poruka>();
        }

        public string DohvatiPrimljenePoruke(SqlConnection connection)
        {
            string rezultat = "";
            Poruka poruka;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * from Poruka,EnkriptiraniPaket WHERE Primatelj=@Username AND IdPaketa=EnkriptiraniPaket.Id";
            command.Parameters.AddWithValue("@Username", Username);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    poruka = new Poruka();
                    poruka.DatumSlanja = (DateTime)reader["DatumSlanja"];
                    poruka.Posiljatelj = reader["Posiljatelj"].ToString();
                    poruka.Primatelj = reader["Primatelj"].ToString();
                    poruka.Paket.EnkriptiraniKljuc = reader["EnkriptiraniKljuc"].ToString();
                    poruka.Paket.EnkriptiraniPodaci = reader["EnkriptiraniPodaci"].ToString();
                    poruka.Paket.Iv = (byte[])reader["Iv"];
                    Poruke.Add(poruka);
                }
            }
            rezultat = JsonPretvarac.Serijalizacija(this);
            return rezultat;
        }
    }
}
