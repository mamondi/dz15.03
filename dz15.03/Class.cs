class TextDocumentPrototype : DocumentPrototype
{
    public override DocumentPrototype Clone()
    {
        return (TextDocumentPrototype)this.MemberwiseClone();
    }

    public override void Edit()
    {
        Console.WriteLine($"Редагуємо текстовий документ \"{Title}\"");
    }
}

class PresentationPrototype : DocumentPrototype
{
    public override DocumentPrototype Clone()
    {
        return (PresentationPrototype)this.MemberwiseClone();
    }

    public override void Edit()
    {
        Console.WriteLine($"Редагуємо презентацію \"{Title}\"");
    }
}

class SpreadsheetPrototype : DocumentPrototype
{
    public override DocumentPrototype Clone()
    {
        return (SpreadsheetPrototype)this.MemberwiseClone();
    }

    public override void Edit()
    {
        Console.WriteLine($"Редагуємо таблицю \"{Title}\"");
    }
}
