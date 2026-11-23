public class WalletPayment : Payment
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Elektron kawilokdan tulov qilindi: {amount}");
    }
}