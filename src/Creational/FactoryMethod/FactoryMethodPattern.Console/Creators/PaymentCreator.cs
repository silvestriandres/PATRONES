using FactoryMethodPattern.Console.Products;

namespace FactoryMethodPattern.Console.Creators;

public abstract class PaymentCreator
{
    public abstract IPayment CreatePayment();

    public void ProcessPayment()
    {
        var payment = CreatePayment();
        payment.Process();
    }
}