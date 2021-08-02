using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorasTrabalhadas
{
    public partial class Form1 : Form
    {
        Single horas, valor, desconto, sbruto, sliq;

        private void btmSair_Click(object sender, EventArgs e)
        {
            Application.ExitThread();

        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            txtDesc.Clear();
            txtHora.Clear();
            txtValor.Clear();
            horas = 0;
            valor = 0;
            desconto = 0;
            sbruto = 0;
            sliq = 0;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btmCalc_Click(object sender, EventArgs e)
        {
            horas = Single.Parse(txtHora.Text);
            valor = Single.Parse(txtValor.Text);
            desconto = Single.Parse(txtDesc.Text);
            sbruto = horas * valor;
            sliq = horas * valor - desconto;
            MessageBox.Show("Salario Bruto: " + sbruto + " Salario Liquido: " + sliq, "Salario", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
    }
}
