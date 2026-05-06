using StrategyPattern.ConsoleProject.Context;
using StrategyPattern.ConsoleProject.Domain.Interfaces;
using Xunit;

namespace StrategyPattern.Tests;

public class PaymentContextTests
{
    private class FakeStrategy : IPaymentStrategy
    {
        public bool WasCalled { get; private set; }

        public void ProcessPayment(decimal amount)
        {
            WasCalled = true;
        }
    }

    [Fact]
    public void Should_Execute_Strategy()
    {
        var fake = new FakeStrategy();
        var context = new PaymentContext(fake);

        context.ExecutePayment(100);

        Assert.True(fake.WasCalled);
    }
}