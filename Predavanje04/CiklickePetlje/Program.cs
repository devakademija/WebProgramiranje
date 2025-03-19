// 1. Primjer - ispisati brojeve od 1 do 10

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + 1);
}

Console.WriteLine("----------------------------");

// 2. primjer
// Neparni brojevi veći od 1 a manje od 20
// 1, 3, 5, 7, 9, ..., 17, 19

for (int i = 1; i < 20; i = i + 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("----------------------------");

// 3. primjer
// Ispisati brojeve iz intervala [1,100] djeljive sa 5


for (int i = 5; i <= 100; i = i + 5)
{
    Console.WriteLine(i);
}

Console.WriteLine("----------------------------");


// 3. primjer - 2. način

for (int i = 1; i <=100; i++)
{
    if (i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}