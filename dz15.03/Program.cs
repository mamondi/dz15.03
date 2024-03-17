using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        MebleFactory artDecoFactory = new ArtDecoFactory();
        Console.WriteLine("Магазин меблів у стилі Ар-Деко:");
        artDecoFactory.DisplayMeble();

        MebleFactory victorianFactory = new VictorianFactory();
        Console.WriteLine("\nМагазин меблів у вікторіанському стилі:");
        victorianFactory.DisplayMeble();

        MebleFactory modernFactory = new ModernFactory();
        Console.WriteLine("\nМагазин меблів у стилі Модерн:");
        modernFactory.DisplayMeble();
    }
}
