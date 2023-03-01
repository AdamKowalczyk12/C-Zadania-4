using System.Xml;
using System.Xml.Serialization;
using Zadanie3;

var ubrania = new List<Ubranie>();

using (var reader = new StreamReader(@"ubrania.csv"))
{

    string headerLine = reader.ReadLine();
    string line = String.Empty;
    while ((line = reader.ReadLine()) != null)
    {

        var values = line.Split(';');

        if(values.Contains<string>("ERR"))
        {
            continue;
        }

        ubrania.Add(new Ubranie(int.Parse(values[0]), values[1], values[2], decimal.Parse(values[3]), values[4], values[5]));
    }
}

var listA = ubrania.Where(x => x.Producent == "CIMINY");

foreach (var item in listA)
{
    Console.WriteLine(item.ToString());
}


var listB = ubrania.GroupBy(x => x.Podkategoria).Select(x => new
{
    Name = x.Key,
    Adv = String.Format("{0:0.00}", (x.Sum(x => x.Cena) / x.Count()))
}).OrderBy(x=>x.Name).ToList();


foreach (var item in listB)
{
    Console.WriteLine($"{item.Name} \t {item.Adv}");
}


var categories = ubrania.GroupBy(x => x.Kategoria).Select(x=>x.Key);


foreach (var item in categories)
{
    var list = ubrania.Where(x => x.Kategoria == item).OrderBy(x=>x.Podkategoria).ThenBy(x=>x.Producent).ToList();
    SerializeObject(list, item);
}

static void SerializeObject<T>(T source, string category)
{
    var serializer = new XmlSerializer(typeof(T));
    var path = $"{category}.xml";
    System.IO.FileStream file = System.IO.File.Create(path);

    serializer.Serialize(file, source);
    file.Close();
}



