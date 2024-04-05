using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatternApp
{
    public class ItalicTextDecorator : TextDecorator
    {
        public ItalicTextDecorator(ITextComponent textComponent) : base(textComponent) { }
        public override string Apply()
        {
             return "[Italic]" + _textComponent.Apply() + "[/Italic]";
        }
    }
}
    



