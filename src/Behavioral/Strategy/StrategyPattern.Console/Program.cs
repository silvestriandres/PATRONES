using StrategyPattern.ConsoleProject.BadExample;
using StrategyPattern.ConsoleProject.GoodExample;

Console.WriteLine("=== BAD EXAMPLE ===");

var bad = new PaymentProcessorBad();
bad.Run();

Console.WriteLine("\n=== GOOD EXAMPLE (DYNAMIC) ===");

var good = new PaymentProcessorGood();
good.Run();