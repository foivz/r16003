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
            Korisnik k = new Korisnik();
           
        }

        public override Poruka Decrypt()
        {
            throw new NotImplementedException();
        }

        public override Poruka Ecrypt()
        {
            throw new NotImplementedException();
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
