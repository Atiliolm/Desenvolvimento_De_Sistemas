using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        Single n1, n2, resp;
        public Form1()
        {
            InitializeComponent();
        }

        private void btmSub_Click(object sender, EventArgs e)
        {
            n1 = Single.Parse(txtV1.Text);
            n2 = Single.Parse(txtV2.Text);
            resp = n1 - n2;
            MessageBox.Show("Resultado: " + resp, "Subtração", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btmDiv_Click(object sender, EventArgs e)
        {
            n1 = Single.Parse(txtV1.Text);
            n2 = Single.Parse(txtV2.Text);
            resp = n1 / n2;
            MessageBox.Show("Resultado: " + resp, "Divisão", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btmMult_Click(object sender, EventArgs e)
        {
            n1 = Single.Parse(txtV1.Text);
            n2 = Single.Parse(txtV2.Text);
            resp = n1 * n2;
            MessageBox.Show("Resultado: " + resp, "Multiplicação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            txtV1.Clear();
            txtV2.Clear();
            resp = 0;
        }

        private void btmSair_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmSoma_Click(object sender, EventArgs e)
        {
            n1 = Single.Parse(txtV1.Text);
            n2 = Single.Parse(txtV2.Text);
            resp = n1 + n2;
            MessageBox.Show("Resultado: " + resp, "Soma", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
