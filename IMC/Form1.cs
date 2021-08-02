using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        float altura, peso, imc;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            altura = 0;
            peso = 0;
            imc = 0;
            txtAltura.Text = "";
            txtPeso.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                altura = float.Parse(txtAltura.Text);
                peso = float.Parse(txtPeso.Text);

                imc = peso / (altura * altura);

                if (imc < 18.5)
                {
                    MessageBox.Show("IMC: " + imc + " Magro.", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (imc >= 18.5 && imc < 25)
                {
                    MessageBox.Show("IMC: " + imc + " Normal.", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (imc >= 25 && imc < 30)
                {
                    MessageBox.Show("IMC: " + imc + " Obeso.", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("IMC: " + imc + " Obeso Morbido.", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception) {
                MessageBox.Show("ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
