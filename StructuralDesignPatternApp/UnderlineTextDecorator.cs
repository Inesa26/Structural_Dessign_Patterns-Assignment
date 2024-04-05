namespace StructuralDesignPatternApp
{
    public class UnderlineTextDecorator : TextDecorator
    {
        public UnderlineTextDecorator(ITextComponent textComponent) : base(textComponent) { }
        public override string Apply()
        {
            return "[Underline]" + _textComponent.Apply() + "[/Underline]";
        }
    }
}
