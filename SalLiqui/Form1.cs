using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalLiqui
{
    public partial class Form1 : Form
    {
        Double sb, inss, sl, vhora, diast, ir, dval, desc, dep, ircalc;

        private void button2_Click(object sender, EventArgs e)
        {
            sb = 0;
            inss = 0;
            sl = 0;
            vhora = 0;
            diast = 0;
            ir = 0;
            dval = 0;
            desc = 0;
            dep = 0;
            ircalc = 0;
            lblDesc.Text = "???";
            lblNome.Text = "???";
            lblSb.Text = "???";
            lblSl.Text = "???";
            txtAulaD.Text = "";
            txtDep.Text = "";
            txtNome.Text = "";
            txtVAula.Text = "";


        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                diast = Convert.ToDouble(txtAulaD.Text);
                vhora = Convert.ToDouble(txtVAula.Text);
                dep = Convert.ToDouble(txtDep.Text);
                sb = vhora * diast * 4.5;

                if (sb <= 1100.00)
                {
                    inss = (sb * 0.075) - 0;

                }
                else if (sb <= 2203.48)
                {
                    inss = (sb * 0.09) - 16.5;
                }
                else if (sb <= 3305.22)
                {
                    inss = (sb * 0.12) - 82.6;
                }
                else if (sb <= 2203.48)
                {
                    inss = (sb * 0.14) - 148.71;
                }
                else
                {
                    inss = 751.98;
                }

                dval = dep * 189.59;
                ircalc = sb - inss - dval;

                if (ircalc <= 1903.98)
                {

                    ir = (ircalc * 0) - 0;
                }
                else if (ircalc <= 2826.65)
                {
                    ir= (ircalc * 0.075) - 142.8;
                }
                else if (ircalc <= 3751.05)
                {
                    ir = (ircalc * 0.15) - 354.8;
                }
                else if (ircalc <= 4664.68)
                {
                    ir = (ircalc * 0.225) - 636.13;
                }
                else
                {
                    ir = (ircalc * 0.275) - 869.36;
                }

                sl = sb - inss - ir;
                desc = sb - sl;
                lblDesc.Text = "R$" + Convert.ToString(Math.Round(desc, 2));
                lblSb.Text = "R$" + Convert.ToString(Math.Round(sb, 2));
                lblSl.Text = "R$" + Convert.ToString(Math.Round(sl, 2));
                lblNome.Text = txtNome.Text;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }
    }
}
