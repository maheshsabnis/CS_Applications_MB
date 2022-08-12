using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AsyncDelegate
{
    public delegate double OperationHandler(double x, double y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Async Delegate");
            MyClass m = new MyClass();
            OperationHandler handler1 = new OperationHandler(m.Power);

            Console.WriteLine("Async");

            IAsyncResult ar = handler1.BeginInvoke(12, 5, null, null);
            while (!ar.IsCompleted)
            {
                Console.WriteLine("Do Something Else......");
            }
            double resule = handler1.EndInvoke(ar);
            Console.WriteLine($"Result after Async Call = {resule}");

            Console.ReadLine();
        }
    }



    public class MyClass
    {
        public double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}


