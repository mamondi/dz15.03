using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        ITransport landTransport = TransportFactory.CreateTransport("land");
        landTransport.Deliver();

        ITransport airTransport = TransportFactory.CreateTransport("air");
        airTransport.Deliver();

        ITransport seaTransport = TransportFactory.CreateTransport("sea");
        seaTransport.Deliver();
    }
}
