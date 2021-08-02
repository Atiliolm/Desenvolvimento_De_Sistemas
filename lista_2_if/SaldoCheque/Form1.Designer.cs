
namespace SaldoCheque
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.txtC3 = new System.Windows.Forms.TextBox();
            this.btmCalc = new System.Windows.Forms.Button();
            this.btmSair = new System.Windows.Forms.Button();
            this.lblSit1 = new System.Windows.Forms.Label();
            this.lblSit2 = new System.Windows.Forms.Label();
            this.lblSit3 = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cheque 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cheque 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cheque 3";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(92, 8);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 22);
            this.txtSaldo.TabIndex = 4;
            // 
            // txtC1
            // 
            this.txtC1.Location = new System.Drawing.Point(92, 46);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(100, 22);
            this.txtC1.TabIndex = 5;
            // 
            // txtC2
            // 
            this.txtC2.Location = new System.Drawing.Point(92, 76);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(100, 22);
            this.txtC2.TabIndex = 6;
            // 
            // txtC3
            // 
            this.txtC3.Location = new System.Drawing.Point(92, 108);
            this.txtC3.Name = "txtC3";
            this.txtC3.Size = new System.Drawing.Size(100, 22);
            this.txtC3.TabIndex = 7;
            // 
            // btmCalc
            // 
            this.btmCalc.Location = new System.Drawing.Point(216, 8);
            this.btmCalc.Name = "btmCalc";
            this.btmCalc.Size = new System.Drawing.Size(75, 23);
            this.btmCalc.TabIndex = 8;
            this.btmCalc.Text = "Calcular";
            this.btmCalc.UseVisualStyleBackColor = true;
            this.btmCalc.Click += new System.EventHandler(this.btmCalc_Click);
            // 
            // btmSair
            // 
            this.btmSair.Location = new System.Drawing.Point(216, 46);
            this.btmSair.Name = "btmSair";
            this.btmSair.Size = new System.Drawing.Size(75, 23);
            this.btmSair.TabIndex = 9;
            this.btmSair.Text = "Sair";
            this.btmSair.UseVisualStyleBackColor = true;
            this.btmSair.Click += new System.EventHandler(this.btmSair_Click);
            // 
            // lblSit1
            // 
            this.lblSit1.AutoSize = true;
            this.lblSit1.Location = new System.Drawing.Point(147, 174);
            this.lblSit1.Name = "lblSit1";
            this.lblSit1.Size = new System.Drawing.Size(20, 17);
            this.lblSit1.TabIndex = 10;
            this.lblSit1.Text = "...";
            // 
            // lblSit2
            // 
            this.lblSit2.AutoSize = true;
            this.lblSit2.Location = new System.Drawing.Point(147, 207);
            this.lblSit2.Name = "lblSit2";
            this.lblSit2.Size = new System.Drawing.Size(20, 17);
            this.lblSit2.TabIndex = 11;
            this.lblSit2.Text = "...";
            this.lblSit2.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblSit3
            // 
            this.lblSit3.AutoSize = true;
            this.lblSit3.Location = new System.Drawing.Point(147, 241);
            this.lblSit3.Name = "lblSit3";
            this.lblSit3.Size = new System.Drawing.Size(20, 17);
            this.lblSit3.TabIndex = 12;
            this.lblSit3.Text = "...";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(107, 277);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(20, 17);
            this.lblFinal.TabIndex = 13;
            this.lblFinal.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Saldo Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Situação Cheque 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Situação Cheque 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Situação Cheque 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblSit3);
            this.Controls.Add(this.lblSit2);
            this.Controls.Add(this.lblSit1);
            this.Controls.Add(this.btmSair);
            this.Controls.Add(this.btmCalc);
            this.Controls.Add(this.txtC3);
            this.Controls.Add(this.txtC2);
            this.Controls.Add(this.txtC1);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.TextBox txtC3;
        private System.Windows.Forms.Button btmCalc;
        private System.Windows.Forms.Button btmSair;
        private System.Windows.Forms.Label lblSit1;
        private System.Windows.Forms.Label lblSit2;
        private System.Windows.Forms.Label lblSit3;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

