using AbstractFactoryPattern.ConsoleApp.Products.Receipt;

namespace AbstractFactoryPattern.ConsoleApp.Products.Receipt;

public class PayPalReceipt : IReceipt
{
    public void Generate()
    {
        System.Console.WriteLine("Generating PayPal receipt");
    }
}