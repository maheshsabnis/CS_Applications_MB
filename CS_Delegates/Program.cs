// See https://aka.ms/new-console-template for more information


namespace MyNamespace
{
    // 1. Declare a Delegate at Namespace level
    public delegate double OperationHandler(double x, double y);
    
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using a Delegate");
            Console.WriteLine("Thye Caller App");

            Console.WriteLine();
            Console.WriteLine("1. A Traditional Method call from the Class");
            MyClass m = new MyClass();
            double resPower = m.Power(12, 4);
            Console.WriteLine($"4 raised to 12 = {resPower}");

            // Using the delegate

            // 2. Declare a Delegate Type Instance (Proxy) and pass a method address to it
            OperationHandler handler1 = new OperationHandler(m.Power);
            // 3. Invoke the method by passing parameters to delegate instance
            resPower = handler1.Invoke(5,10);
            Console.WriteLine($"Using Delegate 10 raised to 5 = {resPower}");
            Console.WriteLine();
           


            Console.WriteLine();
            Console.WriteLine("C# 2.0 use of delegate by directly passing an implementation to it.");
            Console.WriteLine("An Anonymous Method i.e. a method w/o any name");

            OperationHandler handler2 = delegate (double a, double b) { return a * b; };
            resPower = handler2.Invoke(456, 200);
            Console.WriteLine($"result = {resPower}");

            Console.WriteLine();
            Console.WriteLine("Pass the handler2 to ProcessValues() Method");
            ProcessValues(handler2);
            Console.WriteLine("Using C# 3.0 Lambda Expression");
            ProcessValues((a, b) => { return (a * a) + 2 * a * b + (b * b); });
            Console.WriteLine();
            List<string> lstNames = new List<string>() { "Ram", "Shankar", "Ramesh", "Vivek", "Satish", "Mukesh", "Sandeep", "Vinay", "Mahesh", "Tushar", "Tejas", "Suprotim", "Vikram", "Subodh", "Pravin", "Amit", "Ajit", "Anhijit", "Sharad", "Sanjay", "Vijay", "Abhay", "Vilas", "Anil", "Nandu", "Jaywant", "Shyam" };

            // Names wjith length more than 6
            Console.WriteLine("Length greater than 6");
            var res1 = lstNames.Where(n => n.Length > 6).ToList();
            Print(res1);
            Console.WriteLine();
            Console.WriteLine("Sort by Name");
            var res2 = lstNames.OrderBy(n=>n);
            Print(res2);
            Console.WriteLine("Sort by Length");
            var res3 = lstNames.OrderBy(n=>n.Length);
            Print(res3);    

           
            Console.ReadLine();
        }
        /// <summary>
        /// A Method with delegate as input parameter
        /// </summary>
        /// <param name="handler"></param>
        static void ProcessValues(OperationHandler handler)
        {
            Console.WriteLine($"Result after processing values = {handler(400,500)}");
        }

        static void Print(IEnumerable<string> values)
        {
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }
    }
}


 



public class MyClass
{
    public double Power(double x, double y)
    {
        return Math.Pow(x,y);
    }
}