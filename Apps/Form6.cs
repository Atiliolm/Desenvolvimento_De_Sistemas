using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apps
{
    public partial class Palavras_Manip : Form
    {
        List<string> Store1 = new List<string>();
        List<string> Store2 = new List<string>();
        string palavra;

        public Palavras_Manip()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void Palavras_Manip_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            palavra = Convert.ToString(textBox1.Text);
            listBox1.Items.Add(palavra);
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            palavra = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
            var Form1 = new Menu();
            Form1.Show();
        }
    }
}
