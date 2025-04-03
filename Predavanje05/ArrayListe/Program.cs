//namespace za kolekcije

using System.Collections;

// inicijalizacija arrayliste
ArrayList arrayList = new ArrayList();


for (int i = 0; i < 3; i++)
{
    Console.Write("Unesi broj: ");
    int broj = int.Parse(Console.ReadLine());
    //dodavanje elementa u listu
    arrayList.Add(broj);

}

Console.WriteLine("---------------------------------");

arrayList.Sort();

arrayList.Add("Petar");
arrayList.Add("Petar");

foreach (var element in arrayList)
{
    Console.WriteLine(element);
}



Console.WriteLine("---------------------------------");


arrayList.Reverse();

foreach (var element in arrayList)
{
    Console.WriteLine(element);
}


Console.WriteLine("-----------------------------------");


arrayList.Remove("Petar");

for (int i = 0; i < arrayList.Count; i++)
{
    Console.WriteLine(arrayList[i]);
}

Console.WriteLine("-----------------------------------");


Console.WriteLine(arrayList.Count);

Console.WriteLine("------------------------------------");

foreach(var element in arrayList)
{
    Console.WriteLine(element);
}

//makni element sa indeksom 0

arrayList.RemoveAt(0);
arrayList.AddRange(arrayList);

Console.WriteLine("------------------------------------");

foreach (var element in arrayList)
{
    Console.WriteLine(element);
}

//brisanje svih elemenata iz liste

arrayList.Clear();