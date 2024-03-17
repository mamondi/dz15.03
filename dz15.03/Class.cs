public class Car
{
    public string BodyType { get; set; }
    public string EngineType { get; set; }
    public string Color { get; set; }
    public int Year { get; set; }

    public override string ToString()
    {
        return $"Автомобіль {Year} року, кузов: {BodyType}, двигун: {EngineType}, колір: {Color}";
    }
}


public class CarBuilder : ICarBuilder
{
    private Car car;

    public CarBuilder()
    {
        car = new Car();
    }

    public void SetBodyType()
    {
        car.BodyType = "Седан";
    }

    public void SetEngineType()
    {
        car.EngineType = "Бензиновий";
    }

    public void SetColor()
    {
        car.Color = "Чорний";
    }

    public void SetYear()
    {
        car.Year = 2023;
    }

    public Car GetCar()
    {
        return car;
    }
}
