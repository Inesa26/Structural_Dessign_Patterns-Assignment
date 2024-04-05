namespace StructuralDesignPatternApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var textComponent = new TextComponent("Hello World!");
            Console.WriteLine("Text Component:");
            Console.WriteLine(textComponent.Apply());

            var italicText = new ItalicTextDecorator(textComponent);
            Console.WriteLine("\nItalic Text:");
            Console.WriteLine(italicText.Apply());

            var removeItalic = italicText.Remove<ItalicTextDecorator>();
            Console.WriteLine("\nText Component without Italic:");
            Console.WriteLine(removeItalic.Apply());

            var boldItalicText = new BoldTextDecorator(italicText);
            Console.WriteLine("\nBold and Italic Text:");
            Console.WriteLine(boldItalicText.Apply());

            var removeItalic2 = boldItalicText.Remove<ItalicTextDecorator>();
            Console.WriteLine("\nBold Text Component without Italic:");
            Console.WriteLine(removeItalic2.Apply());

            var colorText = new ColorTextDecorator(removeItalic2, Color.Purple);
            Console.WriteLine("\nColored Bold Text:");
            Console.WriteLine(colorText.Apply());

            var removeBold = colorText.Remove<BoldTextDecorator>();
            Console.WriteLine("\nColor TextComponent without Bold:");
            Console.WriteLine(removeBold.Apply());

        }
    }
}

