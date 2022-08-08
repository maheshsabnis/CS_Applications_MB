using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lets define Data Types
            int x, y, z;

            // Print message to accepr values for x and y
            Console.WriteLine("Enter value for x");
            // Read the Entered value
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for y");
            y = Convert.ToInt32(Console.ReadLine());

            // Process these values
            z = x + y;

            // Print Result
            Console.WriteLine($"z = {z}");

            Console.ReadLine(); 
        }
    }
}
