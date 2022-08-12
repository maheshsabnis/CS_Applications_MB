using System.Threading;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Demo SImple Threading");
// Creating Thread and assigning Processes for Execution 
Thread T1 = new Thread(Increment);
Thread T2 = new Thread(Decrement);

// start threads
T1.Start();
// First execute T1
T1.Priority = ThreadPriority.Highest;
T2.Start();

// SOme logic  on Main Thread
for (int i = 0; i < 3; i++)
{
	Console.WriteLine($"Main Thread i = {i}");
}


Console.ReadLine(); 

// On T1 Thread

static void Increment()
{
	for (int i = 0; i < 10; i++)
	{
		Console.WriteLine($"Increment i = {i}");
	}
}
// On T2 Thread
static void Decrement()
{
	for (int i = 10; i >= 0; i--)
	{
		Console.WriteLine($"Decrement i = {i}");
		if (i == 5)
		{
			// Abort the T2 Thread
			// Thread.CurrentThread.Abort();
			Thread.Sleep(1000); // 1 Second
		}
	}
}