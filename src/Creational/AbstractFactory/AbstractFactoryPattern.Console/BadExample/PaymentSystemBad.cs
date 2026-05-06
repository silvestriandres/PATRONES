namespace AbstractFactoryPattern.ConsoleApp.BadExample;

public class PaymentSystemBad
{
    public void Process(string method)
    {
        if (method == "CreditCard")
        {
            var payment = new CreditCardPayment();
            payment.Process();

            var receipt = new CreditCardReceipt();
            receipt.Generate();
        }
        else if (method == "PayPal")
        {
            var payment = new PayPalPayment();
            payment.Process();

            var receipt = new PayPalReceipt();
            receipt.Generate();
        }
        else
        {
            Console.WriteLine("Invalid method");
        }
    }
}

// Payment
public class CreditCardPayment
{
    public void Process() => Console.WriteLine("Processing Credit Card payment");
}

public class PayPalPayment
{
    public void Process() => Console.WriteLine("Processing PayPal payment");
}

// Receipt
public class CreditCardReceipt
{
    public void Generate() => Console.WriteLine("Generating Credit Card receipt");
}

public class PayPalReceipt
{
    public void Generate() => Console.WriteLine("Generating PayPal receipt");
}