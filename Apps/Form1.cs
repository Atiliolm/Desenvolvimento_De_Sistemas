using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apps
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form2 = new Tabuada();
            Form2.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form3 = new ParImpar();
            Form3.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form4 = new Fibonnaci();
            Form4.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form5 = new Tabuada_Init_End();
            Form5.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form6 = new Palavras_Manip();
            Form6.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form7 = new Frases_Manip();
            Form7.Show();
        }
    }
}
