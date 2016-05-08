using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

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
        public static byte[] AesStringEncrypt(string message, byte[] key, byte[] IV)
        {
            //ne smije se proslijediti prazan string, prazan key niti prazan inicijalizacijski vektor
            byte[] encrypted;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(message);
                        }
                        encrypted = ms.ToArray();
                    }
                }
            }
            return encrypted;
            //string result = System.Text.Encoding.UTF8.GetString(encrypted);
        }
        public static string AesStringDecrypt(byte[] cyphertext, byte[] key, byte[] IV)
        {
            string plaintext;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream ms = new MemoryStream(cyphertext))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            plaintext = sr.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }
        public static string GenerateDESKey()                //desCrypto.IV također pospremiti negdje
        {
            DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
            return Encoding.ASCII.GetString(desCrypto.Key);
        }
        public static void EncryptFileDES(string inputFilename, string outputFilename, string key)
        {
            FileStream fsInput = new FileStream(inputFilename,
               FileMode.Open,
               FileAccess.Read);

            FileStream fsEncrypted = new FileStream(outputFilename,
               FileMode.Create,
               FileAccess.Write);
            using (DESCryptoServiceProvider DES = new DESCryptoServiceProvider())
            {
                DES.Key = Encoding.ASCII.GetBytes(key);
                DES.IV = Encoding.ASCII.GetBytes(key);
                ICryptoTransform desencrypt = DES.CreateEncryptor();
                using (CryptoStream cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write))
                {

                    byte[] bytearrayinput = new byte[fsInput.Length];
                    fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
                    cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
                    cryptostream.Close();
                    fsInput.Close();
                    fsEncrypted.Close();
                }
            }
        } //Isti key i IV omogućavaju bruteforce dictionary, popraviti!
        public static void DecryptFileDES(string inputFilename, string outputFilename, string key)  //Isti key i IV omogućavaju bruteforce dictionary, popraviti!
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            // 64 bitni key i IV 
            DES.Key = Encoding.ASCII.GetBytes(key);
            DES.IV = Encoding.ASCII.GetBytes(key);

            FileStream fsread = new FileStream(inputFilename,
               FileMode.Open,
               FileAccess.Read);
            ICryptoTransform desDecrypt = DES.CreateDecryptor();
            using (CryptoStream cryptostreamDecr = new CryptoStream(fsread, desDecrypt, CryptoStreamMode.Read))
            {
                StreamWriter fsDecrypted = new StreamWriter(outputFilename);
                fsDecrypted.Write(new StreamReader(cryptostreamDecr).ReadToEnd());
                fsDecrypted.Flush();
                fsDecrypted.Close();
            }
        }
        public static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }   //big endian/little endian problem?
        public static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
        public static string Base64StringEncrypt() { throw new NotImplementedException(); }
        public static string Base64StringDecrypt() { throw new NotImplementedException(); }
        public static void EncryptFileAes() { new NotImplementedException(); }
        public static void DecryptFileAes() { throw new NotImplementedException(); }

    }
}
