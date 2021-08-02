using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1
{
    public partial class txtV1 : Form
    {
        Single n1, n2, resp;

        public object MessageIcon { get; private set; }

        public txtV1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtV2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = Single.Parse(txtV1.Text);
            n2 = Single.Parse(txtV2.Text);
            resp = n1 + n2;
            MessageBox.Show("Resultado Soma: " + resp, MessageBoxButtons.OK, MessageBoxIcon.Question);


        }
    }
}
