using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZZA_PARLOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentValue = 0d;

            if (radioButton1.Checked) currentValue += 200;
            if (radioButton2.Checked) currentValue += 250;
            if (radioButton4.Checked) currentValue += 300;
            if (radioButton3.Checked) currentValue += 350;

            if (radioButton8.Checked) currentValue += 100;
            if (radioButton7.Checked) currentValue += 150;
            if (radioButton6.Checked) currentValue += 200;
            if (radioButton5.Checked) currentValue += 250;

            if (checkBox1.Checked) currentValue += 50;
            if (checkBox4.Checked) currentValue += 40;
            if (checkBox6.Checked) currentValue += 50;
            if (checkBox2.Checked) currentValue += 20;
            if (checkBox3.Checked) currentValue += 40;
            if (checkBox5.Checked) currentValue += 30;

            if (radioButton12.Checked)
            {
                var subtract = currentValue * 0.05;
                currentValue -= subtract;
            }

            if (radioButton11.Checked)
            {
                var subtract = currentValue * 0.1;
                currentValue -= subtract;
            }

            if (radioButton10.Checked)
            {
                var subtract = currentValue * 0.15;
                currentValue -= subtract;
            }

            textBox1.Text = currentValue.ToString();
            textBox3.Text = $"{Math.Abs(currentValue - double.Parse(textBox2.Text))}";
        }
    }
}