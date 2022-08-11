// See https://aka.ms/new-console-template for more information
Console.WriteLine("Demo Extension Method");

BasicMath m = new BasicMath();
Console.WriteLine($"Add = {m.Add(10,20)}");
Console.WriteLine();
Console.WriteLine($"Add Square with Extension is = {m.AddSquare(100,200)}");

string message = "Extension Methods are superb.";

Console.WriteLine($"Reverse of {message} is = {message.ReverseString()}");


Console.ReadLine();



public sealed class BasicMath
{
    public int Add(int x,int y)
    {
        return x + y;
    }
}


public static class MathExtensions
{
    /// <summary>
    /// The 'this' is an instance of Current Active class i.e. MathExtensions
    /// this BasicMath m, means that, to call the AddSquare() method, the CLR will
    /// use an instance of BasicMath and the 'this' will be replaced using an instance of 
    /// BasicMath
    /// </summary>
    /// <param name="math"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public static int AddSquare(this BasicMath math, int x,int y)
    {
        return (x * x) + 2 * x * y + (y * y);
    }

    public static string ReverseString(this string str)
    {
        string result = string.Empty;
        for (int i = str.Length -1; i >= 0; i--)
        {
            result += str[i];
        }
        return result;
    }
}