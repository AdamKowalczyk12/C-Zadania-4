using System.Xml.Serialization;
using Zadanie5;


WriteXML();
ReadXML();

static void WriteXML()
{
    Rachunek overview = new Rachunek();

    overview.Numer = "101/2022";
    overview.Data = DateTime.Now;

    overview.listaTowarow = new List<Towar>();

    overview.listaTowarow.Add(new Towar() { Cena = "3.2", Ilosc = 10, Nazwa = "Ołówek"});
    overview.listaTowarow.Add(new Towar() { Cena = "1.2", Ilosc = 20, Nazwa = "Długopis"});
    overview.listaTowarow.Add(new Towar() { Cena = "10.2", Ilosc = 30, Nazwa = "Szynka"});

    XmlSerializer writer =
        new XmlSerializer(typeof(Rachunek));


    FileStream file = File.Create("SerializationOverview.xml");

    writer.Serialize(file, overview);
    file.Close();
}


static void ReadXML()
{

    using (var reader = new StreamReader("SerializationOverview.xml"))
    {
        XmlSerializer deserializer = new XmlSerializer(typeof(Rachunek));

        object? obj = deserializer.Deserialize(reader);

        if (obj == null)
            Console.WriteLine("Błąd");

        var xmldata = (Rachunek)obj;


        Console.WriteLine($"Numer: {xmldata.Numer}");
        Console.WriteLine($"Data: {xmldata.Data}");

        foreach (var item in xmldata.listaTowarow)
        {
            Console.WriteLine($"Nazwa: {item.Nazwa} Cena: {item.Cena} Ilość: {item.Ilosc}");
        }


        reader.Close();
    }

}
