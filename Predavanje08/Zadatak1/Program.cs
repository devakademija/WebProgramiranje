/*
Napravi program koji traži unos rečenice od korisnika, a zatim ispisuje
koliko samoglasnika i koliko suglasnika rečenica sadrži. Program treba biti otporan
na greške pri unosu.
*/


try
{
    Console.Write("Unesite rečenicu: ");
    string recenica = Console.ReadLine();
    if (recenica.Trim().Split(' ').Count() <= 1)
    {
        throw new Exception();
    }

    int samoglasnika = 0;
    int suglasnika = 0;

    foreach (char slovo in recenica)
    {
        if (slovo.ToString().ToLower() == "a" || slovo.ToString().ToLower() == "e" || slovo.ToString().ToLower() == "o" ||
            slovo.ToString().ToLower() == "i" || slovo.ToString().ToLower() == "u")
        {
            samoglasnika++;
        }
        else if (slovo >= 'a' && slovo <= 'z' || slovo >= 'A' && slovo <= 'Z')
        {
            suglasnika++;
        }
    }

    Console.WriteLine("Samoglasnika ima: " + samoglasnika);
    Console.WriteLine("Suglasnika ima: " + suglasnika);

}

catch (Exception)
{

    Console.WriteLine("Niste unijeli rečenicu!");
}