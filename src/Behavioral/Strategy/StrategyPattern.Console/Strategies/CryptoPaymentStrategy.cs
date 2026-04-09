using StrategyPattern.ConsoleProject.Domain.Interfaces;
using System;

namespace StrategyPattern.ConsoleProject.Strategies;

public class CryptoPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Paid {amount} using Crypto");
    }
}