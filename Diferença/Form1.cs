using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diferença
{
    public partial class Form1 : Form
    {
        int n1, n2, dif;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = int.Parse(txtN1.Text);
                n2 = int.Parse(txtN2.Text);

                if (n1 > n2)
                {
                    dif = n1 - n2;
                    MessageBox.Show("Diferença de: " + dif, "Diferença", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dif = n2 - n1;
                    MessageBox.Show("Diferença de: " + dif, "Diferença", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch {
                MessageBox.Show("ERRO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            txtN1.Text = "";
            txtN2.Text = "";
            dif = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
