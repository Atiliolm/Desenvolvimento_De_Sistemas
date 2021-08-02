using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delta
{
    public partial class Form1 : Form
    {
        float a, b, c, delta;
        double x1, x2;
        string deltat, x1t, x2t;
            
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(txtA.Text);
                b = float.Parse(txtB.Text);
                c = float.Parse(txtC.Text);


                delta = ((b * b) - 4 * a * c);

                if (delta < 0)
                {
                    deltat = Convert.ToString(delta);
                    lblDelta.Text = deltat;
                    lblX1.Text = "Não possui raiz";
                    lblX2.Text = "Não possui raiz";
                }
                else if (delta == 0)
                {
                    deltat = Convert.ToString(delta);
                    lblDelta.Text = deltat;
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x1t = Convert.ToString(x1);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2t = Convert.ToString(x2);
                    lblX1.Text = x1t;
                    lblX2.Text = x2t;
                }
                else if (delta > 0)
                {
                    deltat = Convert.ToString(delta);
                    lblDelta.Text = deltat;
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x1t = Convert.ToString(x1);
                    x2t = Convert.ToString(x2);
                    lblX1.Text = x1t;
                    lblX2.Text = x2t;

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
