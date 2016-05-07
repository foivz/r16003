using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypto0._1stable
{
    class DatotekaPoruka : Poruka
    {
        private byte[] datoteka;
        private Korisnik posiljatelj;
        private Korisnik primatelj;

        public override Poruka Ecrypt(int encryptionMethod, int key)
        {
            throw new NotImplementedException();
        }

        public override Poruka Decrypt(int decryptionMethod, int key)
        {
            throw new NotImplementedException();
        }

        public override Poruka Send(Korisnik reciever)
        {
            throw new NotImplementedException();
        }

        public override Poruka Recieve(Korisnik sender)
        {
            throw new NotImplementedException();
        }
    }

}
