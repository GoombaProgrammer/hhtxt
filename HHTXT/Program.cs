using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApplication1.MacroLib;

namespace WindowsApplication1
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            new MacroManager();
            
            // Register MoonSharp types
            UserData.RegisterType<Document>();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIParent1());
        }
    }
}
