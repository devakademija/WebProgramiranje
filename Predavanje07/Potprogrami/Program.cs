Pozdrav();
Pozdrav();
Pozdrav();
Pozdrav();
Pozdrav();
Pozdrav();
Pozdrav(); 
Console.WriteLine();
Pozdrav("Ivan");
Console.WriteLine();

Pozdrav("Ivan", "Ivanov");
Console.WriteLine();

Pozdrav("Ivan", 10);

Console.WriteLine();

Kraj();
partial class Program
{
    static void Pozdrav()
    {
        Console.WriteLine("*******************");
        Console.WriteLine("Živjeli potprogrami");
        Console.WriteLine("*******************");
    }

    static void Kraj()
    {
        Console.WriteLine("Pritisni bilo koju tipku za kraj...");
        Console.ReadKey();
    }

    static void Pozdrav(string ime)
    {
        Console.WriteLine("Dobro večer, {0}", ime);
    }

    static void Pozdrav(string ime, string prezime)
    {
        Console.WriteLine("Dobro večer, {0} {1}", ime, prezime);
    }


    static void Pozdrav(string ime, int brojPonavljanja)
    {
        for (int i = 0; i < brojPonavljanja; i++)
        {
            Pozdrav(ime);
        }
    }
}