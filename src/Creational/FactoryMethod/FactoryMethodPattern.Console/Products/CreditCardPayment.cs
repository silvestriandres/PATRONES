namespace FactoryMethodPattern.Console.Products;

public class CreditCardPayment : IPayment
{
    public void Process()
    {
        Console.WriteLine("Processing credit card payment");
    }
}