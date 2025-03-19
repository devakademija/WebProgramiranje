/*
Napiši program u kojem ćeš na početku inicijalizira􀆟 cjelobrojnu varijablu na neku vrijednost i
za􀆟m ju ispisa􀆟 na način da se njezina vrijednost nakon ispisa poveća za jedan a da nisi
koris􀆟o operator pridruživanja „=“. Napomena: Koris􀆟 inkrement operator po kojem je npr.
C++ programski jezik dobio ime.
*/

// s operatorom pridruživanja
int nekiBroj = 5;
Console.WriteLine(nekiBroj);
nekiBroj = nekiBroj + 1; // zadatak je bez ovoga
Console.WriteLine(nekiBroj);

Console.WriteLine("---------------------------");
//rješenje
int nekiNoviBroj = 5;
Console.WriteLine(nekiNoviBroj++); // 5
Console.WriteLine(nekiNoviBroj); // 6
Console.WriteLine(++nekiNoviBroj); //  7