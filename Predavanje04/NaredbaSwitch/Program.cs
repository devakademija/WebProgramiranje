


decimal brojA = 0;
decimal brojB = 0;
string operacija = "";
decimal rezultat = 0;


try
{
    Console.Write("Unesi prvi broj: ");
    brojA = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Unesi drugi broj: ");
    brojB = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Odaberi računsku operaciju (+,-,*,/): ");
    operacija = Console.ReadLine();


    switch (operacija)
    {
        case "+":
            rezultat = brojA + brojB;
            break;

        case "-":
            rezultat = brojA - brojB;
            break;

        case "*":
            rezultat = brojA * brojB;
            break;

        case "/":
            rezultat = brojA / brojB;
            break;

        default:
            Console.WriteLine("Nepoznata računska operacija!");
            break;
    }
}

catch (Exception)
{
    Console.WriteLine("Dogodila se greška!");
}

finally
{
    if (operacija == "+" || operacija == "-" || operacija == "*" || operacija == "/")

    {
        Console.WriteLine("Rezultat je " + rezultat);
    }
}