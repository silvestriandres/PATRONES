namespace FactoryMethodPattern.Console.Products;

public class PayPalPayment : IPayment
{
    public void Process()
    {
        Console.WriteLine("Processing PayPal payment");
    }
}