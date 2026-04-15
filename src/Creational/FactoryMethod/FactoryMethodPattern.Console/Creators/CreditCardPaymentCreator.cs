using FactoryMethodPattern.Console.Products;

namespace FactoryMethodPattern.Console.Creators;

public class CreditCardPaymentCreator : PaymentCreator
{
    public override IPayment CreatePayment()
    {
        return new CreditCardPayment();
    }
}