/* 13. ParNepar.cs
Napiši program koji traži unos prirodnih brojeva dok se ne unese 0,
a zatim ispisuje koliko je bilo parnih, a koliko neparnih brojeva.*/


int Input = 1;
int Parni = 0;
int NeParni = 0;


bool checkpoint = false;
Console.WriteLine("Unesite prirodne brojeve, program ce zavrsiti ako unesete 0");

while (Input != 0)
{
    do
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("Unesite prirodni broj:");

        try
        {
            Input = int.Parse(Console.ReadLine());
            if (Input < 0)
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

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Unos je dobar!");
    Console.ForegroundColor = ConsoleColor.Gray;


    if (Input == 0) break; // break naredba prekida petlju

    if (Input % 2 == 0)
    {
        Parni++;
    }
    else
    {
        NeParni++;
    }


    Console.WriteLine("Bilo je {0} parnih brojeva uneseno!", Parni);
    Console.WriteLine("Bilo je {0} neparnih brojeva uneseno!", NeParni);

}