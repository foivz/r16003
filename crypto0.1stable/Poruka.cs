using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypto0._1stable
{
    abstract class Poruka
    {
        private long size = 0;
        private bool porukaProcitana = false;

        abstract public Poruka Ecrypt();
        abstract public Poruka Decrypt();
        abstract public Poruka Send(Korisnik reciever);
        abstract public Poruka Recieve(Korisnik sender);
    }
}
