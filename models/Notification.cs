public class Notification
{
    public string Recipient { get; set; } //sms kimga yuboriliwi saqlanadi

    public string Message { get; set; } // sms matni saqlanadi

    public Notification(string recipient, string message) //recipient va massage qiymatini qabul qiladi
    {
        Recipient = recipient;
        Message = message;
    }

    public virtual void Send() // virtual bola classlarda bu metodni override qilishga ruxsat beradi 
    {
        Console.WriteLine("Bildirishnoma yuborildi.");
    }
}