using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Calculator
{
    public partial class Calculator : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = frontis; database = calculations");
        MySqlCommand command;
        Double results = 0;
        String operation = "";
        string save;

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
            else if (textdisp.Text == "invalid")
            {
                textdisp.Text = "";
            }
            else
                textdisp.Text = textdisp.Text + num.Text;

        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            textdisp.Text = "";
        }

        private void arithmetic(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(textdisp.Text);

            if (textdisp.Text == "")
            {
                results = 0;
                MessageBox.Show("Please enter a numeric value first");
                textdisp.Text = "";
                indicator.Text = "";
            }
                
            else
            {
                textdisp.Text = "";
                indicator.Text = System.Convert.ToString(results) + " " + operation;
                save = indicator.Text;
            }

        }

        private void textdisp_TextChanged(object sender, EventArgs e)
        {

        }
        private void singleoperation(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            indicator.Text = operation;
            if(textdisp.Text == "")
            {
                results = 0;
                MessageBox.Show("Please enter a numeric value first");
                textdisp.Text = "";
                indicator.Text = "";
            }
            else
            {
                results = Double.Parse(textdisp.Text);
            }
        }

        private void enter_pressed(object sender, EventArgs e)
        {
            indicator.Text = "";
            //saves calculation
            checker.Text = save + " " + textdisp.Text + " = ";
            string inputvalue = textdisp.Text;
            switch (operation)
            {
                case "+":
                    textdisp.Text = (results + Double.Parse(textdisp.Text)).ToString();
                    checker.Text = checker.Text + Math.Round(Convert.ToDecimal(textdisp.Text), 3);
                    break;
                case "-":
                    textdisp.Text = (results - Double.Parse(textdisp.Text)).ToString();
                    checker.Text = checker.Text + Math.Round(Convert.ToDecimal(textdisp.Text), 3);
                    break;
                case "÷":
                    if (textdisp.Text == "0")
                    {
                        textdisp.Text = "invalid";
                        MessageBox.Show("invalid");
                        checker.Text = checker.Text + textdisp.Text;
                    }
                    else
                    {
                        textdisp.Text = (results / Double.Parse(textdisp.Text)).ToString();
                        checker.Text = checker.Text + Math.Round(Convert.ToDecimal(textdisp.Text), 3);
                    }
                    break;
                case "×":
                    textdisp.Text = (results * Double.Parse(textdisp.Text)).ToString();
                    checker.Text = checker.Text + Math.Round(Convert.ToDecimal(textdisp.Text), 3);
                    break;
                case "%":
                    textdisp.Text = (results % Double.Parse(textdisp.Text)).ToString();
                    checker.Text = checker.Text + Math.Round(Convert.ToDecimal(textdisp.Text), 3);
                    break;
                case "^":
                    if (results == 0 && Double.Parse(textdisp.Text) == -1)
                    {
                        textdisp.Text = "invalid";
                        checker.Text = checker.Text + textdisp.Text;
                    }
                    else
                    {
                        textdisp.Text = (Math.Pow(results, Double.Parse(textdisp.Text))).ToString();
                        checker.Text = checker.Text + Math.Round(Convert.ToDecimal(textdisp.Text), 3);
                    }
                    break;
                case "√":
                    if (results <= 0)
                    {
                        textdisp.Text = "invalid";
                        checker.Text = "√" + checker.Text + textdisp.Text;
                    }
                    else
                    {
                        textdisp.Text = (Math.Sqrt(results)).ToString();
                        checker.Text = "√" + checker.Text + Math.Round(Convert.ToDecimal(textdisp.Text), 3);
                    }
                    break;
                case "^-1":
                    if (results == 0)
                    {
                        textdisp.Text = "invalid";
                        checker.Text = checker.Text + "^-1" + " = " + textdisp.Text;
                    }
                    else
                    {
                        textdisp.Text = (1 / results).ToString();
                        checker.Text = checker.Text + "^-1" + Math.Round(Convert.ToDecimal(textdisp.Text), 3);
                    }
                    break;
                case "sin":
                    inputvalue = textdisp.Text;
                    textdisp.Text = (Math.Sin(results*(Math.PI)/180)).ToString();
                    checker.Text = "sin " + inputvalue + " = " + Math.Round(Convert.ToDecimal(textdisp.Text), 3);
                    break;
                case "cos":
                    inputvalue = textdisp.Text;
                    textdisp.Text = (Math.Cos(results * (Math.PI) / 180)).ToString();
                    checker.Text = "cos " + inputvalue + " = " + Math.Round(Convert.ToDecimal(textdisp.Text), 3);
                    break;
                case "tan":
                    inputvalue = textdisp.Text;
                    textdisp.Text = (Math.Tan(results * (Math.PI) / 180)).ToString();
                    checker.Text = "tan " + inputvalue + " = " + Math.Round(Convert.ToDecimal(textdisp.Text), 3);
                    break;
                case "ln":
                    if (results <= 0)
                    {
                        textdisp.Text = "invalid";
                        checker.Text = "ln" + checker.Text + textdisp.Text;
                    }

                    else
                    {
                        textdisp.Text = (Math.Log(results)).ToString();
                        checker.Text = "ln" + checker.Text + Math.Round(Convert.ToDecimal(textdisp.Text), 3);
                    }
                    break;
            }
            DateTime today = DateTime.Now;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("insert into calculations (calculation)Values('"+checker.Text+"',connection");
            connection.Close();
            populategrid();
        }


        private void pi_pressed(object sender, EventArgs e)
        {
            textdisp.Text = "3.14159265359";
        }

        private void negative_pressed(object sender, EventArgs e)
        {
            if (textdisp.Text == "")
            {
                textdisp.Text = "-";
            }
            else if (textdisp.Text != "")
            {
                textdisp.Text = "";
                results = 0;
                indicator.Text = "";
                MessageBox.Show("Please assign the negative operator first");
            }
            else
            {
                double negativeInput = -1 * Double.Parse(textdisp.Text);
                textdisp.Text = negativeInput.ToString();
                results = Double.Parse(textdisp.Text);
            }
            

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            populategrid();
        }

        public void populategrid()
        {
            string selectQuery = "SELECT * FROM calculations";

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT *FROM calculations.calculations, connection");
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
