using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    public class RsaEnkripcija : Enkripcija
    {
        /// <summary>
        /// Enkriptiranje podataka RSA metodom, ulaz je originalni tekst u byte[] formatu
        /// </summary>
        /// <param name="dataToEncrypt"></param>
        /// <returns></returns>
        public override string EncryptData(string dataToEncrypt)
        {
            var data = Encoding.UTF8.GetBytes(dataToEncrypt);
            byte[] cipherbytes;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(publicKey);
                cipherbytes = rsa.Encrypt(data, false);
            }
            return Convert.ToBase64String(cipherbytes);
        }

        /// <summary>
        /// Dekriptiranje podataka RSA metodom, ulaz su enkriptirani podaci u byte[] formatu
        /// </summary>
        /// <param name="dataToEncrypt"></param>
        /// <returns></returns>
        public override string DecryptData(string data)
        {
            byte[] dataToEncrypt = Convert.FromBase64String(data);
            string result;
            byte[] plain;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(privateKey);
                plain = rsa.Decrypt(dataToEncrypt, false);
            }
            result = Encoding.UTF8.GetString(plain);
            return result;
        }
    }
}
