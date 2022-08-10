// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Derive d = new Derive();

d.PrintMessage();
d.ShowMessage("Hello");
Console.WriteLine();
// Lets Do the Same thig using the Base Class instance

Base b = new Base();
b.PrintMessage(); // Access only the base class Method
Console.WriteLine();
// Lets Create an instance of the Base Class Reference using the Derive class
Base b1 = new Derive(); // This will call Constructors of both classes
b1.PrintMessage(); // Access the base class method 

// This will be an erorr because although the instance is of the Base is created using Derive
// the method ShowMessage() is physically part of the Derive class so Base classs instance cannot call it
// b1.ShowMessage("I am Derive class method"); 

// Better TypeCast is and try to access it

((Derive)b1).ShowMessage("Hello, I am Derive class "); // This will Work


// Let's do it reverse
// The Derive class instance using Base Class is not allowed 
// Derive d1 = new Base(); // Not Allowed 
// Derive d1 = (Derive)new Base(); // This will Compiled but not necessary it is Foolish



Console.ReadLine();


public class Base
{
    public Base()
    {
        Console.WriteLine("The Base classs Constructor called");
    }
    public void PrintMessage()
    {
        Console.WriteLine("Base Print Message");
    }
    // Not Possible
    // public abstract string MyMessage();
}

public class Derive : Base
{
    public Derive()
    {
        Console.WriteLine("The Derive classs Constructor called");
    }
    public void ShowMessage(string msg)
    { 
        Console.WriteLine($"Derive Message to be Shown is = {msg}");
    }
}