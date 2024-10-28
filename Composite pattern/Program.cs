using Composite_pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var paragraph1 = new Paragraph("Это параграф о безбилетном проезде.");
        var paragraph2 = new Paragraph("Это параграф о том, как инфоцыганить.");
        var paragraph3 = new Paragraph("Это параграф об обмане бабушек по телефону.");

        var section1 = new Section("Аферизм");
        section1.Add(paragraph1);
        section1.Add(paragraph2);

        var section2 = new Section("Мошеничество");
        section2.Add(paragraph3);

        var document = new Document();
        document.Add(section1);
        document.Add(section2);

        document.Display(); 
    }
}