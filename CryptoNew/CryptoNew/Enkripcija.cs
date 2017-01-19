using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    public abstract class Enkripcija
    {
        protected string publicKey;
        protected string privateKey;
        public virtual byte[] GenerirajRandomBroj(int length)
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[length];
                randomNumberGenerator.GetBytes(randomNumber);
                return randomNumber;
            }
        }

        public virtual void AssignRsaKeys()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                publicKey = rsa.ToXmlString(false);
                privateKey = rsa.ToXmlString(true);
            }
        }

        public virtual string DohvatiJavniKljuc()
        {
            return publicKey;
        }

        public virtual void PridruziJavniKljuc(string javni)
        {
            publicKey = javni;
        }

        public virtual void PridruziPrivatniKljuc(string privatni)
        {
            privateKey = privatni;
        }

        public virtual string PrikazEnkriptiranihPodataka(byte[] podaci)
        {
            string result = Convert.ToBase64String(podaci);
            return result;
        }

        public abstract byte[] EncryptData(byte[] dataToEncrypt);
        public abstract string DecryptData(byte[] dataToEncrypt);
    }
}
