using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPserver
{
    class ObradaPoruke
    {
        private byte[] bytePoruka;
        private string pomocnaPoruka;
        private string[] poruke = {"LOGIN","REGISTER", "C2C", "PRUPDATE", "DOHVATIKLIJENTE", "CITANJEPORUKE","OTKZAK", "UPDOTKLJUCAJ" };
        bool izadiIzPetlje;

        private string[] elementiPoruke;
        public ObradaPoruke(byte[] primljenaPoruka)
        {
            bytePoruka = primljenaPoruka;
        }
        

        //metoda koja prepoznaje da se radi o login poruci. Prije ove metode (i ostalih metoda takve prirode) treba dekriptirati poruku koju je korisnik kriptirao.
        
        public List<string> PrepoznavanjePoruke()
        {
            List<string> result = new List<string>();
            elementiPoruke = Encoding.ASCII.GetString(bytePoruka).Split(',');
            try
            {
                izadiIzPetlje = false;
                foreach (var item in poruke)
                {
                    if (elementiPoruke[0].Contains(item))
                    {
                        pomocnaPoruka = item;
                        break;
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Na prepoznajem poruku");
            }

            UpitZaBazu upit = new UpitZaBazu(pomocnaPoruka, elementiPoruke);
            result = upit.dohvatiElementeIzPoruke();
            return result;
        }
    }
}
