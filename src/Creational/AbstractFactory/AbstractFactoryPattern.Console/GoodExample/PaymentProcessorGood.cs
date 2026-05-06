using AbstractFactoryPattern.ConsoleApp.Factories;

namespace AbstractFactoryPattern.ConsoleApp.GoodExample;

public class PaymentProcessorGood
{
    public void Run()
    {
        Console.WriteLine("""
        Select payment method:
        - CreditCard
        - PayPal
        """);

        var input = Console.ReadLine();

        IPaymentFactory factory;

        if (input?.ToLower() == "creditcard")
        {
            factory = new CreditCardFactory();
        }
        else if (input?.ToLower() == "paypal")
        {
            factory = new PayPalFactory();
        }
        else
        {
            System.Console.WriteLine("Invalid method");
            return;
        }

        var payment = factory.CreatePayment();
        var receipt = factory.CreateReceipt();

        payment.Process();
        receipt.Generate();
    }
}