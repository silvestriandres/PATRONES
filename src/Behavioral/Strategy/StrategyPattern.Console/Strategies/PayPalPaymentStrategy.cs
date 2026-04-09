using StrategyPattern.ConsoleProject.Domain.Interfaces;
using System;

namespace StrategyPattern.ConsoleProject.Strategies;

public class PayPalPaymentStrategy : IPaymentStrategy
{
	public void ProcessPayment(decimal amount)
	{
		Console.WriteLine($"Paid {amount} using PayPal");
	}
}