// 6. ProstiFaktori.cs
// Napiši program u kojem se traži unos prirodnog broja, a zatim se ispisuje rastav broja na
// proste faktore.
// Napomena: Broj dijeliti prostim faktorom dok rezultat dijeljenja ne bude različit od 0.
// Primjer: 20 = 2 * 2 * 5


int broj = -1;
int originalniBroj = -1;
List<int> faktori = new List<int>();

bool unosJeDobar = false;   

while (unosJeDobar == false)
{
    Console.WriteLine("Unesi prirodni broj: ");
	try
	{
		broj = int.Parse(Console.ReadLine());
		if (broj <= 0)
		{
			throw new Exception();
		}
		originalniBroj = broj;
		unosJeDobar = true;
	}
	catch (Exception)
	{

		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("Greška! Niste unijeli prirodan broj...");
		Console.ForegroundColor = ConsoleColor.Gray;
	}
}

int prostiBroj = 2;
while (broj > 1)
{
	if (broj % prostiBroj == 0)
	{
		broj = broj / prostiBroj;
		faktori.Add(prostiBroj);
	}
	else
	{
		prostiBroj++;
	}
}

if (originalniBroj > 1)
{
    //   Console.Write(originalniBroj + " = ");
    //Console.WriteLine(string.Join(" * ", faktori));

    // 2. način

    Console.Write(originalniBroj + " = ");
	for (int i = 0; i < faktori.Count; i++)
	{
		if (i < faktori.Count -1)
		{
			Console.Write(faktori[i] + " * ");
		}
		else
		{
			Console.WriteLine(faktori[i]);
		}
	}
}
else
{
    Console.WriteLine("Broj se ne može rastaviti na proste faktore!");
}