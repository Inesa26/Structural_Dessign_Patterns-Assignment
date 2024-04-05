namespace StructuralDesignPatternApp
{
    public abstract class TextDecorator : ITextComponent
    {
        protected ITextComponent _textComponent;

        public TextDecorator(ITextComponent textComponent)
        {
            _textComponent = textComponent;
        }

        public abstract string Apply();

        public ITextComponent Remove<T>() where T : TextDecorator
        {
            if (this.GetType() == typeof(T))
            {
                return _textComponent;
            }
            else if (_textComponent is TextDecorator)
            {
                _textComponent = ((TextDecorator)_textComponent).Remove<T>();
            }
            return this;
        }
    }
}

