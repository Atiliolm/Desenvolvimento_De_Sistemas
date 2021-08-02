using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaldoCheque
{
    public partial class Form1 : Form
    {
        float saldo, c1, c2, c3;
        string sit1, sit2, sit3, sfin;

        private void label5_Click(object sender, EventArgs e)
        {
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btmSair_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btmCalc_Click(object sender, EventArgs e)
        {
            try
            {
                saldo = float.Parse(txtSaldo.Text);
                c1 = float.Parse(txtC1.Text);
                c2 = float.Parse(txtC2.Text);
                c3 = float.Parse(txtC3.Text);


                if (saldo > c1)
                {
                    saldo = saldo - c1;
                    lblSit1.Text = "Valor descontado";
                }
                else {
                    lblSit1.Text = "Saldo Insuficiente";
                }
                if (saldo > c2)
                {
                    saldo = saldo - c2;
                    lblSit2.Text = "Valor descontado";
                }
                else {
                    lblSit2.Text = "Saldo Insuficiente";
                }
                if (saldo > c3)
                {
                    saldo = saldo - c3;
                    lblSit3.Text = "Valor descontado";
                }
                else
                {
                    lblSit3.Text = "Saldo Insuficiente";
                }

                lblFinal.Text = Convert.ToString(saldo);
            }
            catch (Exception){
                MessageBox.Show("ERRO","ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            

        }
    }
}
