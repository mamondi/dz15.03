using System;

interface IMebleFactory
{
    ISofa CreateSofa();
    IChair CreateChair();
    ITable CreateTable();
}

interface ISofa
{
    string GetName();
}

interface IChair
{
    string GetName();
}

interface ITable
{
    string GetName();
}

abstract class MebleFactory
{
    public abstract ISofa CreateSofa();
    public abstract IChair CreateChair();
    public abstract ITable CreateTable();

    public void DisplayMeble()
    {
        ISofa sofa = CreateSofa();
        IChair chair = CreateChair();
        ITable table = CreateTable();

        Console.WriteLine("Меблі:");
        Console.WriteLine(sofa.GetName());
        Console.WriteLine(chair.GetName());
        Console.WriteLine(table.GetName());
    }
}
