//Napiši program u kojem se traži unos prirodnog broja, a zatim se znamenke upisanog broja ispisuju unatrag.
//Napomena: Svaku znamenku upisanog broja spremiti kao poseban element kolekcije.

string prirodniBroj = "";

while (true)
{
    Console.Write("Unesi prirodni broj: ");
    prirodniBroj = Console.ReadLine();

	try
	{
		if (int.Parse(prirodniBroj) is int) break;
		

		
	}
	catch (Exception)
	{

        Console.WriteLine("Krivi unos!");
	}
}

char[] znamenke = prirodniBroj.ToCharArray();
znamenke = znamenke.Reverse().ToArray();	

foreach (char c in znamenke)
{
    Console.Write(c);
}	