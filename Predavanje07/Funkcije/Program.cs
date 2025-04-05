
double kvadratBroja = Kvadrat(5);
Console.WriteLine(kvadratBroja);
Console.WriteLine();

int ucitaniBroj = UcitajCijeliBroj();
Console.WriteLine(Kvadrat(ucitaniBroj));

partial class Program
{
    static double Kvadrat(double broj)
    {
        return broj * broj;
    }

    static int UcitajCijeliBroj()
    {
        Console.Write("Unesi cijeli broj:");
        int broj = int.Parse(Console.ReadLine());
        return broj;
    }

}
