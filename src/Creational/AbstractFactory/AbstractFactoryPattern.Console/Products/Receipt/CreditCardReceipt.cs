using AbstractFactoryPattern.ConsoleApp.Products.Receipt;

namespace AbstractFactoryPattern.ConsoleApp.Products.Receipt;

public class CreditCardReceipt : IReceipt
{
    public void Generate()
    {
        System.Console.WriteLine("Generating Credit Card receipt");
    }
}