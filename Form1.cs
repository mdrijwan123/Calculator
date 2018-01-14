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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num, ans;
        int count;
        public void disable()
        {
            textbox.Enabled = false;
            OFF_Click.Hide();
            ON_Click.Show();
            one.Enabled = false;
            two.Enabled = false;
            three.Enabled = false;
            four.Enabled = false;
            five.Enabled = false;
            six.Enabled = false;
            seven.Enabled = false;
            eight.Enabled = false;
            nine.Enabled = false;
            zero.Enabled = false;
            point.Enabled = false;
            zero.Enabled = false;
            mult.Enabled = false;
            div.Enabled = false;
            equal.Enabled = false;
            clr.Enabled = false;
            clre.Enabled = false;
            plus.Enabled = false;
            minus.Enabled = false;

            
        }
        public void enable()
        {
            textbox.Enabled = true;
            OFF_Click.Show();
            ON_Click.Hide();
            one.Enabled = true;
            two.Enabled = true;
            three.Enabled = true;
            four.Enabled = true;
            five.Enabled = true;
            six.Enabled = true;
            seven.Enabled = true;
            eight.Enabled = true;
            nine.Enabled = true;
            zero.Enabled = true;
            point.Enabled = true;
            zero.Enabled = true;
            mult.Enabled = true;
            div.Enabled = true;
            equal.Enabled = true;
            clr.Enabled = true;
            clre.Enabled = true;
            plus.Enabled = true;
            minus.Enabled = true;
            
        }
        private void one_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0")
            {
                textbox.Clear();
            }
            textbox.Text = textbox.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0")
            {
                textbox.Clear();
            }
            textbox.Text = textbox.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0")
            {
                textbox.Clear();
            }
            textbox.Text = textbox.Text + "3";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0")
            {
                textbox.Clear();
            }
            textbox.Text = textbox.Text + "6";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0")
            {
                textbox.Clear();
            }
            textbox.Text = textbox.Text + "5";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0")
            {
                textbox.Clear();
            }
            textbox.Text = textbox.Text + "4";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0")
            {
                textbox.Clear();
            }
            textbox.Text = textbox.Text + "9";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0")
            {
                textbox.Clear();
            }
            textbox.Text = textbox.Text + "7";
        }

        private void point_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + ".";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            num = float.Parse(textbox.Text);
            textbox.Clear();
            textbox.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            num = float.Parse(textbox.Text);
            textbox.Clear();
            textbox.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            num = float.Parse(textbox.Text);
            textbox.Clear();
            textbox.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void clre_Click(object sender, EventArgs e)
        {
            textbox.Clear();
        }

        private void clr_Click(object sender, EventArgs e)
        {
            int numb = textbox.TextLength-1;
            string str = textbox.Text;
            textbox.Clear();
            for(int i = 0; i < numb; i++)
                textbox.Text = textbox.Text + str[i];
            
            
        }

        private void equal_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = "";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0")
            {
                textbox.Clear();
            }
            textbox.Text = textbox.Text + "8";
        }

        private void div_Click(object sender, EventArgs e)
        {
            num = float.Parse(textbox.Text);
            textbox.Clear();
            textbox.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void ON_Click_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void compute()
        {
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(textbox.Text);
                    textbox.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(textbox.Text);
                    textbox.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textbox.Text);
                    textbox.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textbox.Text);
                    textbox.Text = ans.ToString();
                    break;
                default: textbox.Text = "Invalid";
                    break;
            }
        }

    }
}
