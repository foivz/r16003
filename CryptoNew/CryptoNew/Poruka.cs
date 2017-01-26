using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{

    public class EnkripcijskiPaket
    {
        public byte[] EnkriptiraniKljuc;
        public byte[] EnkriptiraniPodaci;
        public byte[] Iv;
    }
    public class Poruka
    {
        public string Posiljatelj { get; set; }
        public string Primatelj { get; set; }
        public DateTime DatumSlanja { get; set; }
        public EnkripcijskiPaket Paket { get; set; }

        Poruka(EnkripcijskiPaket paket)
        {
            Paket = new EnkripcijskiPaket();
            Paket = paket;
        }
    }
}
