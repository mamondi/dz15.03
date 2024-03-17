using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        DocumentPrototype textPrototype = new TextDocumentPrototype { Title = "Текстовий документ" };
        DocumentPrototype presentationPrototype = new PresentationPrototype { Title = "Презентація" };
        DocumentPrototype spreadsheetPrototype = new SpreadsheetPrototype { Title = "Таблиця" };

        DocumentPrototype clonedTextDoc = textPrototype.Clone();
        DocumentPrototype clonedPresentation = presentationPrototype.Clone();
        DocumentPrototype clonedSpreadsheet = spreadsheetPrototype.Clone();

        clonedTextDoc.Edit();
        clonedPresentation.Edit();
        clonedSpreadsheet.Edit();
    }
}
