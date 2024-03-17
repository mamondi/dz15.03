using System;

class LandTransport : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Товар доставлено на суші.");
    }
}

class AirTransport : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Товар доставлено повітрям.");
    }
}

class SeaTransport : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Товар доставлено морем.");
    }
}

class TransportFactory
{
    public static ITransport CreateTransport(string transportType)
    {
        switch (transportType.ToLower())
        {
            case "land":
                return new LandTransport();
            case "air":
                return new AirTransport();
            case "sea":
                return new SeaTransport();
            default:
                throw new ArgumentException("Невідомий тип транспорту");
        }
    }
}
