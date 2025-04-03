//ZamjeniMjesta
//Napiši program u kojem se traži unos 10 brojeva koji se zatim ispisuju, 
//ali najvećem i najmanjem treba zamijeniti mjesta.

using System.Collections.Concurrent;

double[] brojevi = new double[10];

for (int i = 0; i < 10; i++)
{
    bool unosJeDobar = false;
    while (!unosJeDobar)
    {
        Console.Write($"Unesi {i + 1}. broj:");
		try
		{
			double broj = double.Parse(Console.ReadLine());
			brojevi[i] = broj;
			unosJeDobar = true;
		}
		catch (Exception)
		{

            Console.WriteLine("Greška! Niste unijeli broj...");
		}
    }
}

double najmanji = brojevi.Min();
double najveci = brojevi.Max();


foreach (double item in brojevi)
{
	if (item == najmanji)
	{
        Console.WriteLine(najveci);
	}
	else if (item == najveci)
	{
		Console.WriteLine(najmanji);
	}
	else
	{
        Console.WriteLine(item);
	}
}
