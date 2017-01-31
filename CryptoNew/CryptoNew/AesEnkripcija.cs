using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    /// <summary>
    /// Klasa koja sadrži metode za enkripciju i dekriptiranje sadržaja pomoću AES algoritma
    /// </summary>
    public class AesEnkripcija : Enkripcija
    {
        /// <summary>
        /// Metoda koja enkriptira sadržaj na temelju ključa i inicijalizacijskoga vekrota
        /// </summary>
        /// <param name="dataToEncrypt"></param>
        /// <returns></returns>
        public override string EncryptData(string dataToEncrypt)
        {
            var data = Encoding.UTF8.GetBytes(dataToEncrypt);
            using (var aes = new AesCryptoServiceProvider())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = key;
                aes.IV = IV;
                using (var memoryStream = new MemoryStream())
                {
                    var cryptoStream = new CryptoStream(memoryStream,
                    aes.CreateEncryptor(), CryptoStreamMode.Write);
                    cryptoStream.Write(data, 0, data.Length);
                    cryptoStream.FlushFinalBlock();
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
        }

        /// <summary>
        /// Metoda koja dekriptira sadržaj na temelju ključa i inicijalizacijskoga vekrota
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public override string DecryptData(string data)
        {
            string result;
            byte[] dataToDecrypt = Convert.FromBase64String(data);
            using (var aes = new AesCryptoServiceProvider())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = key;
                aes.IV = IV;
                using (var memoryStream = new MemoryStream())
                {
                    var cryptoStream = new CryptoStream(memoryStream,
                    aes.CreateDecryptor(), CryptoStreamMode.Write);
                    cryptoStream.Write(dataToDecrypt, 0, dataToDecrypt.Length);
                    cryptoStream.FlushFinalBlock();
                    var decryptBytes = memoryStream.ToArray();
                    result = Encoding.UTF8.GetString(decryptBytes);
                    return result;
                }
            }
        }
    }
}
