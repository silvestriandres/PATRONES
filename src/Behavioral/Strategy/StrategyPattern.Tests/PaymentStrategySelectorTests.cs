using StrategyPattern.ConsoleProject.Domain.Enums;
using StrategyPattern.ConsoleProject.Helpers;
using StrategyPattern.ConsoleProject.Strategies;
using Xunit;

namespace StrategyPattern.Tests;

public class PaymentStrategySelectorTests
{
    [Fact]
    public void Should_Return_CreditCardStrategy()
    {
        var strategy = PaymentStrategySelector.GetStrategy(PaymentMethod.CreditCard);

        Assert.IsType<CreditCardPaymentStrategy>(strategy);
    }

    [Fact]
    public void Should_Return_PayPalStrategy()
    {
        var strategy = PaymentStrategySelector.GetStrategy(PaymentMethod.PayPal);

        Assert.IsType<PayPalPaymentStrategy>(strategy);
    }

    [Fact]
    public void Should_Return_CryptoStrategy()
    {
        var strategy = PaymentStrategySelector.GetStrategy(PaymentMethod.Crypto);

        Assert.IsType<CryptoPaymentStrategy>(strategy);
    }
}