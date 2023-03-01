


using Zadanie1;

var cities = new List<Miasto>()
{
    new Miasto { Name = "Chorzów", Area = 33.50, PeopleCount = 108434 },
    new Miasto { Name = "Tychy", Area = 81.81, PeopleCount = 128211 },
    new Miasto { Name = "Katowice", Area = 164.64, PeopleCount = 294510 },
    new Miasto { Name = "Bytom", Area = 69.44, PeopleCount = 166795 },
    new Miasto { Name = "Gliwice", Area = 133.88, PeopleCount = 181309 },
};



var result = cities.Select(x => new
{
    Name = x.Name,
    Density = String.Format("{0:0.00}", (x.PeopleCount / x.Area))
}).OrderByDescending(x=>x.Density);


foreach (var item in result)
{
    Console.WriteLine($"{item.Name} {item.Density}");
}
