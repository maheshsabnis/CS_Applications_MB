using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "C# is a Greate Language, introducted in .NET FRamework 1.0";
            // Traditional Concatination
            Console.WriteLine("Length of " + str + " = " + str.Length);
            // String Interpolation aka Template Strings
            Console.WriteLine();
            Console.WriteLine($"Length of {str} is = {str.Length}");
            // Using for..loop

            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            // Using For-Each Loop
            foreach(char c in str)
            {
                if (Char.IsDigit(c))
                {
                    Console.WriteLine(c);
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Upper of {str} is = {str.ToUpper()}");
            Console.WriteLine($"Lower of {str} is = {str.ToLower()}");
            Console.WriteLine($"{str.Substring(3,15)}");

            Console.ReadLine();
        }
    }
}
