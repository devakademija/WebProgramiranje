using System.Collections;
using System.Reflection.Metadata.Ecma335;

try
{
    ArrayList brojevi = Unos();
    Ispis(brojevi);

    ArrayList neparni = IzvuciNeparne(brojevi);
    Ispis(neparni);

    ArrayList parni = IzvuciParne(brojevi);
    Ispis(parni);

    ArrayList izbaceniNeparni = IzbaciNeparne(brojevi);
    Ispis(izbaceniNeparni);
}
catch (Exception e)
{

    Console.WriteLine("Dogodila se greška: " + e.Message);
}
partial class Program
{
    static ArrayList Unos()
    {
        ArrayList list = new ArrayList();
        int i = 1;
        while (true)
        {
            try
            {
                Console.Write("Unesi {0}. broj: ", i);
                int broj = int.Parse(Console.ReadLine());
                if (broj == 0)
                {
                    break;
                }
                list.Add(broj);
                i++;
            }
            catch (Exception)
            {

                Console.WriteLine("Krivi unos!");
            }
        }
        return list;    
    }

    static void Ispis(ArrayList brojevi)
    {
        Console.WriteLine("---------- Ispis ----------");
        foreach (int i in brojevi)
        {
            Console.WriteLine(i);
        }
    }


    static ArrayList IzvuciNeparne (ArrayList brojevi)
    {
        ArrayList listaNeparnih = new ArrayList();
        foreach (int item in brojevi)
        {
            if (item % 2 != 0)
            {
                listaNeparnih.Add(item);
            }
        }
        return listaNeparnih;
    } 
    static ArrayList IzvuciParne(ArrayList brojevi)
    {
        ArrayList listaParnih = new ArrayList();
        foreach (int item in brojevi)
        {
            if (item % 2 == 0 )
            {
                listaParnih.Add(item);
            }
        }
        return listaParnih;
    }

    static ArrayList IzbaciNeparne(ArrayList brojevi)
    {
        for (int i = brojevi.Count - 1; i>= 0; i--)
        {
            if ((int)brojevi[i] % 2 != 0)
            {
                brojevi.RemoveAt(i);    
            }
        }
        return brojevi;
    }

}