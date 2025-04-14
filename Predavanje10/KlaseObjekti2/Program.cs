using KlaseObjekti2;

Osoba o1 = new Osoba();
o1.Ime = "Ana";
o1.Prezime = "Anić";

Console.WriteLine("Broj osoba: " + Osoba.DohvatiBrojOsoba());
Console.WriteLine("Puno ime " + o1.PunoIme());

Console.WriteLine("-----------------------------------------------------");

Osoba o2 = new();
o2.Ime = "Iva";
o2.Prezime = "Ivić";
Console.WriteLine("Puno ime " + o2.PunoIme());
Console.WriteLine("Broj osoba: " + Osoba.DohvatiBrojOsoba());

Console.WriteLine("-----------------------------------------------------");

Osoba o4 = new Osoba() { Ime = "Josip", Prezime = "Josipović" };
Console.WriteLine("Puno ime " + o4.PunoIme());
Console.WriteLine("Broj osoba: " + Osoba.DohvatiBrojOsoba());

Console.WriteLine("-----------------------------------------------------");

Osoba o3 = new Osoba("Pero", "Perić");
Console.WriteLine("Puno ime " + o3.PunoIme());
Console.WriteLine("Broj osoba: " + Osoba.DohvatiBrojOsoba());
