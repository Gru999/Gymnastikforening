using Gymnastikforening;
using System.Linq.Expressions;

//Opgave 1
Console.WriteLine("Opgave 1");
Hold h1 = new Hold("001", "BørneHold1", 150.0, 7);
Hold h2 = new Hold("002", "BørneHold2", 175.0, 20);
Hold h3 = new Hold("003", "BørneHold3", 200.0, 25);

//Til test af exception
Hold h4 = new Hold("003", "BørneHold4", 225.0, 30);

Console.WriteLine(h1.ToString());
Console.WriteLine(h2.ToString());
Console.WriteLine(h3.ToString());

Console.WriteLine("\n");

//Opgave 2 
Console.WriteLine("Opgave 2");
HoldKatalog Katalog = new HoldKatalog();
try
{
    Katalog.TilføjHold(h1);
    Katalog.TilføjHold(h2);
    Katalog.TilføjHold(h3);
    Katalog.TilføjHold(h4);
}
catch (ArgumentException)
{
    Console.WriteLine("Ikke mulig at tilføje et hold der allerede findes");
}

Console.WriteLine(Katalog.ToString());

//Opgae 3
//Se Tilføj metode ovenfor
Console.WriteLine("Opgave 3");
Console.WriteLine(Katalog.FindHold("002"));

Console.WriteLine("\n");

//Opgave 4 
Console.WriteLine("Opgave 4");
Deltager d1 = new Deltager("Alice", "By Vej 1", 1);
Deltager d2 = new Deltager("Bob", "Land Vej 2", 2);
Deltager d3 = new Deltager("Charlie", "Strand Vej 3", 3);
Deltager d4 = new Deltager("Daisy", "Vej By 4", 4);

Console.WriteLine(d1.ToString());
Console.WriteLine(d2.ToString());
Console.WriteLine(d3.ToString());
Console.WriteLine("\n");

//Opgave 5
Console.WriteLine("Opgave 5");
Console.WriteLine("Antal på hold 1: " + h1.AntalTilmeldte());
h1.TilmeldDeltager(d1);
h1.TilmeldDeltager(d2);
h1.TilmeldDeltager(d3);
Console.WriteLine("Antal på hold 1: " + h1.AntalTilmeldte());

h2.TilmeldDeltager(d3);

//for mange ledige pladser
h1.TilmeldDeltager(d4);

Console.WriteLine("\n");

//Opgave 7 
//Implementering af Exception handling - Kan ses ved Opgave 2

//Opgave 8
Console.WriteLine("Opgave 8");
Hold s1 = new SvømmeHold("Slagelse Svømmehal", "005", "Frø Holdet", 185.0, 10);
Hold s2 = new SvømmeHold("Roskilde Svømmehal", "006", "Haj Holdet", 185.0, 15);
Hold s3 = new SvømmeHold("Aarhus Svømmehal", "007", "Pingvin Holdet", 185.0, 12);

Console.WriteLine(s1.ToString());
Console.WriteLine(s2.ToString());
Console.WriteLine(s3.ToString());

Console.WriteLine("\n");

//Opgave 10
Console.WriteLine("Opgave 10");
Console.WriteLine(h2.BeregnTotalPris(3));

Console.WriteLine("\n");

//Opgave 12 
Console.WriteLine("Opgave 12");
Console.WriteLine(Katalog.FindHold("003"));


