using System;
using System.Security.Cryptography;

namespace crypto0._1stable
{
    class EncryptionHelper
    {
        public static string CaesarStringEncrypt(string message, int key)
        {
            char[] modified = message.ToCharArray();
            if (key > 26 || key < -26)
                return "Neispravan kljuc! (-26 > kljuc > 26)";

            for (int i = 0; i < message.Length; i++)
            {
                char znak = modified[i];
                if (char.IsLower(modified[i]))
                {
                    znak = (char)(znak + key);
                    if (znak > 'z')
                        znak = (char)(znak - 26);
                    else if (znak < 'a')
                        znak = (char)(znak + 26);
                    modified[i] = znak;
                }
                if (char.IsUpper(modified[i]))
                {
                    znak = (char)(znak + key);
                    if (znak > 'Z')
                        znak = (char)(znak - 26);
                    else if (znak < 'A')
                        znak = (char)(znak + 26);
                    modified[i] = znak;
                }
            }
            return new string(modified);
        }
        public static string CaesarStringDecrypt(string cyphertext, int key)
        {
            char[] message = cyphertext.ToCharArray();
            if (key > 26 || key < -26)
                return "Neispravan kljuc! (-26 > kljuc > 26)";

            for (int i = 0; i < message.Length; i++)
            {
                char znak = message[i];
                if (char.IsLower(message[i]))
                {
                    znak = (char)(znak - key);
                    if (znak > 'z')
                        znak = (char)(znak - 26);
                    else if (znak < 'a')
                        znak = (char)(znak + 26);
                    message[i] = znak;
                }
                if (char.IsUpper(message[i]))
                {
                    znak = (char)(znak - key);
                    if (znak > 'Z')
                        znak = (char)(znak - 26);
                    else if (znak < 'A')
                        znak = (char)(znak + 26);
                    message[i] = znak;
                }
            }
            return new string(message);
        }
        public static string AesStringEncrypt(string message, byte[] key, byte[] IV)
        {
           //ne smije se proslijediti prazan string, prazan key niti prazan inicijalizacijski vektor
            byte[] encrypted;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;
            }

                return message;
            
            
        }
        public static string AesStringDecrypt(string cyphertext, int key)
        {
            throw new NotImplementedException();
        }
    }
}
