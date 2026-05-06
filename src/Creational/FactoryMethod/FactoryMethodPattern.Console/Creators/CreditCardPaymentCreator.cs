using FactoryMethodPattern.ConsoleApp.Products;

namespace FactoryMethodPattern.ConsoleApp.Creators;

public class CreditCardPaymentCreator : PaymentCreator
{
    public override IPayment CreatePayment()
    {
        return new CreditCardPayment();
    }
}