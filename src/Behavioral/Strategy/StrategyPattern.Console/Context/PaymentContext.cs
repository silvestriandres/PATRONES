using StrategyPattern.ConsoleProject.Domain.Interfaces;

namespace StrategyPattern.ConsoleProject.Context;

public class PaymentContext
{
    private IPaymentStrategy _strategy;

    public PaymentContext(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecutePayment(decimal amount)
    {
        _strategy.ProcessPayment(amount);
    }
}