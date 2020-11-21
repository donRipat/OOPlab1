using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace OOPlab1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tabPage1_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioBtnBeep.Checked)
            {
                System.Windows.Forms.Button btnBeep = new System.Windows.Forms.Button();
                btnBeep.Size = new System.Drawing.Size(100, 50);
                btnBeep.Location = new System.Drawing.Point(e.X - btnBeep.Size.Width / 2, e.Y - btnBeep.Size.Height / 2);
                btnBeep.Name = "btnBeep";
                btnBeep.TabIndex = 7;
                btnBeep.Text = "Beep";
                btnBeep.UseVisualStyleBackColor = true;
                btnBeep.Click += new System.EventHandler(btnBeep_Click);
                tabPage1.Controls.Add(btnBeep);
            }
            if (radioBtnTb.Checked)
            {
                System.Windows.Forms.TextBox tbZ = new System.Windows.Forms.TextBox();
                tbZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                tbZ.Location = new System.Drawing.Point(e.X - tbZ.Size.Width / 2, e.Y - tbZ.Size.Height / 2);
                tbZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                tbZ.Name = "tbZ";
                tbZ.Size = new System.Drawing.Size(100, 30);
                tbZ.TabIndex = 12;
                tabPage1.Controls.Add(tbZ);
            }
            if (radiobtnFrench.Checked)
            {
                System.Windows.Forms.Button btnFrench = new System.Windows.Forms.Button();
                btnFrench.Size = new System.Drawing.Size(100, 50);
                btnFrench.Location = new System.Drawing.Point(e.X - btnFrench.Size.Width / 2, e.Y - btnFrench.Size.Height / 2);
                btnFrench.Name = "btnFrench";
                btnFrench.TabIndex = 7;
                btnFrench.Text = "Aller en français";
                btnFrench.UseVisualStyleBackColor = true;
                btnFrench.Click += new System.EventHandler(btnFrensh_Click);
                tabPage1.Controls.Add(btnFrench);
            }
        }
        
        private void btnBeep_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
        }

        private void btnFrensh_Click(object sender, EventArgs e)
        {
            tabPage1.Text = "Le créateur";
            tabPage2.Text = "Le minuteur";
            groupBoxbtn.Text = "Choisissez ce que vous voulez créer";
            radioBtnBeep.Text = "Bouton bip";
            radioBtnTb.Text = "Texteboîte";
            radiobtnFrench.Text = "Aller en français";
            //SoundPlayer music = new SoundPlayer(@"c:\Users\rafik\source\repos\OOPlab1\OOPlab1\Resources\FrenchMusic.mp3");
            //music.Play();
            System.Diagnostics.Process.Start(@"C:\Users\rafik\source\repos\OOPlab1\OOPlab1\Resources\FrenchMusic.wav");

            //string[] music = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.wav", SearchOption.TopDirectoryOnly);

        }

        private int stpause = 1;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (stpause == 1)
            {
                timer1.Enabled = true;
                btnStart.Text = "Pause";
            }
            else
            {
                timer1.Enabled = false;
                btnStart.Text = "Start";
            }
            stpause *= -1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0)
            --trackBar1.Value;
            labelTime.Text = "Time left:" + trackBar1.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelTime.Text = "Time left:" + trackBar1.Value;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            labelTime.Text = "Time left:" + trackBar1.Value;
        }
    }
}
