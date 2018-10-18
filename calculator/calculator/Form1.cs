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
        string s = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            s = s + "4";
            textbox.Text = s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = s + "1";
            textbox.Text = s;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            s = s + "2";
            textbox.Text = s;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            s = s + "3";
            textbox.Text = s;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s = s + "5";
            textbox.Text = s;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s = s + "6";
            textbox.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s = s + "7";
            textbox.Text = s;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            s = s + "8";
            textbox.Text = s;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            s = s + "9";
            textbox.Text = s;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            s = s + "0";
            textbox.Text = s;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            s = "";
            textbox.Text = s;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            s = s + "+";
            textbox.Text = s;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            s = s + "-";
            textbox.Text = s;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            s = s + "*";
            textbox.Text = s;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            s = s + "/";
            textbox.Text = s;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for(int w = 0; w < s.Length; w++)
            {
                if (s[w] == '+')
                {

                    int sum = 0;
                    string[] str = s.Split('+');
                    int[] i = new int[str.Length];
                    for (int q = 0; q < i.Length; q++)
                    {
                        i[q] = Convert.ToInt32(str[q]);
                        sum = sum + i[q];
                    }
                    s = Convert.ToString(sum);
                    textbox.Text = s;
                }
                else if (s[w] == '-')
                {

                    
                    string[] str = s.Split('+');
                    int[] i = new int[str.Length];
                    for (int q = 0; q < i.Length; q++)
                        i[q] = Convert.ToInt32(str[q]);
                    int diff = i[w] - i[w - 1];
                    if (i.Length > 2)
                    {
                        for (int r = 2; r < i.Length; r++)
                            diff = diff - i[r];

                    }


                    s = Convert.ToString(diff);
                    textbox.Text = s;
                }
            }
            


        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
                textbox.Text = s;
            }
            
        }
    }
}
