/*
Napiši program u kojem se stupnjevi Celzijeve ljestvice preračunavaju u stupnjeve
Fahrenheitove.
T F=
9
5
∗T C+ 32 
*/


double Celsius = Unos();
CelsiusToFahrenheit(Celsius);


partial class Program
{
    static double Unos()
    {
        double unos = -1;
        bool checkpoint = false;

        do
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Unesite temperaturu u Celzijusu: ");
            try
            {
                unos = double.Parse(Console.ReadLine());
                if (unos < -273.15)
                {
                    throw new Exception();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Uspjesno unesena temperatura!");
                Console.ForegroundColor = ConsoleColor.Gray;
                checkpoint = true;
            }
            catch (Exception)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unesena temperatura je nemoguca! ");
            }



        } while (checkpoint == false); 
        return unos;
    }

    static void CelsiusToFahrenheit(double Celsius)
    {
        double Fahrenheit;
        Fahrenheit = (Celsius * 9 / 5) + 32;
        Console.WriteLine("\"{0}ºC = {1}ºF\"", Celsius, Fahrenheit);
    }
}