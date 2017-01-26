using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    public class DesEnkripcija : Enkripcija
    {
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
    }
}
