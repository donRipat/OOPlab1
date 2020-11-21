using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO;

namespace OOPlab1
{
    public partial class frmRegistraton : Form
    {
        private Form frm2;
        public frmRegistraton()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("file:///C:/Users/rafik/source/repos/OOPlab1/OOPlab1/Resources/TermsOfUse.html");
        }
        
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Value = tbPassword.Text.Length;
            if (tbPassword.Text.Length == 0)
            {
                labelProgressBar.ForeColor = Color.Red;
                labelProgressBar.Text = "No password";
            }
            if (tbPassword.Text.Length > 0)
            {
                labelProgressBar.ForeColor = Color.Red;
                labelProgressBar.Text = "Password must consist 5 char at least";
            }
            if (tbPassword.Text.Length > 4)
            {
                labelProgressBar.ForeColor = Color.Orange;
                labelProgressBar.Text = "Weak password";
            }
            if (tbPassword.Text.Length > 9)
            {
                labelProgressBar.ForeColor = Color.Green;
                labelProgressBar.Text = "Good password";
            }
            if (tbPassword.Text.Length > 14)
            {
                labelProgressBar.ForeColor = Color.Purple;
                labelProgressBar.Text = "Extremely good password";
            }
            IsSame();
        }

        private bool IsSame()
        {
            if (tbRepassword.Text == tbPassword.Text && tbPassword.Text.Length > 4)
            {
                labelSamePass.ForeColor = Color.Green;
                labelSamePass.Text = "✓";
                return true;
            }
            else
            {
                labelSamePass.ForeColor = Color.Red;
                labelSamePass.Text = "x";
                return false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (IsSame() && tbNickname.Text != "" && maskedTbFirstName.Text != "" && maskedTbLastName.Text != "" && comboBox1.SelectedIndex >= 0 && checkBoxAgree.Checked)
            {
                frm2 = new Form2();
                this.Hide();
                frm2.ShowDialog();
                this.Close();
            }
            else
            {
                labelNext.Text = "Fill all forms";
            }
        }
        
        private void tbRepassword_TextChanged(object sender, EventArgs e)
        {
            IsSame();
        }
        
        private void btnSkip_Click(object sender, EventArgs e)
        {
            frm2 = new Form2();
            this.Hide();
            frm2.ShowDialog();
            this.Close();
        }
    }
}
