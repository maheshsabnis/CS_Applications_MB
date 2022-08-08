using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array with Max Length
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Print Original Array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Element ar {i}th index = {arr[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Sort");
            // This will change the original Array and Rearrange it
            Array.Sort(arr);
            Console.WriteLine("After Sort");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Element ar {i}th index = {arr[i]}");
            }




            Console.ReadLine();
        }
    }
}
