namespace AbstractFactoryPattern.ConsoleApp.Products.Payment;

public class PayPalPayment : IPayment
{
    public void Process()
    {
        System.Console.WriteLine("Processing PayPal payment");
    }
}