using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;

namespace CryptoNew
{
    /// <summary>
    /// Klasa koja služi za rad sa 2fa objektima
    /// </summary>
    class Verficiranje2FA
    {
        private string kljuc2FA;
        private string AccountSid = "AC560f46283cfd1ed32e476c5cea044481";
        private string AuthToken = "2719101200e6888c75c435b9eff031c6";
        private string from = "+49 1573 5990396";

        /// <summary>
        /// Metoda koja generira 2fa kod - četveroznamenkasti kod i vraća ga u string formatu
        /// </summary>
        /// <returns></returns>
        public string GenerirajKljuc2FA()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string rjesenje = new string(Enumerable.Repeat(chars, 4).Select(s => s[random.Next(s.Length)]).ToArray());
            kljuc2FA = rjesenje;
            return rjesenje;
        }

        /// <summary>
        /// Ova metoda se ne koristi u aplikaciji zbog toga što se ne koristi premium twilio račun
        /// </summary>
        /// <param name="brojMobitela"></param>
        public void DodajBrojNaTwilio(string brojMobitela)
        {
            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            var result = twilio.AddOutgoingCallerId(brojMobitela, "Mobitel", null, null);
            if (result.RestException != null)
            {
                Console.WriteLine(result.RestException.Message);
            }
        }

        /// <summary>
        /// Metoda koja šalje 2fa kod na temelju broja mobitela korisnika
        /// </summary>
        /// <param name="brojMobitela"></param>
        public void PosaljiPorukuNaMobilni(string brojMobitela)
        {
            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            var message = twilio.SendMessage(
                from, brojMobitela,
                "Crypto Kod: " + kljuc2FA
            );
        }
    }
}
