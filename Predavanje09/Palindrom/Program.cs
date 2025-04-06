//Napiši program koji provjerava jeli unesena rijec ili recenica palindrom
//Napomena: Treba zanemari􀆟 razmake, interpunkcijske znakove i velika i mala slova


using System.Security.Cryptography;

Console.Write("Unesi neku riječ ili rečenicu: ");
string recenica = Console.ReadLine();   

string uredjenaRecenica = recenica.Replace("!","").Replace(",","").Replace(".","").Replace(" ", "").ToLower();

string uredjenaRecenicaUnatrag = string.Join("", uredjenaRecenica.Reverse());
// ovoplavovalpovo

if (uredjenaRecenica == uredjenaRecenicaUnatrag)
{
    Console.WriteLine("Recenica je palindrom!");
}
else
{
    Console.WriteLine("Recenica nije palindrom!");
}

