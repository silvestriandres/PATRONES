namespace StrategyPattern.ConsoleProject.Domain.Interfaces;

public interface IPaymentStrategy
{
    void ProcessPayment(decimal amount);
}