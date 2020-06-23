using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button_pressed(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textdisp.Text.Contains("."))
                    textdisp.Text = textdisp.Text + num.Text;
            }
            else
                textdisp.Text = textdisp.Text + num.Text;
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            textdisp.Text = "";
            indicator.Text = "";
        }

        private void arithmetic(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(textdisp.Text);
            textdisp.Text = "";
            indicator.Text = System.Convert.ToString(results) + " " + operation;

        }

        private void textdisp_TextChanged(object sender, EventArgs e)
        {

        }
        private void singleoperation(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            indicator.Text = operation;
            results = Double.Parse(textdisp.Text);
        }

        private void enter_pressed(object sender, EventArgs e)
        {
            indicator.Text = "";
            switch(operation)
            {
                case "+":
                    textdisp.Text = (results + Double.Parse(textdisp.Text)).ToString();
                    break;
                case "-":
                    textdisp.Text = (results - Double.Parse(textdisp.Text)).ToString();
                    break;
                case "/":
                    textdisp.Text = (results / Double.Parse(textdisp.Text)).ToString();
                    break;
                case "×":
                    textdisp.Text = (results * Double.Parse(textdisp.Text)).ToString();
                    break;
                case "^":
                    textdisp.Text = (Math.Pow(results, Double.Parse(textdisp.Text))).ToString();
                    break;
                case "√":
                    textdisp.Text = (Math.Sqrt(results)).ToString();
                    break;
                case "^-1":
                    textdisp.Text = (1 / results).ToString();
                    break;
                case "sin":
                    textdisp.Text = (Math.Sin(results*(Math.PI)/180)).ToString();
                    break;
                case "cos":
                    textdisp.Text = (Math.Cos(results * (Math.PI) / 180)).ToString();
                    break;
                case "tan":
                    textdisp.Text = (Math.Tan(results * (Math.PI) / 180)).ToString();
                    break;
            }
        }


        private void pi_pressed(object sender, EventArgs e)
        {
            textdisp.Text = "3.14159265359";
        }
    }
}
