using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;
namespace ConsoleApplication39
{
    [XmlInclude(typeof(Pracownik))]
    [XmlRoot("KolekcjaOsob")]
    public class OsobaKontener
    {
         [XmlArray("Osoby"), XmlArrayItem("Osoba")]
        public List<Osoba> osoby { get; set; }
         public void Zapisz(string sciezka)
         {
             var serializer = new XmlSerializer(typeof(OsobaKontener));

             using (var strumien = new FileStream(sciezka, FileMode.Create))
             {
                 serializer.Serialize(strumien, this);
             }
         }

         public static OsobaKontener Wczytaj(string sciezka)
         {
             var serializer = new XmlSerializer(typeof(OsobaKontener));

             using (var strumien = new FileStream(sciezka, FileMode.Open))
             {
                 return serializer.Deserialize(strumien) as OsobaKontener;
             }
         }
    }
}
