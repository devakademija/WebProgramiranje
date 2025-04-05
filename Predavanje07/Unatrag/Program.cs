// Napiši program u kojem se traži unos 10 elemenata i koji se spremaju u objekt ArrayList, a
//za􀆟m se ispisuju unatrag.

using System.Collections;

ArrayList eleRijeci = new ArrayList();

Console.WriteLine("Unesi 10 elemenata: ");

for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"Element {i + 1}: ");
    string input = Console.ReadLine();  
    eleRijeci.Add( input ); 
}

Console.WriteLine("Elemente unesi unatrag: ");
// ispisujemo unos od korisnika na konzolu
//1. nacin

for (int i = eleRijeci.Count - 1; i >= 0; i--)
{
    Console.WriteLine(eleRijeci[i]);
}
Console.WriteLine("Elementi unatrag sa foreach petljom: ");
eleRijeci.Reverse();

foreach (string rijec in eleRijeci)
{
    Console.WriteLine(rijec);
}