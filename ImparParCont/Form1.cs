using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImparParCont
{
    public partial class Form1 : Form
    {
        int num, qtdp, qtdi, para, tot;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            calcular();
        }

        void calcular()
        {
            para = 0;
            para++;

            for (int i = 0; i < para; i++)
            {
                num = Convert.ToInt32(textBox1.Text);

                if (num % 2 == 0)
                {
                    qtdp++;
                    tot = tot + 1;
                    
                }
                else
                {
                    qtdi++;
                    tot = tot + 1;
                }
            }
            lblImp.Text = Convert.ToString(qtdi);
            lblPar.Text = Convert.ToString(qtdp);
            lblTot.Text = Convert.ToString(tot);
        }
    }
}
