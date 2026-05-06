using FactoryMethodPattern.ConsoleApp.Products;

namespace FactoryMethodPattern.ConsoleApp.BadExample;

public class PaymentFactoryBad
{
    public IPayment CreatePayment(string method)
    {
        if (method == "CreditCard")
        {
            return new CreditCardPayment();
        }
        else if (method == "PayPal")
        {
            return new PayPalPayment();
        }

        throw new ArgumentException("Invalid payment method");
    }
}