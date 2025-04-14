using KlaseObjekti;


// Instanciranje klase = kreiranje objekta klase

Osoba osoba =  new Osoba();

// drugi način: Osoba osoba = new();
//Dodjeljivanje vrijednosti svojstvima objekta

osoba.Ime = "Pero";
osoba.Prezime = "Perić";

//pozivanje metode na objektu klase Osoba

string punoIme = osoba.VratiPunoIme();

Console.WriteLine("Puno ime osobe je {0}.", punoIme);

Osoba o2 = new();
Console.Write("Unesi ime: ");
o2.Ime = Console.ReadLine();
Console.WriteLine("Unesi prezime: ");
o2.Prezime = Console.ReadLine();

Console.WriteLine("Puno ime osobe je {0}.", o2.VratiPunoIme());


//Instanciranje i inicijaliziranje propertya klase
//shorthand

Osoba o3 = new() // ili new Osoba()
{
    Ime = "Marko",
    Prezime = "Marković"
};

string poruka;
if (o3.Ime == "Marko")
{
    poruka = "Osoba se zove Marko!";
}
else
{
    poruka = "Osoba se ne zove Marko!";
}

Console.WriteLine(poruka);

//shorthand za if

poruka = (o3.Ime == "Marko") ? "Osoba se zove Marko!" : "Osoba se ne zove Marko";