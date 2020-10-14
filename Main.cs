using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Auto_Clicker
{
    public partial class Main : Form
    {
        int StartKeyNumber = 3;
        int StopKeyNumber = 4;
        bool isClicking = false;

        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            Windows = 8
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, Keys vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        const int HOTKEY_ID = 31197;
        const int WM_HOTKEY = 0x0312;
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        protected override void WndProc(ref Message message)
        {
            switch (message.Msg)
            {
                case WM_HOTKEY:
                    Keys key = (Keys)(((int)message.LParam >> 16) & 0xFFFF);
                    KeyModifiers modifier = (KeyModifiers)((int)message.LParam & 0xFFFF);

                    if (KeyModifiers.None == modifier && Keys.F1 + StartKeyNumber - 1 == key)
                        isClicking = true;
                    if (KeyModifiers.None == modifier && Keys.F1 + StopKeyNumber - 1 == key)
                        isClicking = false;

                    break;
            }
            base.WndProc(ref message);
        }

        public Main()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.comboBox1.Text = "F3";
            this.comboBox2.Text = "F4";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartKeyNumber = int.Parse(this.comboBox1.Text.Substring(1));

            UnregisterHotKey(this.Handle, HOTKEY_ID);
            RegisterHotKey(this.Handle, HOTKEY_ID, KeyModifiers.None, Keys.F1 + StartKeyNumber - 1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopKeyNumber = int.Parse(this.comboBox2.Text.Substring(1));

            UnregisterHotKey(this.Handle, HOTKEY_ID + 1);
            RegisterHotKey(this.Handle, HOTKEY_ID + 1, KeyModifiers.None, Keys.F1 + StopKeyNumber - 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 1000 / int.Parse(textBox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isClicking)
            {
                int Xposition = MousePosition.X;
                int Yposition = MousePosition.Y;
                mouse_event(MOUSEEVENTF_LEFTDOWN, Xposition, Yposition, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, Xposition, Yposition, 0, 0);
            }
        }
    }
}