using AbstractFactoryPattern.ConsoleApp.Products.Payment;
using AbstractFactoryPattern.ConsoleApp.Products.Receipt;

namespace AbstractFactoryPattern.ConsoleApp.Factories;

public interface IPaymentFactory
{
    IPayment CreatePayment();
    IReceipt CreateReceipt();
}