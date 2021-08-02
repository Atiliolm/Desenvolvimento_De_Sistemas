using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maior
{
    public partial class Form1 : Form
    {
        int v1, v2, v3, resp;
            
        public Form1()
        {
            InitializeComponent();
        }

        private void btmVericar_Click(object sender, EventArgs e)
        {
            try
            {
                v1 = int.Parse(txtV1.Text);
                v2 = int.Parse(txtV2.Text);
                v3 = int.Parse(txtV3.Text);

                if (v1 > v2 && v2 > v3)
                {
                    MessageBox.Show("O maior numero é: " + v1, "Maior", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (v2 > v3)
                {
                    MessageBox.Show("O maior numero é: " + v2, "Maior", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("O maior numero é: " + v3, "Maior", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception) {
                MessageBox.Show("ERRO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btmReset_Click(object sender, EventArgs e)
        {
            v1 = 0;
            v2 = 0;
            v3 = 0;
            txtV1.Text = "";
            txtV2.Text = "";
            txtV3.Text = "";

        }

        private void btmDesligar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
