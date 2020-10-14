using System.Windows.Forms;

namespace Auto_Clicker
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.element = new System.Windows.Forms.Panel();
            this.config = new System.Windows.Forms.Button();
            this.moveRight = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Label();
            this.addContent = new System.Windows.Forms.Button();
            this.clearContents = new System.Windows.Forms.Button();
            this.dividor = new System.Windows.Forms.Label();
            this.flow.SuspendLayout();
            this.element.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "시작 키";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.comboBox1.Location = new System.Drawing.Point(53, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(42, 20);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.comboBox2.Location = new System.Drawing.Point(164, 8);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(42, 20);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "정지 키";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "초당                    번";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 21);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "50";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "타임 라인";
            // 
            // flow
            // 
            this.flow.AutoScroll = true;
            this.flow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flow.Controls.Add(this.element);
            this.flow.Location = new System.Drawing.Point(7, 69);
            this.flow.Name = "flow";
            this.flow.Size = new System.Drawing.Size(544, 127);
            this.flow.TabIndex = 8;
            // 
            // element
            // 
            this.element.BackColor = System.Drawing.SystemColors.ControlDark;
            this.element.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.element.Controls.Add(this.config);
            this.element.Controls.Add(this.moveRight);
            this.element.Controls.Add(this.moveLeft);
            this.element.Controls.Add(this.delete);
            this.element.Controls.Add(this.content);
            this.element.Location = new System.Drawing.Point(3, 3);
            this.element.Name = "element";
            this.element.Size = new System.Drawing.Size(129, 55);
            this.element.TabIndex = 0;
            // 
            // config
            // 
            this.config.Location = new System.Drawing.Point(88, 3);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(38, 23);
            this.config.TabIndex = 4;
            this.config.Text = "속성";
            this.config.UseVisualStyleBackColor = true;
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(104, 26);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(20, 23);
            this.moveRight.TabIndex = 3;
            this.moveRight.Text = ">";
            this.moveRight.UseVisualStyleBackColor = true;
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(4, 27);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(20, 23);
            this.moveLeft.TabIndex = 2;
            this.moveLeft.Text = "<";
            this.moveLeft.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(45, 27);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(39, 23);
            this.delete.TabIndex = 1;
            this.delete.Text = "삭제";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // content
            // 
            this.content.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.content.Location = new System.Drawing.Point(4, 5);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(79, 19);
            this.content.TabIndex = 0;
            this.content.Text = "좌클릭";
            this.content.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addContent
            // 
            this.addContent.Location = new System.Drawing.Point(450, 42);
            this.addContent.Name = "addContent";
            this.addContent.Size = new System.Drawing.Size(41, 23);
            this.addContent.TabIndex = 9;
            this.addContent.Text = "추가";
            this.addContent.UseVisualStyleBackColor = true;
            this.addContent.Click += new System.EventHandler(this.addContent_Click);
            // 
            // clearContents
            // 
            this.clearContents.Location = new System.Drawing.Point(495, 42);
            this.clearContents.Name = "clearContents";
            this.clearContents.Size = new System.Drawing.Size(51, 23);
            this.clearContents.TabIndex = 10;
            this.clearContents.Text = "지우기";
            this.clearContents.UseVisualStyleBackColor = true;
            this.clearContents.Click += new System.EventHandler(this.clearContents_Click);
            // 
            // dividor
            // 
            this.dividor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dividor.Location = new System.Drawing.Point(10, 34);
            this.dividor.Name = "dividor";
            this.dividor.Size = new System.Drawing.Size(540, 2);
            this.dividor.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(560, 203);
            this.Controls.Add(this.dividor);
            this.Controls.Add(this.clearContents);
            this.Controls.Add(this.addContent);
            this.Controls.Add(this.flow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Auto Clicker";
            this.flow.ResumeLayout(false);
            this.element.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private Timer timer1;
        private Label label4;
        private FlowLayoutPanel flow;
        private Panel element;
        private Label content;
        private Button delete;
        private Button moveLeft;
        private Button moveRight;
        private Button config;
        private Button addContent;
        private Button clearContents;
        private Label dividor;
    }
}

