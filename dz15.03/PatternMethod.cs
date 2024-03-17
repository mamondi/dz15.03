using System;

public sealed class Singleton
{
    private static Singleton instance;
    private static readonly object lockObject = new object();

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                    Console.WriteLine("Створено новий екземпляр Singleton.");
                }
            }
            return instance;
        }
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}