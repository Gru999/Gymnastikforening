
using Gymnastikforening;
using GymnastikForening;

Hold h1 = new Hold("Tumle22t", 2022, "Tumlinger", 500, 35);
Hold h2 = new Hold("Tumle23t", 2022, "Rollinger", 500, 15);

#region Opgave 14
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

Console.WriteLine(holdKatalog);




Deltager d1 = new Deltager("Poul Henriksen", "Vej 123", 20);
Deltager d2 = new Deltager("Charlotte Heegaard", "Gade 321", 15);
Deltager d3 = new Deltager("Poul Henriksen", "Vej 123", 5);      //1500kr
Deltager d4 = new Deltager("Charlotte Heegaard", "Gade 321", 5); //1500kr
Deltager d5 = new Deltager("Poul Henriksen", "Vej 123", 3);      //1000kr
Deltager d6 = new Deltager("Charlotte Heegaard", "Gade 321", 2); //750kr

try
{
    h1.TilmeldDeltager(d1);
    h1.TilmeldDeltager(d2);
    h2.TilmeldDeltager(d3);
    h2.TilmeldDeltager(d4);
    h2.TilmeldDeltager(d5);
    h2.TilmeldDeltager(d6);
}
catch (FuldtHoldException fex)
{
    Console.WriteLine(fex.Message);
}
catch (ArgumentException aex) 
{
    Console.WriteLine("Du kan ikke tilføje et antal børn mindre end et");
}
#endregion

#region Opgave 15
Ansat a1 = new Ansat("John", "321 Vej", "12345678", "træner");
Ansat a2 = new Ansat("Bob", "123 Vej", "87654321", "leder");
Console.WriteLine(a1.ToString());
Console.WriteLine(a2.ToString());

Console.WriteLine("\n");
#endregion

#region Opgave 16
Underviser u1 = new Underviser("træner", true, "Charlie", "123 By", "11111111", "Instruktør");
Underviser u2 = new Underviser("træner", false, "Alice", "321 By", "88888888", "Underviser");
Console.WriteLine(u1.ToString());
Console.WriteLine(u2.ToString());

Console.WriteLine("\n");

Addministrator ad1 = new Addministrator("Ledelse", "Philip", "123 By", "11111111", "Direktør");
Addministrator ad2 = new Addministrator("vedligeholdelse", "Poul", "321 By", "88888888", "Admin");
Console.WriteLine(ad1.ToString());
Console.WriteLine(ad2.ToString());
#endregion

#region Opgave 17
Console.WriteLine("\n-----SamletAntalDeltagerePåAlleHold-----");
Console.WriteLine(holdKatalog.SamletAntalDeltagerePåAlleHold());
Console.WriteLine("----------------------------------------\n");

Console.WriteLine("\n-----GennemsnitligeDeltagerePrHold-----");
Console.WriteLine(holdKatalog.GennemsnitligeDeltagerePrHold());
Console.WriteLine("---------------------------------------\n");

Console.WriteLine("\n-----FlestDeltagerePåHold-----");
Console.WriteLine(holdKatalog.FlestDeltagerePåHold());
Console.WriteLine("------------------------------\n");

Console.WriteLine("\n-----HoldMedFlestDeltagere-----");
Console.WriteLine(holdKatalog.HoldMedFlestDeltagere());
Console.WriteLine("-------------------------------\n");

Console.WriteLine("\n-----MaxIndtjenningpåHold-----");
Console.WriteLine(holdKatalog.MaxIndtjenningpåHold(h2));
Console.WriteLine("------------------------------\n");

Console.WriteLine("\n-----HoldMedHøjestIndtjenning-----");
Console.WriteLine(holdKatalog.HoldMedHøjstIndtjenning());
Console.WriteLine("----------------------------------\n");
#endregion

#region Opgave 18
//Not a copy
Ansat a3 = new Ansat("Bob", "12 Vej", "98765432", "træner");
//Copy of a2 (see Opgave 15)
Ansat a4 = new Ansat("Bob", "123 Vej", "87654321", "leder");

GenericRepository<Ansat> gRepo = new GenericRepository<Ansat>();

//Add test
gRepo.Add(a1);
gRepo.Add(a2);
gRepo.Add(a3);
gRepo.Add(a4);

//Remove test
gRepo.Remove(a1);

//Update test
gRepo.Update(a3, new Ansat("Frank", "vej 1", "10101010", "træner"));


//Ansat print
Console.WriteLine();
foreach (Ansat a in gRepo.List) {
    Console.WriteLine(a.ToString());
}
#endregion

Console.ReadLine();


