
#region Ponavljanje
// obični nizovi
using System.Collections;
using System.Diagnostics.Metrics;

int[] cijeliBrojevi = new int[3];
int[] cijeliBrojevi2 = [0, 2, 4, 6];
int[] cijeliBrojevi3 = [1, 3, 5, 7];

//ArrayListe - dozvoljavaju spremanje različitih tipova varijabli

ArrayList arrayLista = new ArrayList();
arrayLista.Add("neka riječ"); //String
arrayLista.Add(3); // Integer
arrayLista.Add(true); //Boolean

ArrayList arrayLista2 = new();

ArrayList arrayLista3 = new ArrayList() {"riječ", 2, false };
arrayLista3.Add("nova riječ");

//foreach (int i in arrayLista)
//{
//    Console.WriteLine(i+1);
//}

#endregion

#region GenerickeListe

List<string> stringovi = new List<string>();

stringovi.Add("Riječ 1");
stringovi.Add("Riječ 2");
stringovi.Add("Riječ 3");
stringovi.Add("Riječ 4");


for (int i = 0; i < stringovi.Count; i++)
{
    Console.WriteLine((i+1) + ". riječ: " + stringovi[i]);
}

Console.WriteLine("--------------------------------------------");

int counter = 1;
foreach (string rijec in stringovi)
{
    Console.WriteLine(counter + ". riječ: " + rijec );
    counter++;
}


Console.WriteLine("---------------------------------------------");

foreach (string rijec in stringovi)
{
    Console.WriteLine(stringovi.IndexOf(rijec) + 1);
    Console.WriteLine(rijec);
}
#endregion