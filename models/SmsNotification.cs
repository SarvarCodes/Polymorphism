public class SmsNotification:Notification
{
     // Ota classning constructoriga qiymatlarni uzatadi
    public SmsNotification(string recipient, string message)
        : base(recipient, message){}

    // Ota classdagi Send() metodini qayta yozadi
    public override void Send()
    {
        Console.WriteLine("Kanal: SMS");
        Console.WriteLine("Oluvchi: " + Recipient);
        Console.WriteLine("Xabar: " + Message);
        Console.WriteLine("SMS yuborildi.");
    }
}