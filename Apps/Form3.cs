using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apps
{
    public partial class ParImpar : Form
    {

        int num, tot, totp, toti, soma, somap, somai;
        public ParImpar()
        {
            InitializeComponent();
        }

        private void ParImpar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            num = 0;
            tot = 0;
            toti = 0;
            totp = 0;
            soma = 0;
            somap = 0;
            somai = 0;
            lblQtdI.Text = "";
            lblQtdP.Text = "";
            lblQtdT.Text = "";
            lblSomaT.Text = "";
            lblSomaI.Text = "";
            lblSomap.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblQtdP_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            var Form1 = new Menu();
            Form1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            num = Convert.ToInt32(textBox1.Text);
            tot = tot + 1;
            soma = soma + num;
            lblQtdT.Text = Convert.ToString(tot);
            lblSomaT.Text = Convert.ToString(soma);


            if (num % 2 == 0)
            {
                totp++;
                somap = somap + num;
                listBox1.Items.Add(Convert.ToString(num));
                lblQtdP.Text = Convert.ToString(totp);
                lblSomap.Text = Convert.ToString(somap);
            }
            else {
                toti++;
                somai = somai + num;
                listBox2.Items.Add(Convert.ToString(num));
                lblSomaI.Text = Convert.ToString(somai);
                lblQtdI.Text = Convert.ToString(toti);

            }
        }
    }
}
