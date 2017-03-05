using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmcalculator : Form
    {
      
        public void docalc(double n1, double n2, int op)
        {
            result = 0;
            setText("clear");
            switch (op)
            {
                case 1:
                    result = n1 + n2;
                    break;
                case 2:
                    result = n1 - n2;
                    break;
                case 3:
                    result = n1 * n2;
                    break;
                case 4:
                    result = n1 / n2;
                    break;
            }
            setText(result.ToString());
        }
        public void ifequal()
        {
            num2 = double.Parse(textBox1.Text);
            docalc(num1, num2, opMain);
            isfirst = false;
        }
        public void setOperator(int op)
        {
            string temp;
            opMain = op;
            num1 = double.Parse(textBox1.Text);
            temp = textBox1.Text;
            setText("clear");
            setText(temp);
            issecond = true;
        }
        public void doequal()
        {
            num2 = double.Parse(textBox1.Text);
        }

        public void setText(string text)
        {
            if (text == "clear")
                textBox1.Text = "";
            else
            {
                if (issecond)
                    textBox1.Text = "";
                issecond = false;
                textBox1.Text += text;
            }
        }
        public frmcalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "1";
            setText("1");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("button was clicked");
            //if(sender == button1)

            //textBox1.Text="2";
            setText("2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "3";
            setText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "4";
            setText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "5";
            setText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "6";
            setText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "7";
            setText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "8";
            setText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "9";
            setText("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "0";
            setText("0");
        }

        private void add_Click(object sender, EventArgs e)
        {
            //setText("+");
            setOperator(1);
        }

        private void sub_Click(object sender, EventArgs e)
        {
            setOperator(2);
        }

        private void multi_Click(object sender, EventArgs e)
        {
            setOperator(3);
        }

        private void div_Click(object sender, EventArgs e)
        {
            setOperator(4);
        }

        private void eql_Click(object sender, EventArgs e)
        {
            ifequal();
        }

        private void dot_Click(object sender, EventArgs e)
        {
            setText(".");
            setOperator(6);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            setText("clear");
        }

        private void _Click(object sender, EventArgs e)
        {
            setText("clear");
        }

        private void off_Click(object sender, EventArgs e)
        {
            //System.ApplicationException.Exit;
            Application.Exit();
        }

    }
}
