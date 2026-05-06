namespace AbstractFactoryPattern.ConsoleApp.Products.Payment;

public class CreditCardPayment : IPayment
{
    public void Process()
    {
        System.Console.WriteLine("Processing Credit Card payment");
    }
}