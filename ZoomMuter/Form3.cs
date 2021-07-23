using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ZoomMuter
{
    public partial class Form3 : Form
    {

        // タイマーを生成
  //      public System.Timers.Timer Timer = new System.Timers.Timer();
   //     public Form1 sf = null;
  //      public String UD = null;

        public Form3()
        {



            //  backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);


            // InitializeComponent();
            // タスクバーに表示しない
  //          this.ShowInTaskbar = false;
            InitializeComponent();
            //  backgroundWorker1.RunWorkerAsync();
            //アイコンの上にマウスポインタを移動した時に表示される文字列
   //         this.notifyIcon1.Text = "ZoomMuter";
            //アイコンを右クリックしたときに表示するコンテキストメニュー
            //ContextMenuStrip1はすでに用意されているものとする
            //           this.notifyIcon1.ContextMenuStrip = this.ContextMenuStrip1;
            // コンテキストメニュー
  /*          ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem.Text = "&ウインドウを表示";
            toolStripMenuItem.Click += ToolStripMenuItem_Click;
            contextMenuStrip.Items.Add(toolStripMenuItem);

            ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem2.Text = "&ヘルプ";
            toolStripMenuItem2.Click += ToolStripMenuItem_Click2;
            contextMenuStrip.Items.Add(toolStripMenuItem2);

            ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem3.Text = "&終了";
            toolStripMenuItem3.Click += ToolStripMenuItem_Click3;
            contextMenuStrip.Items.Add(toolStripMenuItem3);

            notifyIcon1.ContextMenuStrip = contextMenuStrip;
*/
            // 実行ファイルを指定して実行
    //        Process.Start(@"C:\Program Files\ZoomMuter\ZoomMuter_Detector\ZoomMuter_Detector.exe");

              Form1 f1 = new Form1();
              f1.Show();

        }

            /*         System.Timers.Timer timer = new System.Timers.Timer(1000);

                     // タイマーの処理
                     timer.Elapsed += (sender, e) =>
                     {
                         Process[] processes = Process.GetProcessesByName("notepad");
                         if (processes.Length == 0)
                         {

                         }
                         else
                         {
                             StartStart();
                             string a = null;
                             String UD = a;


                         }

                     };

                     if (UD == null)
                     {
                         timer.Start();
                     }
                     else
                     {

                         timer.Stop();


                     }


                 }


                 private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs args)
                 {


                     while (true)
                     {
                         Form1 f1 = new Form1();
                         f1.Show();

                         Process[] processes = Process.GetProcessesByName("notepad");
                         if (processes.Length == 0)
                         {

                         }
                         else
                         {
                             Form1 f2 = new Form1();
                             f2.Show();


                             this.Invoke(new Action(this.StartStart));

                         }

                     }

                 }*/

            /*
                 private void StartStart()
                 {
                     /* 二重起動防止 */
            /*    if (this.sf == null || this.sf.IsDisposed)
                { /* ヌル、または破棄されていたら */
            /*     this.sf = new Form1();
                     sf.Show();
                 }



                 // Form1 f1 = new Form1();
                 //f1.Show();
             }

            */
            





 private void Form3_Load(object sender, EventArgs e)
{

}

 /*private void ToolStripMenuItem_Click(object sender, EventArgs e)
 {
     Form1 f1 = new Form1();
     f1.Show();
 }


 private void ToolStripMenuItem_Click2(object sender, EventArgs e)
 {
     Form2 f1 = new Form2();
     f1.Show();
 }


 private void ToolStripMenuItem_Click3(object sender, EventArgs e)
 {

            //notepadのプロセスを取得
            System.Diagnostics.Process[] ps =
                System.Diagnostics.Process.GetProcessesByName("ZoomMuter_MeetingDetector");

            foreach (System.Diagnostics.Process p in ps)
            {
                //プロセスを強制的に終了させる
                p.Kill();
            }

            // アプリケーションの終了
            Application.Exit();
        
 }

        */

}


}

