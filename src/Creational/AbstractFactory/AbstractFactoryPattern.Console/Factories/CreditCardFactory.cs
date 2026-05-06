using AbstractFactoryPattern.ConsoleApp.Products.Payment;
using AbstractFactoryPattern.ConsoleApp.Products.Receipt;

namespace AbstractFactoryPattern.ConsoleApp.Factories;

public class CreditCardFactory : IPaymentFactory
{
    public IPayment CreatePayment()
    {
        return new CreditCardPayment();
    }

    public IReceipt CreateReceipt()
    {
        return new CreditCardReceipt();
    }
}