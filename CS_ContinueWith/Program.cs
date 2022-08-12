using System.Threading.Tasks;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Continue Tasks");

SetTheContinueExecution();

SetTheContinueExecutionWithValues();


Console.WriteLine("Back to Main Thread");



for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"MAin Thread i = {i}");
}
Console.ReadLine();


static void Op1()
{
    Console.WriteLine("Operation 1");
}

static void Op2()
{
    Console.WriteLine("Operation 2");
}

static void Op3()
{
    Console.WriteLine("Operation 3");
}

static void SetTheContinueExecution()
{
    Task task = Task.Factory.StartNew(()=>Op1())
            .ContinueWith(delegate { Op2(); } )
            .ContinueWith(delegate { Op3(); });
}


static int Op11(int x,int y)
{
    Console.WriteLine("Operation 11");
    return x + y;
}

static int Op12(int z)
{
    Console.WriteLine("Operation 12");

    return z * z;
}


static void SetTheContinueExecutionWithValues()
{
    //Task<int> task = Task.Factory.StartNew(() => { return Op11(10, 20); })
    //        .ContinueWith<int>(delegate { return Op12(100); });


    Task<int> task = Task.Factory.StartNew(() => { return Op11(10, 20); })  // Get result from Task 1
           .ContinueWith<int>((res) => { return res.Result + Op12(100); } ); // Use the Result from Task 1 to Task 2

    Console.WriteLine($"With Return Values {task.Result}");
}
