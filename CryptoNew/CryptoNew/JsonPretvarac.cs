using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CryptoNew
{
    /// <summary>
    /// Klasa čija je osnovna namjena serijalizacija objekata u json objekt te deserijalizacija json objekta u objekt pripadajuće
    /// klase
    /// </summary>
    public static class JsonPretvarac
    {
        public static List<string> InvalidJsonElements;

        /// <summary>
        /// Serijalizacija objekta u pripadajući json string
        /// </summary>
        /// <param name="objekt"></param>
        /// <param name="tipPoruke"></param>
        /// <returns></returns>
        public static string Serijalizacija(object objekt, string tipPoruke = "null")
        {
            JObject temp = JObject.FromObject(objekt);
            if (tipPoruke != "null")
            {
                //DODATNI ATRRIBUT TIP PORUKE KOJI OZNAČAVA ZBOG ČEGA SE ŠALJE JSON SA PODACIMA (NPR. REGISTRACIJA, PRIJAVA...)
                temp.Add("tipPoruke", tipPoruke);
            }
            string json = JsonConvert.SerializeObject(temp, Formatting.Indented);
            return json;
        }

        public static string SerijalizacijaListe<T>(List<T> objekti)
        {
            string json = JsonConvert.SerializeObject(objekti, Formatting.Indented);
            return json;
        }

        /// <summary>
        /// Deserijalizacija json stringa u pripadajući objekt klase
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static object Deserijalizacija(string json)
        {
            object izlaz = 0;
            string noviJson = IzbaciTipPoruke(json);
            string tipKlase = Parsiranje(noviJson, "Tip");
            if (tipKlase == "Korisnik")
            {
                Korisnik osoba = JsonConvert.DeserializeObject<Korisnik>(noviJson);
                izlaz = osoba;
            }
            if (tipKlase == "UspjehRegistracije")
            {
                UspjehRegistracije uspjeh = JsonConvert.DeserializeObject<UspjehRegistracije>(noviJson);
                izlaz = uspjeh;
            }
            if (tipKlase == "ListaKorisnika")
            {
                ListaKorisnika lista = JsonConvert.DeserializeObject<ListaKorisnika>(noviJson);
                izlaz = lista;
            }
            if (tipKlase == "Poruka")
            {
                Poruka poruka = JsonConvert.DeserializeObject<Poruka>(noviJson);
                izlaz = poruka;
            }
            if (tipKlase == "UspjehSlanjaPoruke")
            {
                UspjehSlanjaPoruke uspjeh = JsonConvert.DeserializeObject<UspjehSlanjaPoruke>(noviJson);
                izlaz = uspjeh;
            }
            if (tipKlase == "ListaPoruka")
            {
                ListaPoruka poruke = JsonConvert.DeserializeObject<ListaPoruka>(noviJson);
                izlaz = poruke;
            }
            return izlaz;
        }

        public static T UniqueDeserijalizacija<T>(string json)
        {
            T izlaz;
            string noviJson = IzbaciTipPoruke(json);
            izlaz = JsonConvert.DeserializeObject<T>(noviJson);
            return izlaz;
        }

        public static IList<T> DeserijalizacijaToLista<T>(string jsonString)
        {
            InvalidJsonElements = null;
            var array = JArray.Parse(jsonString);
            IList<T> objectsList = new List<T>();

            foreach (var item in array)
            {
                try
                {
                    // CorrectElements
                    objectsList.Add(item.ToObject<T>());
                }
                catch (Exception ex)
                {
                    InvalidJsonElements = InvalidJsonElements ?? new List<string>();
                    InvalidJsonElements.Add(item.ToString());
                }
            }

            return objectsList;
        }

        /// <summary>
        /// Pretraga jsona s obzirom na kljuc pretrage i vraćanje vrijednosti toga atributa, 
        /// npr. postoji atribut u json datoteci sa nazivom 'Tip' te ako je to kljuc pretrage
        /// vratiti ce se vrijednost atributa 'Tip'
        /// </summary>
        /// <param name="json"></param>
        /// <param name="kljuc"></param>
        /// <returns></returns>
        public static string Parsiranje(string json, string kljuc)
        {
            string izlaz = null;
            if (!json.StartsWith("\0"))
            {
                JObject o = JObject.Parse(json);
                izlaz = (string)o[kljuc];
            }
            return izlaz;
        }

        /// <summary>
        /// Izbacuje tip poruke iz jsona, tj. razlog slanja prema serveru kako bi se json string mogao uspjesno deserijalizirati
        /// u pripadajuci objekt neke klase
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static string IzbaciTipPoruke(string json)
        {
            if (Parsiranje(json,"tipPoruke") != null)
            {
                var o = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(json);
                o.Property("tipPoruke").Remove();
                return o.ToString();
            }
            else
            {
                return json;
            }
        }

        public static string DodajAtribut(object item, string naziv, string vrijednost="null")
        {
            JObject jo = JObject.FromObject(item);
            jo.Add(naziv, vrijednost);
            string json = jo.ToString();
            return json;
        }

    }
}
