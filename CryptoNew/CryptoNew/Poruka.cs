using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    /// <summary>
    /// Klasa koja predstavlja Uspjeh slanja poruke - je li poruka poslana ili nije
    /// </summary>
    public class UspjehSlanjaPoruke
    {
        public string Tip { get; set; }
        public string PorukaPoslana { get; set; }

        /// <summary>
        /// Konstruktor klase UspjehSlanjaPoruke
        /// </summary>
        /// <param name="poslano"></param>
        public UspjehSlanjaPoruke(string poslano)
        {
            Tip = "UspjehSlanjaPoruke";
            PorukaPoslana = poslano;
        }
    }

    /// <summary>
    /// Klasa koja sadrži podatke o enkripcijskom paketu neke poruke - enkriptirani ključ, enkriptirane podatke i inicijalizacijski
    /// vektor
    /// </summary>
    public class EnkripcijskiPaket
    {
        public string EnkriptiraniKljuc;
        public string EnkriptiraniPodaci;
        public byte[] Iv;

        private byte[] datoteka;

        public void PridruziDatoteku(byte[] file)
        {
            datoteka = file;
        }

        public byte[] VratiDatoteku()
        {
            return datoteka;
        }
    }

    /// <summary>
    /// Klasa Poruka koja predstavlja koja sadrži sve osnovne podatke o određenoj poruci, svojstva ove klase zapravo predstavljaju
    /// stupce odgovarajuće tablice u bazi podataka
    /// </summary>
    public class Poruka
    {
        public string Tip { get; set; }
        public string Posiljatelj { get; set; }
        public string Primatelj { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumSlanja { get; set; }
        public EnkripcijskiPaket Paket { get; set; }

        /// <summary>
        /// Konstruktor Klase Poruka - inicijalizira prazni enkripcijski paket koj se kasnije popunjava
        /// </summary>
        public Poruka()
        {
            Tip = "Poruka";
            Paket = new EnkripcijskiPaket();
        }

        /// <summary>
        /// Metoda koja enkriptira sadrzaj na temelju javnoga ključa te stvara enkripcijski paket koji pridružuje
        /// svom enkripcijskom paketu.
        /// </summary>
        /// <param name="sadrzaj"></param>
        /// <param name="javniKljuc"></param>
        public void FormirajEnkripcijskiPaket(string sadrzaj, string javniKljuc)
        {
            Paket = HibridnaEnkripcija.EncryptData(sadrzaj, javniKljuc);
        }

        /// <summary>
        /// Metoda koja zapisuje poruku u bazu podataka - potreno je izvršiti 2 upita - jedan na tablici EnkriptiraniPaket, a drugi
        /// na tablici Poruka - tada je poruka usješno zapisana u bazu podataka.
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public string ZapisiPorukuUBazu(SqlConnection connection)
        {
            string rezultat = "";
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

            UspjehSlanjaPoruke uspjeh = new UspjehSlanjaPoruke("DA");
            rezultat = JsonPretvarac.Serijalizacija(uspjeh);
            return rezultat;
        }
    }
}
