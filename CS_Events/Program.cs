using CS_Events;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Using Events");

Banking bank = new Banking(80000);

// Subscribe to EventListener to receive Notification
// 
EventListener listener = new EventListener(bank);

bank.Deposit(70000);

Console.WriteLine($"Net Balance after Deposit = {bank.GetBalance()}");

bank.Withdrawal(145000);

Console.WriteLine($"Net Balance after Withdrawal = {bank.GetBalance()}");



Console.ReadLine();
