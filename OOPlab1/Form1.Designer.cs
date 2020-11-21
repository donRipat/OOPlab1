namespace OOPlab1
{
    partial class frmRegistraton
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
            this.btnNext = new System.Windows.Forms.Button();
            this.maskedTbFirstName = new System.Windows.Forms.MaskedTextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelNickname = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRepassword = new System.Windows.Forms.Label();
            this.tbRepassword = new System.Windows.Forms.TextBox();
            this.maskedTbLastName = new System.Windows.Forms.MaskedTextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.labelDescFirstName = new System.Windows.Forms.Label();
            this.labelDescLastName = new System.Windows.Forms.Label();
            this.labelDescAge = new System.Windows.Forms.Label();
            this.labelDescNickname = new System.Windows.Forms.Label();
            this.labelDescPassword = new System.Windows.Forms.Label();
            this.labelDescRepassword = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAgree = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelProgressBar = new System.Windows.Forms.Label();
            this.labelSamePass = new System.Windows.Forms.Label();
            this.labelNext = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(863, 406);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 45);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next >>>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // maskedTbFirstName
            // 
            this.maskedTbFirstName.AsciiOnly = true;
            this.maskedTbFirstName.BeepOnError = true;
            this.maskedTbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTbFirstName.HidePromptOnLeave = true;
            this.maskedTbFirstName.Location = new System.Drawing.Point(197, 17);
            this.maskedTbFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTbFirstName.Mask = "??????????????????????";
            this.maskedTbFirstName.Name = "maskedTbFirstName";
            this.maskedTbFirstName.PromptChar = ' ';
            this.maskedTbFirstName.Size = new System.Drawing.Size(290, 30);
            this.maskedTbFirstName.TabIndex = 1;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(20, 20);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(109, 25);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(20, 70);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(109, 25);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last name:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge.Location = new System.Drawing.Point(20, 120);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(54, 25);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Age:";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSex.Location = new System.Drawing.Point(20, 170);
            this.labelSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(53, 25);
            this.labelSex.TabIndex = 5;
            this.labelSex.Text = "Sex:";
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNickname.Location = new System.Drawing.Point(20, 220);
            this.labelNickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(105, 25);
            this.labelNickname.TabIndex = 6;
            this.labelNickname.Text = "Nickname:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(20, 270);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(104, 25);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password:";
            // 
            // labelRepassword
            // 
            this.labelRepassword.AutoSize = true;
            this.labelRepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRepassword.Location = new System.Drawing.Point(20, 370);
            this.labelRepassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRepassword.Name = "labelRepassword";
            this.labelRepassword.Size = new System.Drawing.Size(169, 25);
            this.labelRepassword.TabIndex = 8;
            this.labelRepassword.Text = "Repeat password:";
            // 
            // tbRepassword
            // 
            this.tbRepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRepassword.Location = new System.Drawing.Point(197, 367);
            this.tbRepassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRepassword.MaxLength = 20;
            this.tbRepassword.Name = "tbRepassword";
            this.tbRepassword.Size = new System.Drawing.Size(290, 30);
            this.tbRepassword.TabIndex = 9;
            this.tbRepassword.UseSystemPasswordChar = true;
            this.tbRepassword.TextChanged += new System.EventHandler(this.tbRepassword_TextChanged);
            // 
            // maskedTbLastName
            // 
            this.maskedTbLastName.AsciiOnly = true;
            this.maskedTbLastName.BeepOnError = true;
            this.maskedTbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTbLastName.HidePromptOnLeave = true;
            this.maskedTbLastName.Location = new System.Drawing.Point(197, 67);
            this.maskedTbLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTbLastName.Mask = "??????????????????????";
            this.maskedTbLastName.Name = "maskedTbLastName";
            this.maskedTbLastName.PromptChar = ' ';
            this.maskedTbLastName.Size = new System.Drawing.Size(290, 30);
            this.maskedTbLastName.TabIndex = 10;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(197, 267);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.MaxLength = 20;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(290, 30);
            this.tbPassword.TabIndex = 11;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbNickname
            // 
            this.tbNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNickname.Location = new System.Drawing.Point(197, 217);
            this.tbNickname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNickname.MaxLength = 20;
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(290, 30);
            this.tbNickname.TabIndex = 12;
            // 
            // labelDescFirstName
            // 
            this.labelDescFirstName.AutoSize = true;
            this.labelDescFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescFirstName.Location = new System.Drawing.Point(495, 20);
            this.labelDescFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescFirstName.Name = "labelDescFirstName";
            this.labelDescFirstName.Size = new System.Drawing.Size(248, 25);
            this.labelDescFirstName.TabIndex = 13;
            this.labelDescFirstName.Text = "<<< Allows 22 ASCII chars";
            // 
            // labelDescLastName
            // 
            this.labelDescLastName.AutoSize = true;
            this.labelDescLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescLastName.Location = new System.Drawing.Point(495, 70);
            this.labelDescLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescLastName.Name = "labelDescLastName";
            this.labelDescLastName.Size = new System.Drawing.Size(248, 25);
            this.labelDescLastName.TabIndex = 14;
            this.labelDescLastName.Text = "<<< Allows 22 ASCII chars";
            // 
            // labelDescAge
            // 
            this.labelDescAge.AutoSize = true;
            this.labelDescAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescAge.Location = new System.Drawing.Point(495, 120);
            this.labelDescAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescAge.Name = "labelDescAge";
            this.labelDescAge.Size = new System.Drawing.Size(236, 25);
            this.labelDescAge.TabIndex = 15;
            this.labelDescAge.Text = "<<< Allows numbers 0-99";
            // 
            // labelDescNickname
            // 
            this.labelDescNickname.AutoSize = true;
            this.labelDescNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescNickname.Location = new System.Drawing.Point(495, 220);
            this.labelDescNickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescNickname.Name = "labelDescNickname";
            this.labelDescNickname.Size = new System.Drawing.Size(227, 25);
            this.labelDescNickname.TabIndex = 16;
            this.labelDescNickname.Text = "<<< Allows any 20 chars";
            // 
            // labelDescPassword
            // 
            this.labelDescPassword.AutoSize = true;
            this.labelDescPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescPassword.Location = new System.Drawing.Point(495, 270);
            this.labelDescPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescPassword.Name = "labelDescPassword";
            this.labelDescPassword.Size = new System.Drawing.Size(227, 25);
            this.labelDescPassword.TabIndex = 17;
            this.labelDescPassword.Text = "<<< Allows any 20 chars";
            // 
            // labelDescRepassword
            // 
            this.labelDescRepassword.AutoSize = true;
            this.labelDescRepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescRepassword.Location = new System.Drawing.Point(531, 370);
            this.labelDescRepassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescRepassword.Name = "labelDescRepassword";
            this.labelDescRepassword.Size = new System.Drawing.Size(227, 25);
            this.labelDescRepassword.TabIndex = 18;
            this.labelDescRepassword.Text = "<<< Allows any 20 chars";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(197, 167);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 33);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Text = "...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(197, 325);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Maximum = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(290, 13);
            this.progressBar1.TabIndex = 21;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(197, 118);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(290, 30);
            this.numericUpDown1.TabIndex = 22;
            // 
            // checkBoxAgree
            // 
            this.checkBoxAgree.AutoSize = true;
            this.checkBoxAgree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAgree.Location = new System.Drawing.Point(20, 421);
            this.checkBoxAgree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxAgree.Name = "checkBoxAgree";
            this.checkBoxAgree.Size = new System.Drawing.Size(18, 17);
            this.checkBoxAgree.TabIndex = 23;
            this.checkBoxAgree.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(12, 16);
            this.linkLabel1.Location = new System.Drawing.Point(46, 416);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(441, 29);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "I have read the Terms of Use and I accept them";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelProgressBar
            // 
            this.labelProgressBar.AutoSize = true;
            this.labelProgressBar.ForeColor = System.Drawing.Color.Red;
            this.labelProgressBar.Location = new System.Drawing.Point(495, 318);
            this.labelProgressBar.Name = "labelProgressBar";
            this.labelProgressBar.Size = new System.Drawing.Size(138, 25);
            this.labelProgressBar.TabIndex = 25;
            this.labelProgressBar.Text = "- No password";
            // 
            // labelSamePass
            // 
            this.labelSamePass.AutoSize = true;
            this.labelSamePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSamePass.ForeColor = System.Drawing.Color.Red;
            this.labelSamePass.Location = new System.Drawing.Point(494, 365);
            this.labelSamePass.Name = "labelSamePass";
            this.labelSamePass.Size = new System.Drawing.Size(29, 32);
            this.labelSamePass.TabIndex = 26;
            this.labelSamePass.Text = "x";
            // 
            // labelNext
            // 
            this.labelNext.AutoSize = true;
            this.labelNext.ForeColor = System.Drawing.Color.Red;
            this.labelNext.Location = new System.Drawing.Point(743, 416);
            this.labelNext.Name = "labelNext";
            this.labelNext.Size = new System.Drawing.Size(0, 25);
            this.labelNext.TabIndex = 27;
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(927, 365);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(66, 33);
            this.btnSkip.TabIndex = 28;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // frmRegistraton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 465);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.labelNext);
            this.Controls.Add(this.labelSamePass);
            this.Controls.Add(this.labelProgressBar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBoxAgree);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelDescRepassword);
            this.Controls.Add(this.labelDescPassword);
            this.Controls.Add(this.labelDescNickname);
            this.Controls.Add(this.labelDescAge);
            this.Controls.Add(this.labelDescLastName);
            this.Controls.Add(this.labelDescFirstName);
            this.Controls.Add(this.tbNickname);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.maskedTbLastName);
            this.Controls.Add(this.tbRepassword);
            this.Controls.Add(this.labelRepassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.maskedTbFirstName);
            this.Controls.Add(this.btnNext);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegistraton";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.MaskedTextBox maskedTbFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRepassword;
        private System.Windows.Forms.TextBox tbRepassword;
        private System.Windows.Forms.MaskedTextBox maskedTbLastName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Label labelDescFirstName;
        private System.Windows.Forms.Label labelDescLastName;
        private System.Windows.Forms.Label labelDescAge;
        private System.Windows.Forms.Label labelDescNickname;
        private System.Windows.Forms.Label labelDescPassword;
        private System.Windows.Forms.Label labelDescRepassword;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBoxAgree;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelProgressBar;
        private System.Windows.Forms.Label labelSamePass;
        private System.Windows.Forms.Label labelNext;
        private System.Windows.Forms.Button btnSkip;
    }
}

