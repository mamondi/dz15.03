using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Singleton instance1 = Singleton.Instance;
        instance1.PrintMessage("Повідомлення з першого екземпляра");

        Singleton instance2 = Singleton.Instance;
        instance2.PrintMessage("Повідомлення з другого екземпляра");
    }
}
