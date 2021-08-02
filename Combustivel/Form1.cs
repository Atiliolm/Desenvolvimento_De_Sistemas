using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combustivel
{
    public partial class Form1 : Form
    {

        Single kml, velo, tempo, luso, dist;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            velo = Single.Parse(txtVelo.Text);
            kml = Single.Parse(txtKml.Text);
            tempo = Single.Parse(txtTemp.Text);
            dist = tempo * velo;
            luso = dist * kml;
            MessageBox.Show("Velocidade Média: " + velo + "; Tempo de viagem: " + tempo + "; Distância: " + dist + "; Litros Utilizados: " + luso, "Litros Utilizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            velo = 0;
            kml = 0;
            tempo = 0;
            dist = 0;
            luso = 0;
            txtVelo.Clear();
            txtTemp.Clear();
            txtKml.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
