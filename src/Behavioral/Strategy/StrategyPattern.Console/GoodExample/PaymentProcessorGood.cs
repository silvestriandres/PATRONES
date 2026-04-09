using StrategyPattern.ConsoleProject.Context;
using StrategyPattern.ConsoleProject.Domain.Enums;
using StrategyPattern.ConsoleProject.Helpers;
using System;

namespace StrategyPattern.ConsoleProject.GoodExample;

public class PaymentProcessorGood
{
    public void Run()
    {
        Console.WriteLine("""
        Select payment method:
        - CreditCard
        - PayPal
        - Crypto
        """);

        var input = Console.ReadLine();

        if (!Enum.TryParse<PaymentMethod>(input, true, out var method))
        {
            Console.WriteLine("Invalid payment method");
            return;
        }

        var strategy = PaymentStrategySelector.GetStrategy(method);

        var context = new PaymentContext(strategy);
        context.ExecutePayment(150);
    }
}