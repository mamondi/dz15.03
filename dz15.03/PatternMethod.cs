using System;

abstract class DocumentPrototype
{
    public string Title { get; set; }
    public abstract DocumentPrototype Clone();
    public abstract void Edit();
}
