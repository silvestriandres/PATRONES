using StrategyPattern.ConsoleProject.Context;
using StrategyPattern.ConsoleProject.Helpers;
using System;

namespace StrategyPattern.ConsoleProject.GoodExample;

public class PaymentProcessorGood
{
    public void Run()
    {
        Console.WriteLine("Enter payment method (CreditCard, PayPal, Crypto):");
        var method = Console.ReadLine();

        try
        {
            var strategy = PaymentStrategySelector.GetStrategy(method!);

            var context = new PaymentContext(strategy);
            context.ExecutePayment(150);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}