public class EmailNotification : Notification
{
     // Ota classning constructoriga qiymatlarni uzatadi
    public EmailNotification(string recipient, string message)
        : base(recipient, message)
    {
    }

    // Ota classdagi Send() metodini qayta yozadi
    public override void Send()
    {
        Console.WriteLine("Kanal: Email");
        Console.WriteLine("Oluvchi: " + Recipient);
        Console.WriteLine("Xabar: " + Message);
        Console.WriteLine("Email yuborildi.");
        Console.WriteLine("--------------------");
    }
}