/*
Napiši program u kojem se traži unos cijelog broja (može bi􀆟 i nega􀆟van) pa se ispisuje je li
broj jednoznamenkast, dvoznamenkast, troznamenkast ili višeznamenkast.
*/

Console.Write("Unesi cijeli broj: ");
int broj = int.Parse(Console.ReadLine());

//jednoznamenkasti: -9, -8, -7, ... 0, 1, 2, 3, ... 9
//dvoznamenkasti: -99, -98, -97, ... -10 ili 10, 11, 12, ... ,98, 99
//troznamenkasti: -999, -998, -997, ... -102, -101, -100 ili 100, 101, ... 999
// ostali su višeznamenkasti

if (broj >= -9 && broj <=9)
{
    Console.WriteLine("Broj je jednoznamenkast!");
}
else if ((broj >= -99 && broj <= -10) || (broj >= 10 && broj <= 99))
{
    Console.WriteLine("Broj je dvoznamenkast!");
}
else if ((broj >= -999 && broj <= -100) || (broj >=100 && broj <= 999))
{
    Console.WriteLine("Broj je troznamenkast!");
}
else
{
    Console.WriteLine("Broj je višeznamenkast!");
}