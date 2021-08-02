using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultCont
{
    public partial class Form1 : Form
    {

        float v1, v2, resp;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            op = btmSoma.Text;
        }

        private void btmSub_Click(object sender, EventArgs e)
        {
            op = btmSub.Text;
        }

        private void btmMult_Click(object sender, EventArgs e)
        {
            op = btmMult.Text;
        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            txtV1.Clear();
            txtV2.Clear();
            op = "";
            resp = 0;
            v1 = 0;
            v2 = 0;
        }

        private void btmSair_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btmDiv_Click(object sender, EventArgs e)
        {
            op = btmDiv.Text;
        }

        private void btmCalc_Click(object sender, EventArgs e)
        {
            try
            {
                v1 = float.Parse(txtV1.Text);
                v2 = float.Parse(txtV2.Text);

                if (op == "+")
                {
                    resp = v1 + v2;
                    MessageBox.Show("Resultado: " + resp, "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (op == "-")
                {
                    resp = v1 - v2;
                    MessageBox.Show("Resultado: " + resp, "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (op == "*")
                {
                    resp = v1 * v2;
                    MessageBox.Show("Resultado: " + resp, "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (op == "/")
                {
                    resp = v1 / v2;
                    MessageBox.Show("Resultado: " + resp, "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Erro", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
