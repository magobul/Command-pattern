using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_pattern
{
    public class InsertTextCommand:ICommand
    {
        private TextEditor _textEditor;
        private string _text;

        public InsertTextCommand(TextEditor textEditor, string text)
        {
            _textEditor = textEditor;
            _text = text;
        }

        public void Execute()
        {
            _textEditor.InsertText(_text);
        }

        public void Undo()
        {
            _textEditor.DeleteText(_text.Length);
        }
    }
}
