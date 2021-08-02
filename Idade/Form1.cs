using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idade
{
    public partial class Form1 : Form

    {
        String nome;
        Single idade, meses, dias, horas;

        private void btmSair_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btmLimp_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();
            idade = 0;
            meses = 0;
            dias = 0;
            horas = 0;
            

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btmCalc_Click(object sender, EventArgs e)
        {
            
            idade = Single.Parse(txtIdade.Text);
            meses = idade * 12;
            dias = idade * 365;
            horas = idade * 8760;
            MessageBox.Show ( txtNome.Text +  "  Você tem: " + meses + " Meses de vida ou " + dias + " Dias de vida ou " + horas + " horas de vida", "IDADE", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
