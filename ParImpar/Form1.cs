using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParImpar
{
    public partial class Form1 : Form
    {
        int num;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                num = int.Parse(txtNum.Text);

                if (num % 2 == 0)
                {
                    MessageBox.Show("Número Par!", "Pai/Impar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Número Impar!", "Pai/Impar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception) { 
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
