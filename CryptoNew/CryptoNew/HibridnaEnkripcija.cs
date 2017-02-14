using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    /// <summary>
    /// Klasa koja služi za enkripciju poruka koje korisnici međusobno razmjenjuju
    /// </summary>
    public class HibridnaEnkripcija
    {
        /// <summary>
        /// Metoda koja služi za dekripciju poruke s obzirom na sam sadržaj poruke. 
        /// Za dekripciju same poruke važan je privatni ključ koji se prosljeđuje ovoj metodi te ona pomoću toga ključa 
        /// rsa algoritmom dekriptira ključ kojim je enkriptirana poruka. 
        /// Zatim se taj ključ i inicijalizacijski vektor pridružuje aes objektu koji zatim može dekriptirati sam sadržaj poruke.
        /// </summary>
        /// <param name="poruka"></param>
        /// <param name="privatniKljuc"></param>
        /// <returns></returns>
        public static string DecryptData(Poruka poruka,string privatniKljuc)
        {
            Enkripcija aes = new AesEnkripcija();
            Enkripcija rsa = new RsaEnkripcija();
            rsa.PridruziPrivatniKljuc(privatniKljuc);

            var dekriptiraniKljuc = rsa.DecryptData(poruka.Paket.EnkriptiraniKljuc);
            aes.PridruziKljucIV(Convert.FromBase64String(dekriptiraniKljuc), poruka.Paket.Iv);
            var decryptedData = aes.DecryptData(poruka.Paket.EnkriptiraniPodaci);
            return decryptedData;
        }

        /// <summary>
        /// Metoda koja služi za enkripciju poruke s obzirom na sam sadržaj poruke.
        /// Prvo se izgenerira ključ i inicijalizacijski vekor pomoću kojih se aes algoritmom enkriptira sadm sadržaj poruke.
        /// Zatim se izgenerirani ključ enkriptira pomoću rsa algoritma i to zahvaljujući javnome ključu koji se prosljeđuje
        /// samoj metodi.
        /// </summary>
        /// <param name="poruka"></param>
        /// <param name="javniKljuc"></param>
        /// <returns></returns>
        public static EnkripcijskiPaket EncryptData(string poruka, string javniKljuc)
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

        /// <summary>
        /// Metoda koja služi za enkripciju datoteke.
        /// Prvo se izgenerira ključ i inicijalizacijski vekor pomoću kojih se aes algoritmom enkriptira sadm sadržaj datoteke.
        /// Zatim se izgenerirani ključ enkriptira pomoću rsa algoritma i to zahvaljujući javnome ključu koji se prosljeđuje
        /// samoj metodi.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="javniKljuc"></param>
        /// <returns></returns>
        public static EnkripcijskiPaket EncryptFile(byte[] file, string javniKljuc)
        {
            EnkripcijskiPaket novi = new EnkripcijskiPaket();
            AesEnkripcija aes = new AesEnkripcija();
            Enkripcija rsa = new RsaEnkripcija();
            rsa.PridruziJavniKljuc(javniKljuc);
            aes.GenerirajKljucIV();

            novi.Iv = aes.DohvatiIV();
            novi.PridruziDatoteku(aes.EncryptFile(file));
            novi.EnkriptiraniKljuc = rsa.EncryptData(Convert.ToBase64String(aes.DohvatiAESKljuc()));

            return novi;
        }

        /// <summary>
        /// Metoda koja služi za dekripciju datoteke.
        /// Za dekripciju same datoteke važan je privatni ključ koji se prosljeđuje ovoj metodi te ona pomoću toga ključa 
        /// rsa algoritmom dekriptira ključ kojim je enkriptirana datoteka. 
        /// Zatim se taj ključ i inicijalizacijski vektor pridružuje aes objektu koji zatim može dekriptirati sam sadržaj datoteke.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="kljuc"></param>
        /// <param name="iv"></param>
        /// <param name="privatniKljuc"></param>
        /// <returns></returns>
        public static byte[] DecryptFile(byte[] file, string kljuc, byte[] iv, string privatniKljuc)
        {
            AesEnkripcija aes = new AesEnkripcija();
            Enkripcija rsa = new RsaEnkripcija();
            rsa.PridruziPrivatniKljuc(privatniKljuc);

            var dekriptiraniKljuc = rsa.DecryptData(kljuc);
            aes.PridruziKljucIV(Convert.FromBase64String(dekriptiraniKljuc), iv);
            var decryptedData = aes.DecryptFile(file);
            return decryptedData;
        }
    }
}
