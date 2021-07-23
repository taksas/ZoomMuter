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
using System.Runtime.InteropServices;



namespace ZoomMuter
{


    public partial class Form1 : Form
    {
        public Form1 f1 = null;
        public int m;
        public int n;
        public int o;

        public Form1()
        {
            InitializeComponent();
            this.TopMost = !this.TopMost;

    }

        private static ushort WM_SYSKEYDOWN = 0x0104;
        private static ushort WM_SYSKEYUP = 0x0105;
        private static ushort VK_F1 = 0x70;
        private static ushort VK_F2 = 0x71;
        private static ushort VK_MENU = 0x12;

        private void button1_Click(object sender, EventArgs e)
        {

            IntPtr hwnd = GetDesktopWindow();
            // メモ帳のウインドウハンドル取得
            hwnd = FindWindowEx(hwnd, IntPtr.Zero, "Zoom", null);
            // メモ帳ウインドウ内の「edit」ウインドウのハンドル取得
            hwnd = FindWindowEx(hwnd, IntPtr.Zero, "ZPContentViewWndClass", null);

            if (m == 0)

            {
                  PostMessage(hwnd, WM_SYSKEYDOWN, VK_F1, 0);
                  PostMessage(hwnd, WM_SYSKEYUP, VK_F1, 0);

                button1.BackColor = Color.Red;
                button1.Text = "ミュート解除中";
                button1.BackgroundImage = Properties.Resources.icon_124380_256;
                m = 1;
            }
            else
            {
                  PostMessage(hwnd, WM_SYSKEYDOWN, VK_F1, 0);
                  PostMessage(hwnd, WM_SYSKEYUP, VK_F1, 0);

                button1.BackColor = Color.DarkTurquoise;
                button1.Text = "ミュート中";
                button1.BackgroundImage = Properties.Resources.icon_124380_256_x;
                m = 0;
            }




        }


        private void button2_Click(object sender, EventArgs e)
        {
            IntPtr hwnd = GetDesktopWindow();
            // メモ帳のウインドウハンドル取得
            hwnd = FindWindowEx(hwnd, IntPtr.Zero, "Zoom", null);
            // メモ帳ウインドウ内の「edit」ウインドウのハンドル取得
            hwnd = FindWindowEx(hwnd, IntPtr.Zero, "ZPContentViewWndClass", null);

            if (n == 0)

            {
                PostMessage(hwnd, WM_SYSKEYDOWN, VK_F2, 0);
                PostMessage(hwnd, WM_SYSKEYUP, VK_F2, 0);
                button2.BackColor = Color.Red;
                button2.Text = "ミュート解除中";
                button2.BackgroundImage = Properties.Resources.icon_movie_256;
                n = 1;
            }
            else
            {
                PostMessage(hwnd, WM_SYSKEYDOWN, VK_F2, 0);
                PostMessage(hwnd, WM_SYSKEYUP, VK_F2, 0);
                button2.BackColor = Color.DarkTurquoise;
                button2.Text = "ミュート中";
                button2.BackgroundImage = Properties.Resources.icon_movie_256_x;
                n = 0;
            }

        }


        #region Imports
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool PostMessage(IntPtr hwnd, int Msg, int wParam, int lParam);

        // Get a handle to an application window.
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hwnd);

        #endregion

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            if (o == 0)
                
            {
                button3.BackColor = Color.White;
                button3.Text = "ウインドウを最前面に固定表示";
                o = 1;
            }
            else
            {
                button3.BackColor = Color.MediumSlateBlue;
                button3.Text = "ウインドウの最前面固定を解除";
                o = 0;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
