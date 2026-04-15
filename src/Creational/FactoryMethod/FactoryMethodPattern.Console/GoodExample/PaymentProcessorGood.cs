using FactoryMethodPattern.Console.Creators;

namespace FactoryMethodPattern.Console.GoodExample;

public class PaymentProcessorGood
{
    public void Run()
    {
        PaymentCreator creator;

        Console.WriteLine("Select payment method (CreditCard, PayPal):");
        var input = Console.ReadLine();

        if (input?.ToLower() == "creditcard")
        {
            creator = new CreditCardPaymentCreator();
        }
        else if (input?.ToLower() == "paypal")
        {
            creator = new PayPalPaymentCreator();
        }
        else
        {
            Console.WriteLine("Invalid payment method");
            return;
        }

        creator.ProcessPayment();
    }
}