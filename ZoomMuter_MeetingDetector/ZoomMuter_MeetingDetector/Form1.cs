using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ZoomMuter_MeetingDetector
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


            while (true)
            {
                bool flg = false;
                Process[] processList = Process.GetProcesses();
                foreach (Process p in processList)
                {
                    if (p.ProcessName == "CptHost")
                    {
                        flg = true;
                        if (p.Responding)
                        {
                            //    Console.WriteLine("OK");
                            RunApp();
                            break;
                        }
                        else
                        {
                            //   p.CloseMainWindow();
                            //   RunApp();
                        }
                    }
                }
                if (!flg)
                {
                    //   RunApp();
                    //notepadのプロセスを取得
                    System.Diagnostics.Process[] ps =
                        System.Diagnostics.Process.GetProcessesByName("ZoomMuter");

                    foreach (System.Diagnostics.Process p in ps)
                    {
                        //プロセスを強制的に終了させる
                        p.Kill();
                    }
                }
                System.Threading.Thread.Sleep(100);
            }

        }

        private void RunApp()
        {
            bool flg2 = false;
            Process[] processList = Process.GetProcesses();
            foreach (Process p2 in processList)
                if (p2.ProcessName == "ZoomMuter")
                {
                    flg2 = true;
                    if (p2.Responding)
                    {
                        //    Console.WriteLine("OK");
                        break;
                    }
                    else
                    {
                        //   p.CloseMainWindow();
                        //   RunApp();
                    }
                }


            if (!flg2)
            {
                // 実行ファイルを指定して実行
                Process.Start(@"C:\Program Files (x86)\Taksas\ZoomMuter\ZoomMuter\ZoomMuter.exe");
            }

        }
    }
}