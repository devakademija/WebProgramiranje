/* 7. SavrsenBroj.cs
Prilagodi prethodni program Djelitelji.cs tako da se ispisuje je li broj 
savršen ili nije. Savršen broj je jednak broju koji je jednak zbroju 
svojih djelitelja (uključujući broj 1 ali ne i njega samog).
*/


int Unos = -1;
bool brojJePrirodanCijeli = false;

do
{
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write("Unesite prirodni broj za koji zelite znati je li savrsen: ");

    try
    {
        Unos = int.Parse(Console.ReadLine());
        if (Unos <= 0)
        {
            throw new Exception();
        }
        brojJePrirodanCijeli = true;

    }
    catch (Exception)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Niste unijeli prirodan broj!");
    }

} while (brojJePrirodanCijeli == false);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Unos je dobar !");
Console.ForegroundColor= ConsoleColor.Gray;


int SumaDjelitelja = 1;
for (int i = 2; i < Unos; i++)
{
    if (Unos % i == 0)
    {
        SumaDjelitelja += i;
    }
}

if (SumaDjelitelja == Unos)
{
    Console.WriteLine("Broj je savrsen!");
}
else
{
    Console.WriteLine("Broj nije savrsen!");
}