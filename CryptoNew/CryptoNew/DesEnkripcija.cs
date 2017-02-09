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
    /// Klasa koja sadrži metode za enkripciju i dekriptiranje sadržaja pomoću DES algoritma
    /// </summary>
    public class DesEnkripcija : Enkripcija
    {
        /// <summary>
        /// Metoda koja enkriptira sadržaj na temelju ključa i inicijalizacijskoga vekrota
        /// </summary>
        /// <param name="dataToEncrypt"></param>
        /// <returns></returns>
        public override string EncryptData(string dataToEncrypt)
        {
            var data = Encoding.UTF8.GetBytes(dataToEncrypt);
            using (var des = new DESCryptoServiceProvider())
            {
                des.Mode = CipherMode.CBC;
                des.Padding = PaddingMode.PKCS7;
                des.Key = key;
                des.IV = IV;
                using (var memoryStream = new MemoryStream())
                {
                    var cryptoStream = new CryptoStream(memoryStream,
                    des.CreateEncryptor(), CryptoStreamMode.Write);
                    cryptoStream.Write(data, 0, data.Length);
                    cryptoStream.FlushFinalBlock();
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
        }

        /// <summary>
        /// Metoda koja dekriptira sadržaj na temelju ključa i inicijalizacijskoga vekrota
        /// </summary>
        /// <param name="dataToDecrypt"></param>
        /// <returns></returns>
        public override string DecryptData(string dataToDecrypt)
        {
            string result;
            var data = Convert.FromBase64String(dataToDecrypt);
            using (var des = new DESCryptoServiceProvider())
            {
                des.Mode = CipherMode.CBC;
                des.Padding = PaddingMode.PKCS7;
                des.Key = key;
                des.IV = IV;
                using (var memoryStream = new MemoryStream())
                {
                    var cryptoStream = new CryptoStream(memoryStream,
                    des.CreateDecryptor(), CryptoStreamMode.Write);
                    cryptoStream.Write(data, 0, data.Length);
                    cryptoStream.FlushFinalBlock();
                    var decryptBytes = memoryStream.ToArray();
                    result = Encoding.UTF8.GetString(decryptBytes);
                    return result;
                }
            }
        }

        public override void GenerirajKljucIV()
        {
            key = GenerirajRandomBroj(8);
            IV = GenerirajRandomBroj(8);
        }
    }
}
