/*Napiši program u kojem se za uneseni polumjer r ispisuje opseg i površina kruga.
O=2∗r∗π , P=r2 π
*/

using System.Data;

double input = Unos();
OpsegKruga(input);
PovrsinaKruga(input);   
partial class Program
{
    static double Unos()
    {
        double unos = -1;
        bool checkpoint = false;
        do
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Unesite polumjer r:");
            try
            {
                unos = double.Parse(Console.ReadLine());
                if (unos <= 0)
                {
                    throw new Exception();
                }
                checkpoint = true;
            }
            catch (Exception)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Niste unijeli prihvatljiv broj!");
            }
        } while (checkpoint == false);
        return unos;
    }

    static void OpsegKruga(double broj)
    {
        double opseg;
        opseg = 2 * broj * Math.PI;
        Console.WriteLine("Opseg kruga je: {0}", opseg);
    }

    static void PovrsinaKruga(double broj)
    {
        double povrsina;
        povrsina = (broj * broj) * Math.PI;
        Console.WriteLine("Povrsina kruga je {0}", povrsina);
    }

}