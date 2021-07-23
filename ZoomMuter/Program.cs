using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoomMuter
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

             Application.Run(new Form1());
        //    Form3 f1 = new Form3();
        //    Form4 f2 = new Form4();
        //    f2.ExitRequested += f2_ExitRequested;
        //    Task programStart = f2.StartAsync();
         //   Application.Run();


        }

        static void f2_ExitRequested(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

    }
}
