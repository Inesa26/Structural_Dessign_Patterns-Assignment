namespace StructuralDesignPatternApp
{
    public class BoldTextDecorator : TextDecorator
    {
        public BoldTextDecorator(ITextComponent textComponent) : base(textComponent) { }
        public override string Apply()
        {
            return "[Bold]" + _textComponent.Apply() + "[/Bold]";
        }
    }
}

