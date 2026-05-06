using FactoryMethodPattern.ConsoleApp.Creators;

namespace FactoryMethodPattern.ConsoleApp.GoodExample;

public class PaymentProcessorGood
{
    public void Run()
    {
        PaymentCreator creator;

        System.Console.WriteLine("Select payment method (CreditCard, PayPal):");
        var input = System.Console.ReadLine();

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
            System.Console.WriteLine("Invalid payment method");
            return;
        }

        creator.ProcessPayment();
    }
}