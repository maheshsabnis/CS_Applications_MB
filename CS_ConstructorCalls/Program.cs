// See https://aka.ms/new-console-template for more information
Console.WriteLine("Having Constructors Across Base and Derive class");
Derive d = new Derive(1000);
d.PrintX();


Console.ReadLine();


public class Base
{
	private int _x;
	public Base(int x)
	{
		_x = x;
	}

	public void PrintX()
	{
		Console.WriteLine(_x);
	}
}
/// <summary>
/// Add a ctor in derive class that calls the Base class ctor 
/// </summary>
public class Derive : Base
{
	public Derive(int y):base(y)
	{
	}
}
