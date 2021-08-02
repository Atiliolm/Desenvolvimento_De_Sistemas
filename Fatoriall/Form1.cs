using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatoriall
{
    public partial class Form1 : Form
    {
        int num, fat, cont;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = 0;
            txtNum.Text = "";
            fat= 1;
            cont = 1;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            cont = 1;
            fat = 1;
            num = Convert.ToInt32(txtNum.Text);
            while (cont <= num)
            {
                fat = fat * cont;
                cont = cont + 1;
         
            }
            MessageBox.Show("Fatorial de: " + num + " é: " + fat, "Fatorial", MessageBoxButtons.OK, MessageBoxIcon.Information);

        
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
