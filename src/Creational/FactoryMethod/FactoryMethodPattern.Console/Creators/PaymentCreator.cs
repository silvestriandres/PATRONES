using FactoryMethodPattern.ConsoleApp.Products;

namespace FactoryMethodPattern.ConsoleApp.Creators;

public abstract class PaymentCreator
{
    public abstract IPayment CreatePayment();

    public void ProcessPayment()
    {
        var payment = CreatePayment();
        payment.Process();
    }
}