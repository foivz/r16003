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

        abstract public Poruka Ecrypt(int encryptionMethod, int key);
        abstract public Poruka Decrypt(int decryptionMethod, int key);
        abstract public Poruka Send(Korisnik reciever);
        abstract public Poruka Recieve(Korisnik sender);
    }
}
