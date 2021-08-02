using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertMoeda
{
    public partial class Form1 : Form
    {

        Single valor, cot, reais;

        private void btmLimp_Click(object sender, EventArgs e)
        {
            valor = 0;
            cot = 0;
            reais = 0;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btmSair_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor = Single.Parse(textBox1.Text);
            cot = Single.Parse(textBox2.Text);
            reais = valor * cot;
            MessageBox.Show("Valor em R$: " + reais, "Cotação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
