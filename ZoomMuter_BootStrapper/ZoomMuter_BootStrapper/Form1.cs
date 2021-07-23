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
using System.Threading;


namespace ZoomMuter_BootStrapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            // タスクバーに表示しない
            this.ShowInTaskbar = false;
            InitializeComponent();
            // コンテキストメニュー
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

            ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem3.Text = "&ZoomMuterを終了";
            toolStripMenuItem3.Click += ToolStripMenuItem_Click3;
            contextMenuStrip.Items.Add(toolStripMenuItem3);

            notifyIcon1.ContextMenuStrip = contextMenuStrip;


            bool flg2 = false;
            Process[] processList = Process.GetProcesses();
            foreach (Process p2 in processList)
                if (p2.ProcessName == "ZoomMuter_MeetingDetector")
                {
                    flg2 = true;
                    if (p2.Responding)
                    {
                        //メッセージボックスを表示する
                        MessageBox.Show("ZoomMuterは既に起動済みです。ZoomMuterはPCの起動に合わせて自動起動します。",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        //アプリケーションを終了し、終了コードとして0を渡す
                        Environment.Exit(0);

                    }
                    else
                    {
                        //メッセージボックスを表示する
                        MessageBox.Show("ZoomMuterは既に起動済みです。ZoomMuterはPCの起動に合わせて自動起動します。",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        //アプリケーションを終了し、終了コードとして0を渡す
                        Environment.Exit(0);


                    }
                }


            if (!flg2)
            {
                Process.Start(@"C:\Program Files (x86)\Taksas\ZoomMuter\ZoomMuter_MeetingDetector\ZoomMuter_MeetingDetector.exe");
            }



 
        }

        private void ToolStripMenuItem_Click3(object sender, EventArgs e)
        {
            //notepadのプロセスを取得
            System.Diagnostics.Process[] ps =
                System.Diagnostics.Process.GetProcessesByName("ZoomMuter");

            foreach (System.Diagnostics.Process p in ps)
            {
                //プロセスを強制的に終了させる
                p.Kill();
            }

            //notepadのプロセスを取得
            System.Diagnostics.Process[] ps2 =
                System.Diagnostics.Process.GetProcessesByName("ZoomMuter_MeetingDetector");

            foreach (System.Diagnostics.Process p2 in ps2)
            {
                //プロセスを強制的に終了させる
                p2.Kill();
            }
            // アプリケーションの終了
            Application.Exit();

        }



    }
}
