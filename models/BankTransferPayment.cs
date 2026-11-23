public class BankTransferPayment : Payment
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Bank orqali tulandi:{amount}");
    }
}