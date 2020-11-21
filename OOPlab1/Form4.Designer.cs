namespace OOPlab1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxbtn = new System.Windows.Forms.GroupBox();
            this.radiobtnFrench = new System.Windows.Forms.RadioButton();
            this.radioBtnTb = new System.Windows.Forms.RadioButton();
            this.radioBtnBeep = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.groupBoxbtn.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxbtn
            // 
            this.groupBoxbtn.Controls.Add(this.radiobtnFrench);
            this.groupBoxbtn.Controls.Add(this.radioBtnTb);
            this.groupBoxbtn.Controls.Add(this.radioBtnBeep);
            this.groupBoxbtn.Location = new System.Drawing.Point(6, 6);
            this.groupBoxbtn.Name = "groupBoxbtn";
            this.groupBoxbtn.Size = new System.Drawing.Size(221, 177);
            this.groupBoxbtn.TabIndex = 0;
            this.groupBoxbtn.TabStop = false;
            this.groupBoxbtn.Text = "Choose what you want to create";
            // 
            // radiobtnFrench
            // 
            this.radiobtnFrench.AutoSize = true;
            this.radiobtnFrench.Location = new System.Drawing.Point(6, 136);
            this.radiobtnFrench.Name = "radiobtnFrench";
            this.radiobtnFrench.Size = new System.Drawing.Size(198, 29);
            this.radiobtnFrench.TabIndex = 2;
            this.radiobtnFrench.TabStop = true;
            this.radiobtnFrench.Text = "\"Go French\" button";
            this.radiobtnFrench.UseVisualStyleBackColor = true;
            // 
            // radioBtnTb
            // 
            this.radioBtnTb.AutoSize = true;
            this.radioBtnTb.Location = new System.Drawing.Point(6, 101);
            this.radioBtnTb.Name = "radioBtnTb";
            this.radioBtnTb.Size = new System.Drawing.Size(104, 29);
            this.radioBtnTb.TabIndex = 1;
            this.radioBtnTb.TabStop = true;
            this.radioBtnTb.Text = "Textbox";
            this.radioBtnTb.UseVisualStyleBackColor = true;
            // 
            // radioBtnBeep
            // 
            this.radioBtnBeep.AutoSize = true;
            this.radioBtnBeep.Location = new System.Drawing.Point(6, 66);
            this.radioBtnBeep.Name = "radioBtnBeep";
            this.radioBtnBeep.Size = new System.Drawing.Size(152, 29);
            this.radioBtnBeep.TabIndex = 0;
            this.radioBtnBeep.TabStop = true;
            this.radioBtnBeep.Text = "\"Beep button\"";
            this.radioBtnBeep.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1003, 462);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxbtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(995, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Creator";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabPage1_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelTime);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Controls.Add(this.trackBar1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(995, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Timer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(30, 29);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(930, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(416, 284);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(434, 201);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(108, 25);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Time left: 0";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 465);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBoxbtn.ResumeLayout(false);
            this.groupBoxbtn.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxbtn;
        private System.Windows.Forms.RadioButton radiobtnFrench;
        private System.Windows.Forms.RadioButton radioBtnTb;
        private System.Windows.Forms.RadioButton radioBtnBeep;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
    }
}