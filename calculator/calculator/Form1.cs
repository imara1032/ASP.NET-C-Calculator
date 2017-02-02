using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double value = 0.0;
        string operation = "";
        Boolean operation_presed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || operation_presed)
                result.Clear();

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            equation.Text = "";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            operation_presed = true;
            Button b = (Button)sender;
            value = Double.Parse(result.Text);
            operation = b.Text;
            equation.Text = value + " " + b.Text;

        }

        private void equal_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation){
                case "+":
                    result.Text=(value+ Double.Parse(result.Text) ).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            
            }
            operation_presed = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0.0;
            equation.Text = ""; 
        }
    }
}
