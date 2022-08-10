// See https://aka.ms/new-console-template for more information
Console.WriteLine("Overloading");
MyClass my = new MyClass();
my.M1();
my.M1("Mahesh");
my.M2(10, 20);
my.M2(10, 20, 30);
my.M3(10, "Mahesh");
my.M3("Mahesh", 10);


Console.ReadLine();

public class MyClass
{
    public void M1()
    {
        Console.WriteLine("No Parameters");
    }
    public void M1(string  s)
    {
        Console.WriteLine($"With Parameters {s}");
    }

    public void M2(int x,int y)
    {
        Console.WriteLine($"2 integers {x} {y}");
    }
    public void M2(int x, int y,int z)
    {
        Console.WriteLine($"3 integers {x} {y} {z}");
    }

    public void M3(int x, string y)
    {
        Console.WriteLine($"First int and Second string {x} {y}");
    }

    public void M3(string y, int x)
    {
        Console.WriteLine($"First string and Int string {y} {x}");
    }
}
