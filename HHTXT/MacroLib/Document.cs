using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApplication1.MacroLib
{
    public class Document
    {
        public void Append(string txt)
        {
            MDIParent1.ActiveTextBox?.AppendText(txt);
        }

        public void Clear()
        {
            MDIParent1.ActiveTextBox?.Clear();
        }

        public void SetText(string txt)
        {
            if(MDIParent1.ActiveTextBox != null)
                MDIParent1.ActiveTextBox.Text = txt;
        }

        public void SetText(string txt, int startPos, int endPos)
        {
            if (MDIParent1.ActiveTextBox != null) {
                var currentText = MDIParent1.ActiveTextBox.Text;

                MDIParent1.ActiveTextBox.Text = currentText.Substring(0, startPos) + txt + currentText.Substring(endPos);
            }
        }

        public string GetText()
        {
            return MDIParent1.ActiveTextBox?.Text;
        }

        public string GetText(int startPos)
        {
            return MDIParent1.ActiveTextBox?.Text.Substring(startPos);
        }

        public string GetText(int startPos, int endPos)
        {
            return MDIParent1.ActiveTextBox?.Text.Substring(startPos, endPos-startPos);
        }

        public string GetPartialText(int startPos, int length)
        {
            return MDIParent1.ActiveTextBox?.Text.Substring(startPos, length);
        }
    }
}
