//Napiši program u kojem se traži unos broja i ispisuje je li broj u intervalu [0, 12] ili nije.
// 0, 1, 2, 3, ... , 8, 9 10, 11, 12


Console.Write("Unesi cijeli broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj >= 0 && broj <= 12)
{
    Console.WriteLine("Broj je u intervalu [0,12]");
}
else
{
    Console.WriteLine("Broj nije u intervalu [0,12]");
}