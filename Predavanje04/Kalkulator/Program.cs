/*
Napiši program kojim se izvode osnovne računske operacije. Traži se unos dva broja i unos
računske operacije. Nakon unosa ispisuje se rezultat i omogućuje ponovno računanje ili kraj
programa.
*/

Console.Write("Unesi prvi broj: ");
decimal prviBroj = decimal.Parse(Console.ReadLine());

Console.Write("Unesi drugi broj: ");
decimal drugiBroj =  decimal.Parse(Console.ReadLine());

Console.Write("Unesi računsku operaciju: ");
string operacija = Console.ReadLine();


if (operacija == "+")
{
    Console.WriteLine("{0} + {1} = {2}", prviBroj, drugiBroj, prviBroj + drugiBroj);
}
else if (operacija == "-")
{
    Console.WriteLine("{0} - {1} = {2}", prviBroj, drugiBroj, prviBroj - drugiBroj);
}
else if (operacija == "*")
{
    Console.WriteLine("{0} * {1} = {2}", prviBroj, drugiBroj, prviBroj * drugiBroj);
}
else if (operacija == "/")
{
    Console.WriteLine("{0} / {1} = {2}", prviBroj, drugiBroj, prviBroj / drugiBroj);
}