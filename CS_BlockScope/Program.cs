// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x = 10;

if (x > 7)
{
    int y = 3; // Inside the if-statement block, hence this is scopped to if-block

    Console.WriteLine($"y = {y}");
}

MyClass obj = new MyClass();
obj.PrintMessage("Hello");
Console.ReadLine();
obj.Dispose(); // release all the resources allocated by the MyClass



public class MyClass : IDisposable
{
	public MyClass()
	{
		Console.WriteLine("Constructor Called");
	}

	public void PrintMessage(string msg)
	{
		Console.WriteLine($"Message = {msg}");
	}

	public void Dispose()
	{
		// Supress the Destructor (finalize() method) to be called
		// and will clean the Un-Managed Resource immedialy (No Finalization Q)
		 GC.SuppressFinalize(this);
	}

	~MyClass()
	{
		Console.WriteLine("Destructor is Called.....");
		Console.ReadLine();
	}
}

