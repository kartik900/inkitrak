using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorv2
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        string op = "";
        bool op_p = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (op_p)
                label1.Text = result.Text + op;
            if ((result.Text == "0")|| (op_p))
                result.Clear();
            
            
            op_p=false;
            result.Text = result.Text + b.Text;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            result.Text = "0";
            label1.Text = "";
        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            result.Clear();
            result.Text = "0";

        }
        private void op_Click(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;

            op = b1.Text;
            num1 = Double.Parse(result.Text);
            op_p = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
           // Double num2 = Convert.ToDouble(result.Text);
            switch (op)
            {
                case "+":
                    result.Text = Convert.ToString(num1 + Convert.ToDouble(result.Text));
                    break;
                case "-":
                    result.Text = Convert.ToString(num1 - Convert.ToDouble(result.Text));
                    break;
                case "*":
                    result.Text = Convert.ToString(num1 * Convert.ToDouble(result.Text));
                    break;
                case "/":
                    result.Text = Convert.ToString(num1 / Convert.ToDouble(result.Text));
                    break;
                default:
                    break;

            }
            op_p = false;
        }
    }
}
