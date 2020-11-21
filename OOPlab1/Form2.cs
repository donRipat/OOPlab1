using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPlab1
{
    public partial class Form2 : Form
    {
        private Form frm3, frm4;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (radiobtn1.Checked)
            {
                frm4 = new Form4();
                this.Hide();
                frm4.ShowDialog();
                this.Close();
            }
            if (radiobtn2.Checked || radiobtn3.Checked)
            {
                frm3 = new Form3();
                this.Hide();
                frm3.ShowDialog();
                this.Close();
            }
        }
    }
}
