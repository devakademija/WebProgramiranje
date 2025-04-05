/*Napiši program u kojem se za unesene duljine kateta u funkciji računa površina
jednakokračnog trokuta i ispisuje na zaslon.
P=
a∗b
2
*/


Console.WriteLine("Unesite duljine kateta jednakokracnog trokuta kako bi mu izracunali povrsinu!");

double prvaKateta = Unos();
double drugaKateta = Unos();
double povrsina = Povrsina(prvaKateta, drugaKateta);
Console.WriteLine("Povrsina jednakokracnog trokuta je: {0}", povrsina);


partial class Program
{
    static double Unos()
    {
        double unos = -1;
        bool checkpoint = false;
        do
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Unesite duljinu: ");
            try
            {
                unos = double.Parse(Console.ReadLine());
                if (unos <= 0)
                {
                    throw new Exception();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Uspjesno unesena duljina!");
                Console.ForegroundColor = ConsoleColor.Gray;
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

    static double Povrsina (double broj1, double broj2)
    {
        double povrsina;
        povrsina = (broj1 * broj2) / 2;
        return povrsina;
    }
}