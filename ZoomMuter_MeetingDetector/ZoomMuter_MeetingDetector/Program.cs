using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoomMuter_MeetingDetector
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
            //    Application.Run(new Form1());


            // FormÇï\é¶ÇµÇ»Ç¢Ç≈é¿çsÇ∑ÇÈ
            new Form1();
            Application.Run();
        }
    }
}
