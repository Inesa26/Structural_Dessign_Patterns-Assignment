namespace StructuralDesignPatternApp
{
    public class TextComponent : ITextComponent
    {
        public string Text;
        public TextComponent(string text)
        {
            Text = text;
        }

        public string Apply()
        {
            return Text;
        }
    }
}
