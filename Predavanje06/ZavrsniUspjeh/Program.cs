/* 14. ZavrsniUspjeh.cs
Napiši program koji će izračunati završni uspjeh učenika na kraju školske godine. Prvo se traži
unos broja predmeta, a zatim se unose ocjene. Ako su sve unesene ocjene „pozitivne”
program ispisuje završni uspjeh, inače ispisuje „Uspjeh je nedovoljan”. Za pogrešno unesenu
ocjenu treba zatražiti ponovni unos.
*/

int Unos = 1;
int Unos2 = 2;
bool checkpoint = false;

do
{
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write("Koliko ima predmeta?: ");
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

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Unos je dobar!");
Console.ForegroundColor = ConsoleColor.Gray;

checkpoint = false;
float Sum = 0;
int y = 1;
bool NegativnaOcjena = false;

while (y <= Unos)
{
    do
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("Unesite {0}. ocjenu: ", y);
        try
        {
            Unos2 = int.Parse(Console.ReadLine());
            if (Unos2 <= 0 || Unos2 > 5)
            {
                throw new Exception();
            }
            checkpoint = true;
        }
        catch (Exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Niste unijeli prihvatljivu ocjenu!");
        }
    } while (checkpoint == false);

    checkpoint = false;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Unos je dobar!");
    Console.ForegroundColor = ConsoleColor.Gray;

    Sum += Unos2;
    y++;

    if (Unos2 == 1)
    {
        NegativnaOcjena = true;
    }
}



if (NegativnaOcjena == true)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Uspjeh je nedovoljan!");
    Console.ForegroundColor = ConsoleColor.Gray;
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Prosjek unesenih ocjena je: {0}", (double)Sum / Unos);
    Console.ForegroundColor = ConsoleColor.Gray;
}