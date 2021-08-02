using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apps
{
    public partial class Frases_Manip : Form
    {
        string frase, invert;
        int tamanho, vA, vE, vI, vO, vU;
        List<string> wordStorage = new List<string>();

        private void btmPalin_Click(object sender, EventArgs e)
        {
            invert = txtFrase.Text;

            char[] chararray = invert.ToCharArray();
            Array.Reverse(chararray);
            string inverso = new string(chararray);

            if (inverso == invert)
            {
                MessageBox.Show("Esta Frase é um Palíndromo!");
            }
            else
            {
                MessageBox.Show("Esta Frase NÃO é um Palíndromo!");
            }
            inverso = "";
            btmPalin.Enabled = false;
        }

        private void btmVog_Click(object sender, EventArgs e)
        {
            int count;

            for (int i = 0; i < txtFrase.Text.Length; i++)
            {
                frase = Convert.ToString(txtFrase.Text[i]);
                wordStorage.Add(frase.ToUpper());
            }

            count = Convert.ToInt32(wordStorage.Count);


            for (int i = 0; i < count; i++)
            {
                if ((wordStorage[i] == "A") || (wordStorage[i] == "Á") || (wordStorage[i] == "À") || (wordStorage[i] == "Â") || (wordStorage[i] == "Ã"))
                {
                    vA++;

                }
                else if ((wordStorage[i] == "E") || (wordStorage[i] == "É") || (wordStorage[i] == "Ê") || (wordStorage[i] == "È"))
                {
                    vE++;

                }
                else if ((wordStorage[i] == "I") || (wordStorage[i] == "Ì") || (wordStorage[i] == "Í"))
                {
                    vI++;

                }
                else if ((wordStorage[i] == "O") || (wordStorage[i] == "Ó") || (wordStorage[i] == "Ò") || (wordStorage[i] == "Ô") || (wordStorage[i] == "Õ"))
                {
                    vO++;

                }
                else if ((wordStorage[i] == "U") || (wordStorage[i] == "Ú") || (wordStorage[i] == "Ù") || (wordStorage[i] == "Û"))
                {
                    vU++;

                }

                lblA.Text = Convert.ToString(vA);
                lblE.Text = Convert.ToString(vE);
                lblI.Text = Convert.ToString(vI);
                lblO.Text = Convert.ToString(vO);
                lblU.Text = Convert.ToString(vU);
                btmVog.Enabled = false;
                wordStorage.Clear();

            }
        }

        private void btmInv_Click(object sender, EventArgs e)
        {
            invert = txtFrase.Text;

            char[] chararray = invert.ToCharArray();
            Array.Reverse(chararray);
            string reversedText = new string(chararray);
            lblInv.Text = reversedText;
            reversedText = "";
            btmInv.Enabled = false;
        }

        private void btmLetra_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (char _char in txtFrase.Text)
            {
                listBox1.Items.Add(_char);
            }
            btmLetra.Enabled = false;
        }

        private void btmPal_Click(object sender, EventArgs e)
        {
            string PhraseBroken;

            PhraseBroken = "";
            int i = txtFrase.Text.Length;

            for (int c = 0; c < i; c++)
            {
                if (Convert.ToString(txtFrase.Text[c]) != " ")
                {
                    PhraseBroken += txtFrase.Text[c];
                }
                else
                {
                    listBox2.Items.Add(PhraseBroken);
                    PhraseBroken = "";
                }
            }
            listBox2.Items.Add(PhraseBroken);
            btmPal.Enabled = false;
        }

        private void bmLimp_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            frase = "";
            invert = "";
            tamanho = 0;
            vA = 0;
            vE = 0;
            vI = 0;
            vO = 0;
            vU = 0;
            lblA.Text = "...";
            lblE.Text = "...";
            lblI.Text = "...";
            lblO.Text = "...";
            lblU.Text = "...";
            lblCac.Text = "...";
            lblInv.Text = "...";
            lblSE.Text = "...";
            txtFrase.Text = "...";
            btmCac.Enabled = true;
            btmInv.Enabled = true;
            btmLetra.Enabled = true;
            btmPal.Enabled = true;
            btmPalin.Enabled = true;
            btmVog.Enabled = true;
            button5.Enabled = true;

        }

        private void btmAll_Click(object sender, EventArgs e)
        {
            cac();
            inverter();
            vogais();
            palindrome();
            espacos();
            letra();
            palavra();
        }
        public Frases_Manip()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frase = txtFrase.Text;
            lblSE.Text = Convert.ToString(frase.Replace(" ", ""));
            button5.Enabled = false;
        }

        private void Frases_Manip_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btmMenu_Click(object sender, EventArgs e)
        {
            Close();
            var Form1 = new Menu();
            Form1.Show();
        }
        
        private void btmCac_Click(object sender, EventArgs e)
        {
            frase = txtFrase.Text;
            tamanho = frase.Length;
            lblCac.Text = Convert.ToString(tamanho);
            btmCac.Enabled = false;
        }
        public void cac()
        {
            frase = txtFrase.Text;
            tamanho = frase.Length;
            lblCac.Text = Convert.ToString(tamanho);
            btmCac.Enabled = false;
        }
        public void inverter()
        {
            invert = txtFrase.Text;

            char[] chararray = invert.ToCharArray();
            Array.Reverse(chararray);
            string reversedText = new string(chararray);
            lblInv.Text = reversedText;
            reversedText = "";
            btmInv.Enabled = false;
        }
        public void vogais()
        {
            int count;

            for (int i = 0; i < txtFrase.Text.Length; i++)
            {
                frase = Convert.ToString(txtFrase.Text[i]);
                wordStorage.Add(frase.ToUpper());
            }

            count = Convert.ToInt32(wordStorage.Count);


            for (int i = 0; i < count; i++)
            {
                if ((wordStorage[i] == "A") || (wordStorage[i] == "Á") || (wordStorage[i] == "À") || (wordStorage[i] == "Â") || (wordStorage[i] == "Ã"))
                {
                    vA++;

                }
                else if ((wordStorage[i] == "E") || (wordStorage[i] == "É") || (wordStorage[i] == "Ê") || (wordStorage[i] == "È"))
                {
                    vE++;

                }
                else if ((wordStorage[i] == "I") || (wordStorage[i] == "Ì") || (wordStorage[i] == "Í"))
                {
                    vI++;

                }
                else if ((wordStorage[i] == "O") || (wordStorage[i] == "Ó") || (wordStorage[i] == "Ò") || (wordStorage[i] == "Ô") || (wordStorage[i] == "Õ"))
                {
                    vO++;

                }
                else if ((wordStorage[i] == "U") || (wordStorage[i] == "Ú") || (wordStorage[i] == "Ù") || (wordStorage[i] == "Û"))
                {
                    vU++;

                }

                lblA.Text = Convert.ToString(vA);
                lblE.Text = Convert.ToString(vE);
                lblI.Text = Convert.ToString(vI);
                lblO.Text = Convert.ToString(vO);
                lblU.Text = Convert.ToString(vU);
                btmVog.Enabled = false;
            }
        }
        public void palindrome() 
        {
            invert = txtFrase.Text;

            char[] chararray = invert.ToCharArray();
            Array.Reverse(chararray);
            string inverso = new string(chararray);

            if (inverso == invert)
            {
                MessageBox.Show("Esta Frase é um Palíndromo!");
            }
            else
            {
                MessageBox.Show("Esta Frase NÃO é um Palíndromo!");
            }
            inverso = "";
            btmPalin.Enabled = false;
        }
        public void espacos()
        {
            frase = txtFrase.Text;
            lblSE.Text = Convert.ToString(frase.Replace(" ", ""));
            button5.Enabled = false;
        }
        public void letra()
        {
            listBox1.Items.Clear();
            foreach (char _char in txtFrase.Text)
            {
                listBox1.Items.Add(_char);
            }
            btmLetra.Enabled = false;
        }
        public void palavra()
        {
            string PhraseBroken;

            PhraseBroken = "";
            int i = txtFrase.Text.Length;

            for (int c = 0; c < i; c++)
            {
                if (Convert.ToString(txtFrase.Text[c]) != " ")
                {
                    PhraseBroken += txtFrase.Text[c];
                }
                else
                {
                    listBox2.Items.Add(PhraseBroken);
                    PhraseBroken = "";
                }
            }
            listBox2.Items.Add(PhraseBroken);
            btmPal.Enabled = false;
        }
    }
}
