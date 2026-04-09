using StrategyPattern.ConsoleProject.Context;
using StrategyPattern.ConsoleProject.Strategies;

namespace StrategyPattern.ConsoleProject.GoodExample;

public class PaymentProcessorGood
{
    public void Run()
    {
        var context = new PaymentContext(new CreditCardPaymentStrategy());
        context.ExecutePayment(100);

        context.SetStrategy(new PayPalPaymentStrategy());
        context.ExecutePayment(200);

        context.SetStrategy(new CryptoPaymentStrategy());
        context.ExecutePayment(300);
    }
}