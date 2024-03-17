class ArtDecoFactory : MebleFactory
{
    public override ISofa CreateSofa()
    {
        return new ArtDecoSofa();
    }

    public override IChair CreateChair()
    {
        return new ArtDecoChair();
    }

    public override ITable CreateTable()
    {
        return new ArtDecoTable();
    }
}

class VictorianFactory : MebleFactory
{
    public override ISofa CreateSofa()
    {
        return new VictorianSofa();
    }

    public override IChair CreateChair()
    {
        return new VictorianChair();
    }

    public override ITable CreateTable()
    {
        return new VictorianTable();
    }
}

class ModernFactory : MebleFactory
{
    public override ISofa CreateSofa()
    {
        return new ModernSofa();
    }

    public override IChair CreateChair()
    {
        return new ModernChair();
    }

    public override ITable CreateTable()
    {
        return new ModernTable();
    }
}

class ArtDecoSofa : ISofa
{
    public string GetName()
    {
        return "Ар-Деко диван";
    }
}

class ArtDecoChair : IChair
{
    public string GetName()
    {
        return "Ар-Деко крісло";
    }
}

class ArtDecoTable : ITable
{
    public string GetName()
    {
        return "Ар-Деко столик";
    }
}

class VictorianSofa : ISofa
{
    public string GetName()
    {
        return "Вікторіанський диван";
    }
}

class VictorianChair : IChair
{
    public string GetName()
    {
        return "Вікторіанське крісло";
    }
}

class VictorianTable : ITable
{
    public string GetName()
    {
        return "Вікторіанський столик";
    }
}

class ModernSofa : ISofa
{
    public string GetName()
    {
        return "Модерн диван";
    }
}

class ModernChair : IChair
{
    public string GetName()
    {
        return "Модерне крісло";
    }
}

class ModernTable : ITable
{
    public string GetName()
    {
        return "Модерний столик";
    }
}
