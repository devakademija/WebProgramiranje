// Pronaci i ispisati najduzu rijec u stringu

Console.Write("Unesite string: ");
string recenica = Console.ReadLine();
Console.WriteLine();

char[] separatori = new char[] { ' ', '.', ',', '!', '?' };
string[] rijeci = recenica.Split(separatori, StringSplitOptions.RemoveEmptyEntries);


string memoryRijeci = "";
int najduljaRijec = 0;

foreach (var rijec in rijeci)
{
	if (rijec.Length > najduljaRijec)
	{
		memoryRijeci = rijec;
		najduljaRijec = rijec.Length;	
	}
}


Console.WriteLine("Najduža riječ u stringu je \"{0}\"", memoryRijeci);