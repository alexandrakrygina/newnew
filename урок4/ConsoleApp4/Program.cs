using ConsoleApp4;

public class Program
{
    public static void Main(string[] args)
    {
        counter Aboba = new counter();
        Handler1 Handler1 = new Handler1();
        Handler2 Handler2 = new Handler2();
        Aboba.OnCount += Handler1.Message;
        Aboba.OnCount += Handler2.Message;
        Aboba.LetsCount();
    }

}