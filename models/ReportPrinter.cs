public class PeportPrinter
{
    public void priter(string title)
    {
        Console.WriteLine(title);
    }
    public void Print(string title,decimal total)
    {
        Console.WriteLine($"{title},{total}");
    }
}