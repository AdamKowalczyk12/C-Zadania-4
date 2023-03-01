using Zadanie2;

var cities = new List<Miasto>()
{
    new Miasto { Name = "Chorzów", Area = 33.50, PeopleCount = 108434, State = "Śląskie" },
    new Miasto { Name = "Tychy", Area = 81.81, PeopleCount = 128211, State = "Śląskie" },
    new Miasto { Name = "Katowice", Area = 164.64, PeopleCount = 294510, State = "Śląskie" },
    new Miasto { Name = "Bytom", Area = 69.44, PeopleCount = 166795, State = "Śląskie" },
    new Miasto { Name = "Gliwice", Area = 133.88, PeopleCount = 181309, State = "Śląskie" },
    new Miasto { Name = "Radom", Area = 111.80, PeopleCount = 213910, State = "Mazowieckie" },
    new Miasto { Name = "Płock", Area = 88.06, PeopleCount = 120787, State = "Mazowieckie" },
};



foreach (var item in cities)
{
    Console.WriteLine($"{item.Name} {item.Area} {item.PeopleCount} {item.State}");
}


Console.WriteLine("Wynik zapytania");



var result = cities.GroupBy(x=> x.State).Select(x=> new
{
    Name = x.Key,
    Density = String.Format("{0:0.00}", x.Sum(s=>s.PeopleCount) / x.Sum(s=>s.Area))
}).ToList();


foreach (var item in result)
{
    Console.WriteLine($"{item.Name} {item.Density}");
}