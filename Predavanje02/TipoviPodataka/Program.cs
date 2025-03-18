


////Komentar

///*Komentar
// * Komentar
// * */

////1. camelCase - Prvo slovo je malo, a svaka sljedeća riječ počinje velikim slovom
//// Primjer: ovoJeRecenicaKojaPredstavljaCamelCase

////2. PascalCase - Svaka riječ počinje velikim slovom
//// Primjer: OvoJeRecenicaKojaPredstavljaPascalCase

////3. snake_case - Riječi su odvojene donjom crtom
//// Primjer: ovo_je_primjer_snake_case

////4. kebab-case - Riječi su odvojene crticom (-). Koristi se u HTML-u i nekim programskim jezicima, ali ne u C#.)
//// Primjer: ovo-je-primjer-kebab-case



//// TIPOVI PODATAKA U C#

//// Cjelobrojni tipovi

////1. int (integer) - Cijeli broj koji zauzima 4 bajta i ima raspon od -2,147,483,648 do 2,147,483,647

//int x = 10;

//// 2. short - Kraći cijeli broj koji zauzima 2 bajta.

//short u = 2145;

//// 3. long - Duži cijeli broj koji zauzima 8 bajta.

//long v = 12345686965;

//// 4. uint (unsigned int) - Cijeli broj bez negativnih vrijednosti, zauzima 4 bajta.

//uint b = 4294967295;

//// 5. ulong (unsigned long) - 64- bitni vijeli broj bez negativnih vrijednosti.

//ulong c = 18446744073709551615;



//// DECIMALNI BROJEVI

////1. float - Decimalni broj jednostruke preciznosti, zauzima 4 bajta

//float y = 20.24f;

////2. double - Decimalni bbroj dvostruke preciznosti, zauzima 8 bajta.

//double z = 3.51251551D;

////3. decimal - Decimal broj visoke preciznosti, zauzima 16 bajta (najčešće se koristi za financijske izračune.)

//decimal w = 12324.31242M;


//// LOGIČKI TIPOVI PODATAKA

//// bool (boolean) - Može imati samo dvije vrijednosti: true ili false.

//bool istina = true;
//bool laž = false;


//// Znakovni i tekstualni tipovi

////1. char - Predstavlja jedan znak (npr. slovo, broj ili simbol)

//char slovo = 'a';

//// 2. string - Predstavlja niz znakova (tekst)

//string poruka = "ovoJePoruka";


// Zbrajanje dva broja

//int a = 10;
//int b = -7;

//int c = a + b;

//Console.WriteLine(c); // ispisuje: 3


// Rad s tekstualnim podacima


//string mojeIme;

//mojeIme = "Petar";

//Console.WriteLine(mojeIme);

//string mojePrezime = "Perić";
//Console.WriteLine(mojePrezime);


//Console.Write("Petar ");
//Console.Write("+ ");
//Console.WriteLine("Perić");


//int broj1, broj2, broj3;
//broj1 = broj2 = broj3 = 2;


//Console.WriteLine(broj1);
//Console.WriteLine(broj2);
//Console.WriteLine(broj3);

//broj1 = 5;
//broj2 = 10;
//broj3 = 11;

//Console.WriteLine(broj1);
//Console.WriteLine(broj2);
//Console.WriteLine(broj3);


// Unos podatak od korisnika

//Korisnik može unijeti broj putem Console.Readline(), a mi ga konvertiramo u int:

//int broj3;

//Console.WriteLine("Unesite cijeli broj: ");
//broj3 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(broj3);


// U ovom primjeru tražimo od korisnika da unese dva broja, a zatim ih zbrajamop.

Console.WriteLine("Unesi prvi broj: ");
int broj1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Unesi drugi broj: ");
int broj2 = Convert.ToInt32(Console.ReadLine());

int zbroj = broj1  + broj2;

Console.WriteLine("Zbroj je: " + zbroj);