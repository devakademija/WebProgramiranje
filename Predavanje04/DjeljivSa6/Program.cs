/*
Napiši program u kojem se traži unos broja i ispisuje je li broj djeljiv sa 2 i sa 3 ili nije. Ako
jest, ispisuje se „Broj je djeljiv sa 6!“.
*/


Console.Write("Unesi cijeli broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj % 2 ==0 && broj % 3 == 0)
{
    Console.WriteLine("Broj je djeljiv sa 6");
}
else
{
    Console.WriteLine("Broj nije djeljiv sa 6");
}