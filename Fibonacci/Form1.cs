using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {

        int fib, x, y, z;

        private void button3_Click(object sender, EventArgs e)
        {
            fib = 0;
            x = 0;
            y = 0;
            lblSequencia.Text = "...";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fib = Convert.ToInt32(txtFib.Text);
            x = 1;
            y = 0;
            z = 0;
            lblSequencia.Text = y + ", " + x;
            fib = fib - 2;
            if (fib == 0)
            {
                lblSequencia.Text = "0";

            }
            else if (fib == 1)
            {
                lblSequencia.Text = "0,1";
            }
            else
            {

                while (fib > 0)
                {
                    z = x + y;
                    lblSequencia.Text += ", " + z;
                    y = x;
                    x = z;

                    fib = fib - 1;
                }

            }
        }

    }
}
