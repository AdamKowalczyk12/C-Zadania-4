using System.Text;
using Zadanie3;

var streamType = typeof(Stream);
var methods = streamType.GetMethods();
string path = "raport.csv";
var csv = new StringBuilder();


foreach (var method in methods)
{

    var parms = method.GetParameters();
    var resultParams = string.Empty;

    if(parms.Length > 0)
    {
        for (int i = 0; i < parms.Length; i++)
        {
            resultParams += $"{parms[i].ParameterType.Name} {parms[i].Name}";

            if(i != parms.Length - 1)
            {
                resultParams += ",";
            }
        }
    }

    var metoda = new Metoda(method.Name, method.IsAbstract, method.IsVirtual, method.ReturnType.Name, resultParams);

    csv.AppendLine(metoda.ToString(false));
}

File.WriteAllText(path, csv.ToString());

var result = new List<Metoda>();

using (var reader = new StreamReader(path))
{
    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine();
        var values = line.Split(';');

        result.Add(new Metoda(values[0], bool.Parse(values[1]), bool.Parse(values[2]), values[3], values[4]));
    }
}


result = result.OrderBy(x => x.Name).OrderBy(x => x._paramsCount).ToList();


foreach (var item in result)
{
    Console.WriteLine(item.ToString(true));
}