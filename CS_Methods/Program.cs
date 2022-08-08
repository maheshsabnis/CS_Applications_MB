using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Methods
{

    /// <summary>
    /// All methods in this call MUST be static
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMessage();
            ShowMessage("C# Method Call");
            int result = Add(300,40);
            Console.WriteLine($"The Result = {result}");

            Console.WriteLine("Enter x");
            uint x = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Enter y");
            uint y = Convert.ToUInt32(Console.ReadLine());

            uint resMulti = Multiply(x, y);
            Console.WriteLine($"Multiplication Result = {resMulti}");

            double resDivision = Division(x,y);
            Console.WriteLine($"Division Result = {resDivision}");

            Console.ReadLine();
        }

        /// <summary>
        /// Method that do-not accept any data an does not return anything 
        /// </summary>
        static void PrintMessage()
        {
            Console.WriteLine("The One-Way Method call");
        }

        /// <summary>
        /// A Method that accepts a Parameter
        /// The "msg" is a 'Formal Parameter'
        /// </summary>
        /// <param name="msg"></param>
        static void ShowMessage(string msg)
        {
            Console.WriteLine($"Received Message {msg}");
        }
        /// <summary>
        /// The x and y are formal Parameters
        /// This method returns the integer, this is a Two-Way method 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static int Add(int x,int y)
        {
            int res = x + y;
            return res;
        }

        static uint Multiply(uint x, uint y)
        {
            uint res = x * y;
            return res;
        }


        static double Division(uint x, uint y)
        {
            // Casted x as Double
            double res = (double) x / y;
            return res;
        }
    }
}
