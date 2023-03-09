using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.CodeAnalysis.Text;

namespace Sample
{
    public class InsertTextHandler : CommandHandler
    {
        protected override void Run()
        {
            var textBuffer = IdeApp.Workbench.ActiveDocument.GetContent<ITextBuffer>();
            var textView = IdeApp.Workbench.ActiveDocument.GetContent<ITextView>();
            var caretPosition = textView.Caret.Position;
            textBuffer.Insert(caretPosition.BufferPosition.Position, "// Hello");
        }

        protected override void Update(CommandInfo info)
        {
            var textBuffer = IdeApp.Workbench.ActiveDocument.GetContent<ITextBuffer>();
            if (textBuffer != null && textBuffer.AsTextContainer() is SourceTextContainer container)
            {
                var document = container.GetTextBuffer();
                if (document != null)
                {
                    info.Enabled = true;
                }
           }
        }
    }

    public enum SampleCommands
    {
        InsertText,
    }
}