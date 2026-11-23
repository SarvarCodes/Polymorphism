public class CardPayment:Payment
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Plastik karta orqali tulandi: {amount}");
    }
}