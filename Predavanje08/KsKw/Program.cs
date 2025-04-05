/*
Napiši program koji pretvara KS u KW i obrnuto, ovisno o odabiru korisnika.
1 KS = 0,736 KW
1 KW =1,359 KS
*/


//Opcija za odabir konverzije

Console.WriteLine("Odaberite opciju konverzije: ");
Console.WriteLine("1 - KS u KW");
Console.WriteLine("2 - KW u KS");
Console.WriteLine("Unesite broj opcije (1 ili 2):");

int opcija = int.Parse(Console.ReadLine());

//Razgranavanje opcije na temelju korisničkog odabira
if  (opcija == 1)
{
    Console.Write("Unesite broj konjskih snaga (KS): ");
    double ks = double.Parse(Console.ReadLine());

    //Konverzija KS u KW
    double kw = KS_u_KW(ks);
        Console.WriteLine($"{ks} KS je jednako {kw} KW.");
}
else if (opcija == 2)
{
    Console.WriteLine("Unesite broj kilovata (KW): ");
    double kw = double.Parse(Console.ReadLine());

    //konverzija kw u ks
    double ks = KW_u_KS(kw);
        Console.WriteLine($"{kw} KW je jednako {ks} KS.");
}
else
{
    Console.WriteLine("Nevažeća opcija");
}

//funkcija za konverziju ks u kw
static double KS_u_KW(double ks)
{
    return ks * 0.73549875;
}

// funkcija za konverziju kw u ks

static double KW_u_KS(double kw)
{
    return kw * 1.359;
}
