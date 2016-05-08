using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypto0._1stable
{
    class TekstPoruka : Poruka
    {
        private string tekst;
        private string posiljatelj;
        private string primatelj;

        public TekstPoruka()
        {
            Korisnik k = new Korisnik(); //ovo je vjerojatno suvisno
           
        }

        public override Poruka Decrypt(int decryptionMethod, int key)
        {
            if (decryptionMethod == 1)
            {
                tekst = EncryptionHelper.CaesarStringDecrypt(tekst, key);
                    return this;
            }
            else return this;
        }

        public override Poruka Ecrypt(int encryptionMethod, int key)
        {
            if (encryptionMethod == 1)
            {
                tekst = EncryptionHelper.CaesarStringEncrypt(tekst, key);
                return this;
            }
            else return this;
        }

        public override Poruka Recieve(Korisnik sender)
        {
            throw new NotImplementedException();
        }

        public override Poruka Send(Korisnik reciever)
        {
            throw new NotImplementedException();
        }
    }
}
