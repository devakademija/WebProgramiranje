using ProizvodApp;

Proizvod p = new Proizvod();

Console.Write("Unesi naziv: ");
p.Naziv = Console.ReadLine();

bool ispravno = false;

do
{
    Console.Write("Unesi cijenu: ");
	try
	{
		p.Cijena = Double.Parse(Console.ReadLine());
		if (p.Cijena <= 0) { throw new Exception(); }
		ispravno = true;	
		
	}
	catch (Exception)
	{

        Console.WriteLine("Krivi unos!"); 
	}
} while (!ispravno);

ispravno = false;

do
{
    Console.WriteLine("Unesi maržu: ");
	try
	{
		p.Marza = Double.Parse(Console.ReadLine());
		if (p.Marza <= 0) { throw new Exception(); }
		ispravno = true;



	}
	catch (Exception)
	{

        Console.WriteLine("Krivi unos!");
    }
} while (!ispravno);


ispravno = false;

do
{
    Console.Write("Unesi porez: ");
	try
	{
		p.Porez = Double.Parse(Console.ReadLine());
		if (p.Porez < 0) { throw new Exception(); }
		ispravno = true;
	}
	catch (Exception)
	{

        Console.WriteLine("Krivi unos!");
    }
} while (!ispravno);


Console.WriteLine("Maloprodajna cijena je: " + p.MPC());