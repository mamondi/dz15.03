class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        ICarBuilder carBuilder = new CarBuilder();

        CarDirector director = new CarDirector(carBuilder);

        director.ConstructCar();

        Car car = carBuilder.GetCar();

        Console.WriteLine(car.ToString());
    }
}
