using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apps
{
    public partial class Fibonnaci : Form
    {
        int seq1, seq2, cont;
        public Fibonnaci()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Fibonnaci_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            var Form1 = new Menu();
            Form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seq2 = 1;
            seq1= 0;
            cont = 0 ;

            while (cont < 50)
            {
                cont = cont + 1;
                listBox1.Items.Add(Convert.ToString(seq1));
                seq1 = seq1 + seq2;
                seq2 = seq1 - seq2;
                if (seq1 == 0)
                {
                    seq1 = seq1++;
                }
            }
        }
    }
}
