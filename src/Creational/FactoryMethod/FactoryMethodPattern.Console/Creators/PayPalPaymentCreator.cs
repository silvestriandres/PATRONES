using FactoryMethodPattern.ConsoleApp.Products;

namespace FactoryMethodPattern.ConsoleApp.Creators;

public class PayPalPaymentCreator : PaymentCreator
{
    public override IPayment CreatePayment()
    {
        return new PayPalPayment();
    }
}