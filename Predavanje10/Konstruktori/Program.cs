
using Konstruktori;

// instanciranje objekta klase sa defaultnim konstruktorom
Osoba o1 = new Osoba();
o1.Ime = "Marko";
o1.Prezime = "Matković";
Console.WriteLine("{0} {1}", o1.Ime, o1.Prezime);

Console.WriteLine("-------------------------------------------");

// instanciranje objekata klase sa parametriziranim konstruktorima
Osoba o2 = new Osoba("Pero");
Console.WriteLine("{0} {1}", o2.Ime, o2.Prezime);

Console.WriteLine("-------------------------------------------");

Osoba o3 = new Osoba("Duje", "Dujić");
Console.WriteLine("{0} {1}", o3.Ime, o3.Prezime);

Console.WriteLine("-------------------------------------------");

Osoba o4 = new Osoba("Ivana", false);
Console.WriteLine("{0} {1}", o4.Ime, o4.Prezime);

Console.WriteLine("-------------------------------------------");

Osoba o5 = new Osoba("Ivanić", true);
Console.WriteLine("{0} {1}", o5.Ime, o5.Prezime);

Console.WriteLine("--------------------- Lista osoba ----------------------");

List<Osoba> osobe = new List<Osoba>();
osobe.Add(o1);
osobe.Add(o2);
osobe.Add(o3);
osobe.Add(o4);
osobe.Add(o5);

foreach (Osoba o in osobe)
{
    Console.WriteLine("{0} {1}", o.Ime, o.Prezime);
}




