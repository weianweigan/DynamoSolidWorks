using Du.SolidWorks.Attributes;
using SolidWorks.Interop.swconst;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Input;

namespace Du.DynamoSolidWorks.Commands
{
    [SWCommand("DynamoSolidWorks", 0, TextType = swCommandTabButtonTextDisplay_e.swCommandTabButton_TextBelow)]
    class DynamoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            return true;
        }

        public void Execute(object parameter)
        {
            System.Diagnostics.Process.Start(AssemblyPath + @"\DynamoSandbox.exe");
        }

        public string AssemblyPath
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
    }
}
