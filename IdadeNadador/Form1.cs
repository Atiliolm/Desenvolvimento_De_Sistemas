using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdadeNadador
{
    public partial class Form1 : Form
    {
        int idade;
           
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                idade = int.Parse(txtIdade.Text);

                if (idade >= 5 && idade <= 7)
                {
                    MessageBox.Show("Infantil - A: " + idade, "Faixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (idade >= 8 || idade <= 10)
                {
                    MessageBox.Show("Infantil - B: " + idade, "Faixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (idade >= 11 && idade <= 13)
                {
                    MessageBox.Show("Juvenil - A: " + idade, "Faixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (idade >= 14 && idade <= 17)
                {
                    MessageBox.Show("Juvenil - B: " + idade, "Faixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (idade >= 18 && idade <= 25)
                {
                    MessageBox.Show("Sênior: " + idade, "Faixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Fora das Faixas Etárias: " + idade, "Faixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception){
                MessageBox.Show("ERROR ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
