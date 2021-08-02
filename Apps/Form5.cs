using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apps
{
    public partial class Tabuada_Init_End : Form
    {
        int init, fin;
        public Tabuada_Init_End()
        {
            InitializeComponent();
        }

        private void btmLimp_Click(object sender, EventArgs e)
        {
            init = 0;
            fin = 0;
            listBox1.Items.Clear();
            txtInit.Text = "";
            txtEnd.Text = "";
        }

        private void btmMenu_Click(object sender, EventArgs e)
        {
            Close();
            var Form1 = new Menu();
            Form1.Show();
        }

        private void btmExec_Click(object sender, EventArgs e)
        {
            init = Convert.ToInt32(txtInit.Text);
            fin= Convert.ToInt32(txtEnd.Text);

            for (int i = init; i <= fin; i++)
            {
                for (int mult = 0; mult <= 10; mult++)
                {
                    if (mult == 0) {
                        listBox1.Items.Add("---");
                    }
                    listBox1.Items.Add(i + "X" + mult + "=" + i * mult);
                }
            }
        }
    }
}

