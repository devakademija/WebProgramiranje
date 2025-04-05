/* Napiši program u kojem se traži unos prirodnih brojeva dok se ne unese 0 i za􀆟m se uneseni
brojevi ispisuju poredani po veličini.
Napomena: Za ispis elemenata sor􀆟ranog niza koris􀆟􀆟 petlju foreach.
Try Catch Finally!!! */


List<int> prirodniBrojevi = new List<int>();
Console.ForegroundColor = ConsoleColor.DarkBlue;

Console.WriteLine("Prvo unesite prirodne brojeve zatim unesite 0 za ispis brojeva poredanih po veličini: ");
Console.ForegroundColor = ConsoleColor.Gray;

int brojac = 1;
while (true)
{
	try
	{
		Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write($"Unesi {brojac}. broj: ");
		int broj = int.Parse( Console.ReadLine() );

		if (broj == 0) break;
		if (broj < 1)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			throw new Exception("Unesi prirodan broj!");
		}
		prirodniBrojevi.Add(broj);
		brojac++;

	}
	catch (Exception)
	{
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Greška! Niste nijeli prirodan broj!");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
prirodniBrojevi.Sort();

Console.ForegroundColor = ConsoleColor.Yellow;

if (brojac == 1)
{
    Console.WriteLine("Nema brojeva za sortiranje!");
}
else
{
    Console.WriteLine("Brojevi poredani po veličini: ");
    Console.ForegroundColor = ConsoleColor.Gray;

	foreach (int item in prirodniBrojevi)
	{
        Console.WriteLine(item);
	}
}