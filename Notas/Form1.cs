using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    public partial class Form1 : Form
    {

        Single n1, n2, n3, media;
        public Form1()
        {
            InitializeComponent();
        }

        private void btmLimp_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            n3 = 0;
            media = 0;
            txtFin.Clear();
            txtLab.Clear();
            txtSem.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmSair_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btmCalc_Click(object sender, EventArgs e)
        {
            n1 = Single.Parse(txtLab.Text);
            n2 = Single.Parse(txtSem.Text);
            n3 = Single.Parse(txtFin.Text);
            media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
            MessageBox.Show("Média: " + media, "Média", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
