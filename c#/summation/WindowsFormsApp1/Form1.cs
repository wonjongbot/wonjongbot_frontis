using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Summation : Form
    {
        int lwrbnd, uprbnd;
        string oprtr;

        public Summation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculatebtn_Click(object sender, EventArgs e)
        {
            uprbnd = Convert.ToInt32(uprbndTXT.Text);
            lwrbnd = Convert.ToInt32(lwrbndTXT.Text);
            int total = 0;
            for (int i = lwrbnd; i <= uprbnd; i++)
            {
                total += lwrbnd;
                lwrbnd++;
            }
            resulttxt.Text = Convert.ToString(total);
        }

        private void uprbndTXT_TextChanged(object sender, EventArgs e)
        {
            uprbnd = Convert.ToInt32(uprbndTXT.Text);
        }

        private void lwrbndTXT_TextChanged(object sender, EventArgs e)
        {
            lwrbnd = Convert.ToInt32(lwrbndTXT.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
