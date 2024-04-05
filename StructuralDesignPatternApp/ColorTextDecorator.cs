namespace StructuralDesignPatternApp
{
    public class ColorTextDecorator : TextDecorator
    {
        private Color _color;

        public ColorTextDecorator(ITextComponent textComponent, Color color) : base(textComponent)
        {

            _color = color;
        }

        public override string Apply()
        {
            return $"[{_color}]" + _textComponent.Apply() + $"[{_color}]";
        }
    }
}

