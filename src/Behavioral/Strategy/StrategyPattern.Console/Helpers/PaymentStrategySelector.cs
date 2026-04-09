using StrategyPattern.ConsoleProject.Domain.Enums;
using StrategyPattern.ConsoleProject.Domain.Interfaces;
using StrategyPattern.ConsoleProject.Strategies;
using System;

namespace StrategyPattern.ConsoleProject.Helpers;

public static class PaymentStrategySelector
{
    public static IPaymentStrategy GetStrategy(PaymentMethod method)
    {
        return method switch
        {
            PaymentMethod.CreditCard => new CreditCardPaymentStrategy(),
            PaymentMethod.PayPal => new PayPalPaymentStrategy(),
            PaymentMethod.Crypto => new CryptoPaymentStrategy(),
            _ => throw new ArgumentOutOfRangeException(nameof(method), "Invalid payment method")
        };
    }
}