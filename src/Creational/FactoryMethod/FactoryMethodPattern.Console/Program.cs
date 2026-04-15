using FactoryMethodPattern.Console.BadExample;
using FactoryMethodPattern.Console.GoodExample;

Console.WriteLine("=== BAD EXAMPLE ===");

var badFactory = new PaymentFactoryBad();
var payment = badFactory.CreatePayment("CreditCard");

if (payment is CreditCardPayment cc)
{
    cc.Process();
}

Console.WriteLine("\n=== GOOD EXAMPLE ===");

var good = new PaymentProcessorGood();
good.Run();