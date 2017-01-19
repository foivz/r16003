using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CryptoNew
{
    public static class JsonPretvarac
    {
        public static List<string> InvalidJsonElements;

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
            /*
            JObject temp = JObject.FromObject(objekti);
            if (tipPoruke != "null")
            {
                //DODATNI ATRRIBUT TIP PORUKE KOJI OZNAČAVA ZBOG ČEGA SE ŠALJE JSON SA PODACIMA (NPR. REGISTRACIJA, PRIJAVA...)
                temp.Add("tipPoruke", tipPoruke);
            }
            */
            string json = JsonConvert.SerializeObject(objekti, Formatting.Indented);
            return json;
        }

        public static object Deserijalizacija(string json)
        {
            object izlaz = 0;
            string noviJson = IzbaciTipPoruke(json);
            if (Parsiranje(noviJson,"Tip") == "Korisnik")
            {
                Korisnik osoba = JsonConvert.DeserializeObject<Korisnik>(noviJson);
                izlaz = osoba;
            }
            if (Parsiranje(noviJson, "Tip") == "UspjehRegistracije")
            {
                UspjehRegistracije uspjeh = JsonConvert.DeserializeObject<UspjehRegistracije>(noviJson);
                izlaz = uspjeh;
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

        public static string IzbaciTipPoruke(string json)
        {
            /*
            var jArr = JArray.Parse(json);

            jArr.Descendants().OfType<JProperty>()
                              .Where(p => p.Name == "tipPoruke")
                              .ToList()
                              .ForEach(att => att.Remove());

            var newJson = jArr.ToString();
            return newJson;
            */

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


    }
}
