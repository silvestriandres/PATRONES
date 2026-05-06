using AbstractFactoryPattern.ConsoleApp.BadExample;
using AbstractFactoryPattern.ConsoleApp.GoodExample;

Console.WriteLine("=== BAD EXAMPLE ===");

var bad = new PaymentSystemBad();
bad.Process("CreditCard");

Console.WriteLine("\n=== GOOD EXAMPLE ===");

var good = new PaymentProcessorGood();
good.Run();