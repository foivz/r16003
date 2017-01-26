using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    class HibridnaEnkripcija
    {
        private static string DecryptData(Poruka poruka,string privatniKljuc)
        {
            Enkripcija aes = new AesEnkripcija();
            Enkripcija rsa = new RsaEnkripcija();
            rsa.PridruziPrivatniKljuc(privatniKljuc);

            // Decrypt AES key with RSA and then decrypt data with AES.
            var dekriptiraniKljuc = rsa.DecryptData(poruka.Paket.EnkriptiraniKljuc);
            aes.PridruziKljucIV(Convert.FromBase64String(dekriptiraniKljuc), poruka.Paket.Iv);
            var decryptedData = aes.DecryptData(poruka.Paket.EnkriptiraniPodaci);
            return decryptedData;
        }

        private static EnkripcijskiPaket EncryptData(string poruka, string javniKljuc)
        {
            EnkripcijskiPaket novi = new EnkripcijskiPaket();
            Enkripcija aes = new AesEnkripcija();
            Enkripcija rsa = new RsaEnkripcija();
            rsa.PridruziJavniKljuc(javniKljuc);
            aes.GenerirajKljucIV();

            novi.Iv = aes.DohvatiIV();
            novi.EnkriptiraniPodaci = aes.EncryptData(poruka);
            novi.EnkriptiraniKljuc = rsa.EncryptData(Convert.ToBase64String(aes.DohvatiAESKljuc()));

            return novi;
        }
    }
}
