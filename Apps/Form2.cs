using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apps
{
    public partial class Tabuada : Form
    {
        int num, result;
        public Tabuada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            var Form1 = new Menu();
            Form1.Show();
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.Items.Clear();
            listBox1.Items.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            num = Convert.ToInt32(textBox1.Text);
            for (int mult = 0; mult <= 9;)
            {
                mult++;
                result = num * mult;
                comboBox1.Items.Add(Convert.ToString(num) + " x " + Convert.ToString(mult) + " = " + result);
                listBox1.Items.Add(Convert.ToString(num) + " x " + Convert.ToString(mult) + " = " + result);
            }
        }
    }
}
