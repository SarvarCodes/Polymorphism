//-1-// task Notification

// Email va SMS obyektlarini yaratamiz
Notification[] notifications =
{
    new EmailNotification("user@gmail.com", "Salom! Email xabari."),
    new SmsNotification("+998941920808", "Salom! SMS xabari.")
};

// Massivdagi barcha obyektlarni aylanib chiqamiz
foreach (Notification notification in notifications)
{
    // Har bir obyektning o'z Send() metodi ishlaydi
    notification.Send();
}

//-2-// task Payment

Payment[] payments =  // 3 ta xarxil tulov turi obekti
{
    new CardPayment(),
    new BankTransferPayment(),
    new WalletPayment()
};

foreach (Payment payment in payments) //hamma tulov obektlarini aylanib chiqadi
{
    payment.Pay(50000);
}

//-3-// task metod overloading

ReportPrinter report = new ReportPrinter;
report.Print("oylik xisobot");

report.Print("1 oylik xisobot",12500);