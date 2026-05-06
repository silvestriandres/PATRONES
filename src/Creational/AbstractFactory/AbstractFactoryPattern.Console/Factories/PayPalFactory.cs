using AbstractFactoryPattern.ConsoleApp.Products.Payment;
using AbstractFactoryPattern.ConsoleApp.Products.Receipt;

namespace AbstractFactoryPattern.ConsoleApp.Factories;

public class PayPalFactory : IPaymentFactory
{
    public IPayment CreatePayment()
    {
        return new PayPalPayment();
    }

    public IReceipt CreateReceipt()
    {
        return new PayPalReceipt();
    }
}