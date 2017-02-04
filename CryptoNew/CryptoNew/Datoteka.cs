using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    /// <summary>
    /// Entitetska klasa koja sarži osnovne podatke o datoteci (posiljatelja, ime, datum kad je datoteka poslana
    /// i velicinu same datoteke)
    /// </summary>
    class Datoteka
    {
        [DisplayName("Pošiljatelj")]
        public string Posiljatelj { get; set; }

        [DisplayName("Ime Datoteke")]
        public string ImeDatoteke { get; set; }

        [DisplayName("Datum")]
        public DateTime Datum { get; set; }

        [DisplayName("Veličina Datoteke")]
        public string Velicina { get; set; }

        public void IzracunajVelicinu(ulong len)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            double velicina = len;
            while (velicina >= 1024 && order < sizes.Length - 1)
            {
                order++;
                velicina = velicina / 1024;
            }
            Velicina = String.Format("{0:0.##} {1}", velicina, sizes[order]);
        }
    }
}
