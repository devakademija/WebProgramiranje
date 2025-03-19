

string ime = "";

// prvo se provjerava uvjet, pa se onda izvršava blok naredbi
// blok naredbi se ne mora niti jednom izvršiti


while (ime.ToLower() != "petar")
{
    Console.Write("Unesi svoje ime: ");
    ime = Console.ReadLine();
}

Console.WriteLine("Pozdrav, Petar!");


Console.WriteLine("------------------------------------");


// prvo se izvršava blok, a onda se provjerava uvjet
// blok naredbi će se sigurno izvršiti barem jednom

string novoIme = "Petar";

do
{
    Console.Write("Unesi svoje ime:");
    novoIme = Console.ReadLine();
} while (novoIme.ToLower() != "Petar");


Console.WriteLine("------------------------------------");
