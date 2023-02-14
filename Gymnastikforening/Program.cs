// See https://aka.ms/new-console-template for more information

using GymnastikForening;
//using Microsoft.VisualBasic;

Hold h1 = new Hold("Tumle22t", 2022, "Tumlinger", 500, 50);
Hold h2 = new Hold("Tumle23t", 2022, "Rollinger", 700, 15);
//Console.WriteLine(h1);
//Console.WriteLine(h2);


HoldKatalog holdKatalog = new HoldKatalog();
try
{
    holdKatalog.TilføjHold(h1);
    holdKatalog.TilføjHold(h2);
}

catch (ArgumentException aex)
{
    Console.WriteLine("Fejl ved tilføjelse af hold");
}
catch (Exception ex)
{
    Console.WriteLine("Der skete en generel fejl!");
}


Console.WriteLine(holdKatalog); //udskriving vha. ToString metode


Deltager d1 = new Deltager("Poul Henriksen", "Vej 123", 20);
Deltager d2 = new Deltager("Charlotte Heegaard", "Gade 321", 15);
Deltager d3 = new Deltager("Poul Henriksen", "Vej 123", 5);
Deltager d4 = new Deltager("Charlotte Heegaard", "Gade 321", 5);
Deltager d5 = new Deltager("Poul Henriksen", "Vej 123", 3);
Deltager d6 = new Deltager("Charlotte Heegaard", "Gade 321", 2);
try
{
    h1.TilmeldDeltager(d1);
    h1.TilmeldDeltager(d2);
}
catch (FuldtHoldException fex)
{
    Console.WriteLine(fex.Message);
}
catch (ArgumentException aex) 
{
    Console.WriteLine("Du kan ikke tilføje et antal børn mindre end et");
}

h2.TilmeldDeltager(d3);
h2.TilmeldDeltager(d4);
h2.TilmeldDeltager(d5);
h2.TilmeldDeltager(d6);

Ansat a1 = new Ansat("John", "321 Vej", "12345678", "træner");
Ansat a2 = new Ansat("Bob", "123 Vej", "87654321", "leder");
Console.WriteLine(a1.ToString());
Console.WriteLine(a2.ToString());

Console.WriteLine("\n");

Underviser u1 = new Underviser("træner", true, "Charlie", "123 By", "11111111", "Instruktør");
Underviser u2 = new Underviser("træner", false, "Alice", "321 By", "88888888", "Underviser");
Console.WriteLine(u1.ToString());
Console.WriteLine(u2.ToString());

Console.WriteLine("\n");

Addministrator ad1 = new Addministrator("Ledelse", "Philip", "123 By", "11111111", "Direktør");
Addministrator ad2 = new Addministrator("vedligeholdelse", "Poul", "321 By", "88888888", "Admin");
Console.WriteLine(ad1.ToString());
Console.WriteLine(ad2.ToString());

Console.WriteLine("\nSamletAntalDeltagerePåAlleHold");

Console.WriteLine(holdKatalog.SamletAntalDeltagerePåAlleHold());

Console.WriteLine("\nGennemsnitligeDeltagerePrHold");

Console.WriteLine(holdKatalog.GennemsnitligeDeltagerePrHold());

Console.WriteLine("\nFlestDeltagerePåHold");

Console.WriteLine(holdKatalog.FlestDeltagerePåHold());

Console.WriteLine("\n");

//Console.WriteLine($"Prisen for 3 børn {h1.BeregnTotalPris(3)} ");
//Console.WriteLine($"Prisen for 1 børn {h1.BeregnTotalPris(1)} ");
//Console.WriteLine($"Prisen for 0 børn {h1.BeregnTotalPris(0)} ");
//Console.WriteLine($"Prisen for -1 børn {h1.BeregnTotalPris(-1)} ");
//Console.WriteLine(d1);
//Console.WriteLine(d2);





Console.ReadLine();


