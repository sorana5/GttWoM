using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatewayToTheWorldOfMusic
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        //[DllImport("user32.dll")]
        //public static extern bool SetProcessDpiAwareness(int awareness);
        static void Main()
        {
            //SetProcessDpiAwareness(2);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
        }
    }
}
