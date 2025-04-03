/* 9. Ekstremi.cs
Napiši program u kojem se traži unos 10 prirodnih brojeva, 
a zatim se ispisuje najmanji i najveći od njih.*/

bool checkpoint = false;
int Unos = 1;

int Min = Int32.MaxValue;
int Max = 0;

for (int i = 1; i <= 10; i++)
{
	do
	{
		Console.ForegroundColor = ConsoleColor.Gray;
		Console.Write("Unesite {0}. prirodni broj: ", i);

		try 
		{
			Unos = int.Parse(Console.ReadLine());
			if (Unos <= 0)
			{
				throw new Exception();
			}
			checkpoint = true;
		}
		catch (Exception)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Niste unijeli prirodan broj!");
		}

	} while (checkpoint == false);

	checkpoint = false;

	Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine("Unos je dobar ! ");

	Console.ForegroundColor = ConsoleColor.Gray;


	if (Unos > Max)
	{
		Max = Unos;
	}
	if (Unos < Min)
	{
		Min = Unos;
	}
}

Console.WriteLine("Najmanji uneseni broj je {0}, a najveci uneseni broj je: {1}", Min, Max);