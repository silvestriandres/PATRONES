using StrategyPattern.ConsoleProject.Domain.Interfaces;
using StrategyPattern.ConsoleProject.Strategies;
using System;

namespace StrategyPattern.ConsoleProject.Helpers;

public static class PaymentStrategySelector
{
    public static IPaymentStrategy GetStrategy(string method)
    {
        return method.ToLower() switch
        {
            "creditcard" => new CreditCardPaymentStrategy(),
            "paypal" => new PayPalPaymentStrategy(),
            "crypto" => new CryptoPaymentStrategy(),
            _ => throw new ArgumentException("Invalid payment method")
        };
    }
}