// See https://aka.ms/new-console-template for more information
Console.WriteLine("USing Miltiple Interfaces");
I1 i1 = new MyClass();

Console.WriteLine($" SImpe Add {i1.Add(2,3)}");

I2 i2 = new MyClass();

Console.ReadLine();
Console.WriteLine($" SImpe Add with Square {i2.Add(2, 3)}");

public interface I1
{
    int Add(int x, int y);
}


public interface I2
{
    int Add(int x, int y);
}


public class MyClass : I1, I2
{
    int I1.Add(int x, int y)
    {
        return x + y;   
    }

    int I2.Add(int x, int y)
    {
        return (x * x) + 2 * x * y + (y * y);
    }
}