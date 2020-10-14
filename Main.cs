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
        List<Content> contents = new List<Content>();
        int count = 0;

        public void drawContents()
        {
            flow.Controls.Clear();
            foreach (var now in contents)
            {
                flow.Controls.Add(new Panel
                {
                    Name = $"{flow.Controls.Count}",
                    Width = 129,
                    Height = 55,
                    BackColor = System.Drawing.SystemColors.ControlDark,
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                });
                var cont = flow.Controls[flow.Controls.Count - 1];

                string content = "Unknown";
                if (now.type == 0)
                {
                    if (now.mouse == 0) content = "좌클릭";
                    else if (now.mouse == 1) content = "우클릭";
                }
                else if (now.type == 1)
                {
                    content = $"키보드 {now.key}";
                }
                cont.Controls.AddRange(new Control[] {
                    new Label
                    {
                        Name = $"{flow.Controls.Count - 1}",
                        Text = content,
                        Width = 79,
                        Height = 19,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        Location = new Point(4, 5)
                    },
                    new Button
                    {
                        Name = $"{flow.Controls.Count - 1}",
                        Text = "속성",
                        Location = new System.Drawing.Point(88, 3),
                        Size = new System.Drawing.Size(38, 23),
                        UseVisualStyleBackColor = true
                    },
                    new Button
                    {
                        Name = $"{flow.Controls.Count - 1}",
                        Text = "삭제",
                        Location = new System.Drawing.Point(45, 27),
                        Size = new System.Drawing.Size(39, 23),
                        UseVisualStyleBackColor = true
                    },
                    new Button
                    {
                        Name = $"{flow.Controls.Count - 1}",
                        Text = "<",
                        Location = new System.Drawing.Point(4, 27),
                        Size = new System.Drawing.Size(20, 23),
                        UseVisualStyleBackColor = true
                    },
                    new Button
                    {
                        Name = $"{flow.Controls.Count - 1}",
                        Text = ">",
                        Location = new System.Drawing.Point(104, 27),
                        Size = new System.Drawing.Size(20, 23),
                        UseVisualStyleBackColor = true
                    }
                });

                (cont.Controls[1] as Button).Click += (object sender, EventArgs e) =>
                {
                    //속성버튼

                };
                (cont.Controls[2] as Button).Click += (object sender, EventArgs e) =>
                {
                    //삭제버튼
                    contents.RemoveAt(int.Parse((sender as Button).Name));
                    drawContents();
                };
                (cont.Controls[3] as Button).Click += (object sender, EventArgs e) =>
                {
                    //좌로이동
                    int n = int.Parse((sender as Button).Name);
                    if (0 < n)
                    {
                        var tmp = contents[n];
                        contents[n] = contents[n - 1];
                        contents[n - 1] = tmp;
                    }
                    drawContents();
                };
                (cont.Controls[4] as Button).Click += (object sender, EventArgs e) =>
                {
                    //우로이동
                    int n = int.Parse((sender as Button).Name);
                    if (n < contents.Count - 1)
                    {
                        var tmp = contents[n];
                        contents[n] = contents[n + 1];
                        contents[n + 1] = tmp;
                    }
                    drawContents();
                };
            }
        }

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

            drawContents();
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

        private void addContent_Click(object sender, EventArgs e)
        {
            contents.Add(new Content(count++));
            drawContents();
        }

        private void clearContents_Click(object sender, EventArgs e)
        {
            contents.Clear();
            drawContents();
        }
    }

    class Content
    {
        public int type = 0; // 마우스=0   키보드=1

        public int mouse = 0; // 좌클릭=0   우클릭=1
        public Keys key = Keys.Space; //키보드

        public int id = 0;

        public Content(int nid)
        {
            id = nid;
        }
    }
}