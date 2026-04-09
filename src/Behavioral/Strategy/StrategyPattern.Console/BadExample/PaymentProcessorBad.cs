using System;
namespace StrategyPattern.ConsoleProject.BadExample
{

    public class PaymentProcessorBad
    {
        public void Process(string method, decimal amount)
        {
            if (method == "CreditCard")
            {
                Console.WriteLine($"Paid {amount} using Credit Card");
            }
            else if (method == "PayPal")
            {
                Console.WriteLine($"Paid {amount} using PayPal");
            }
            else if (method == "Crypto")
            {
                Console.WriteLine($"Paid {amount} using Crypto");
            }
            else
            {
                Console.WriteLine("Unknown payment method");
            }
        }
    }
}