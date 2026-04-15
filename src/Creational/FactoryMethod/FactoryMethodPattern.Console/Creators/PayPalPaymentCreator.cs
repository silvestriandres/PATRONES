using FactoryMethodPattern.Console.Products;

namespace FactoryMethodPattern.Console.Creators;

public class PayPalPaymentCreator : PaymentCreator
{
    public override IPayment CreatePayment()
    {
        return new PayPalPayment();
    }
}