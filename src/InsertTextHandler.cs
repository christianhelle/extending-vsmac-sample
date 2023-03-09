using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Ide.Gui;
using System;

namespace Sample
{
    public class InsertTextHandler : CommandHandler
    {
        protected override void Run()
        {
            var editor = IdeApp.Workbench.ActiveDocument.Editor;
            editor.InsertAtCaret("// Hello");
        }

        protected override void Update(CommandInfo info)
        {
            info.Enabled = IdeApp.Workbench.ActiveDocument?.Editor != null;
        }
    }

    public enum SampleCommands
    {
        InsertText,
    }
}