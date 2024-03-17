using System;

public interface ICarBuilder
{
    void SetBodyType();
    void SetEngineType();
    void SetColor();
    void SetYear();
    Car GetCar();
}

public class CarDirector
{
    private ICarBuilder carBuilder;

    public CarDirector(ICarBuilder builder)
    {
        carBuilder = builder;
    }

    public void ConstructCar()
    {
        carBuilder.SetBodyType();
        carBuilder.SetEngineType();
        carBuilder.SetColor();
        carBuilder.SetYear();
    }
}
