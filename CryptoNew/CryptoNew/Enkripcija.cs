﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    /// <summary>
    /// Osnova klasa za enkkripcijske objekte
    /// </summary>
    public abstract class Enkripcija
    {
        protected string publicKey;
        protected string privateKey;
        protected byte[] key;
        protected byte[] IV;
        /// <summary>
        /// Generira se nasumični broj koji je jedinstven (važno u generiranju inicjalizacijskih vektora i ključeva enkripcije)
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public virtual byte[] GenerirajRandomBroj(int length)
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[length];
                randomNumberGenerator.GetBytes(randomNumber);
                return randomNumber;
            }
        }

        /// <summary>
        /// Generiranje javnoga i privatnoga ključa za rsa enkripciju
        /// </summary>
        public virtual void AssignRsaKeys()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                publicKey = rsa.ToXmlString(false);
                privateKey = rsa.ToXmlString(true);
            }
        }

        /// <summary>
        /// Dohvaća se javni ključ enkripcijskoga objekta
        /// </summary>
        /// <returns></returns>
        public virtual string DohvatiJavniKljuc()
        {
            return publicKey;
        }

        /// <summary>
        /// Dohvaća se privatni ključ enkripcijskoga objekta
        /// </summary>
        /// <returns></returns>
        public virtual string DohvatiPrivatniKljuc()
        {
            return privateKey;
        }

        /// <summary>
        /// Dohvaćanje AES,DES,TRIPLE DES Ključa
        /// </summary>
        /// <returns></returns>
        public virtual byte[] DohvatiAESKljuc()
        {
            return key;
        }

        /// <summary>
        /// Dohvaćanje inicijalizacijskoga vektora
        /// </summary>
        /// <returns></returns>
        public virtual byte[] DohvatiIV()
        {
            return IV;
        }

        /// <summary>
        /// Pridružuje se javni ključ enkripcijskom objektu kako bi se poruka mogla enkriptirati RSA metodom
        /// </summary>
        /// <param name="javni"></param>
        public virtual void PridruziJavniKljuc(string javni)
        {
            publicKey = javni;
        }

        /// <summary>
        /// Pridružuje se privatni ključ enkripcijskom objektu kako bi se poruka mogla dekriptirati RSA metodom
        /// </summary>
        /// <param name="privatni"></param>
        public virtual void PridruziPrivatniKljuc(string privatni)
        {
            privateKey = privatni;
        }

        /// <summary>
        /// Pridružuje se ključ i inicijalizacijski vektor enkripcijskom objektu kako bi se poruka mogla dekriptirati aes, des
        /// ili triple des metodom
        /// </summary>
        /// <param name="kljuc"></param>
        /// <param name="iv"></param>
        public virtual void PridruziKljucIV(byte[] kljuc, byte[] iv)
        {
            key = kljuc;
            IV = iv;
        }

        /// <summary>
        /// Prikaz enkriptiranih podataka u string obliku umjesto u byte[] obliku
        /// </summary>
        /// <param name="podaci"></param>
        /// <returns></returns>
        public virtual string PrikazEnkriptiranihPodataka(byte[] podaci)
        {
            string result = Convert.ToBase64String(podaci);
            return result;
        }

        /// <summary>
        /// Generiranje aes ključa i inicijalizacijskoga vektora za potrebe aes enkripcije
        /// </summary>
        public virtual void GenerirajKljucIV()
        {
            key = GenerirajRandomBroj(32);
            IV = GenerirajRandomBroj(16);
        }

        public abstract string EncryptData(string dataToEncrypt);
        public abstract string DecryptData(string dataToEncrypt);
    }
}
