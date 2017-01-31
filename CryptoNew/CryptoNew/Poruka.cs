using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    public class UspjehSlanjaPoruke
    {
        public string Tip { get; set; }
        public string PorukaPoslana { get; set; }

        public UspjehSlanjaPoruke(string poslano)
        {
            Tip = "UspjehSlanjaPoruke";
            PorukaPoslana = poslano;
        }
    }

    public class EnkripcijskiPaket
    {
        public string EnkriptiraniKljuc;
        public string EnkriptiraniPodaci;
        public byte[] Iv;
    }

    public class Poruka
    {
        public string Tip { get; set; }
        public string Posiljatelj { get; set; }
        public string Primatelj { get; set; }
        public DateTime DatumSlanja { get; set; }
        public EnkripcijskiPaket Paket { get; set; }

        public Poruka()
        {
            Tip = "Poruka";
            Paket = new EnkripcijskiPaket();
        }

        public void FormirajEnkripcijskiPaket(string sadrzaj, string javniKljuc)
        {
            Paket = HibridnaEnkripcija.EncryptData(sadrzaj, javniKljuc);
        }

        public string ZapisiPorukuUBazu(SqlConnection connection)
        {
            string rezultat = "";
            UspjehSlanjaPoruke uspjeh = new UspjehSlanjaPoruke("DA");
            int idEnkriptiraniPaket;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO EnkriptiraniPaket(EnkriptiraniKljuc,EnkriptiraniPodaci,Iv) OUTPUT INSERTED.Id VALUES (@EnkriptiraniKljuc,@EnkriptiraniPodaci,@Iv)";
            command.Parameters.AddWithValue("@EnkriptiraniKljuc", Paket.EnkriptiraniKljuc);
            command.Parameters.AddWithValue("@EnkriptiraniPodaci", Paket.EnkriptiraniPodaci);
            command.Parameters.AddWithValue("@Iv", Paket.Iv);
            idEnkriptiraniPaket=(int)command.ExecuteScalar();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Poruka(Posiljatelj,Primatelj,DatumSlanja,IdPaketa) VALUES (@Posiljatelj,@Primatelj,@DatumSlanja,@IdPaketa)";
            command.Parameters.AddWithValue("@Posiljatelj", Posiljatelj);
            command.Parameters.AddWithValue("@Primatelj", Primatelj);
            command.Parameters.AddWithValue("@DatumSlanja", DatumSlanja);
            command.Parameters.AddWithValue("@IdPaketa", idEnkriptiraniPaket);
            command.ExecuteNonQuery();

            rezultat = JsonPretvarac.Serijalizacija(uspjeh);
            return rezultat;
        }
    }
}
