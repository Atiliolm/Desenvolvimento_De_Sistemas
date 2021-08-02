
namespace Combustivel
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
            this.txtVelo = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtKml = new System.Windows.Forms.TextBox();
            this.btmCalc = new System.Windows.Forms.Button();
            this.btmLimp = new System.Windows.Forms.Button();
            this.btmSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Velocidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tempo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Km/l";
            // 
            // txtVelo
            // 
            this.txtVelo.Location = new System.Drawing.Point(98, 13);
            this.txtVelo.Name = "txtVelo";
            this.txtVelo.Size = new System.Drawing.Size(100, 22);
            this.txtVelo.TabIndex = 3;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(98, 48);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 22);
            this.txtTemp.TabIndex = 4;
            // 
            // txtKml
            // 
            this.txtKml.Location = new System.Drawing.Point(98, 83);
            this.txtKml.Name = "txtKml";
            this.txtKml.Size = new System.Drawing.Size(100, 22);
            this.txtKml.TabIndex = 5;
            // 
            // btmCalc
            // 
            this.btmCalc.Location = new System.Drawing.Point(16, 129);
            this.btmCalc.Name = "btmCalc";
            this.btmCalc.Size = new System.Drawing.Size(75, 23);
            this.btmCalc.TabIndex = 6;
            this.btmCalc.Text = "Calcular";
            this.btmCalc.UseVisualStyleBackColor = true;
            this.btmCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btmLimp
            // 
            this.btmLimp.Location = new System.Drawing.Point(98, 129);
            this.btmLimp.Name = "btmLimp";
            this.btmLimp.Size = new System.Drawing.Size(75, 23);
            this.btmLimp.TabIndex = 7;
            this.btmLimp.Text = "Limpar";
            this.btmLimp.UseVisualStyleBackColor = true;
            this.btmLimp.Click += new System.EventHandler(this.button2_Click);
            // 
            // btmSair
            // 
            this.btmSair.Location = new System.Drawing.Point(13, 159);
            this.btmSair.Name = "btmSair";
            this.btmSair.Size = new System.Drawing.Size(75, 23);
            this.btmSair.TabIndex = 8;
            this.btmSair.Text = "Sair";
            this.btmSair.UseVisualStyleBackColor = true;
            this.btmSair.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 335);
            this.Controls.Add(this.btmSair);
            this.Controls.Add(this.btmLimp);
            this.Controls.Add(this.btmCalc);
            this.Controls.Add(this.txtKml);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtVelo);
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
        private System.Windows.Forms.TextBox txtVelo;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtKml;
        private System.Windows.Forms.Button btmCalc;
        private System.Windows.Forms.Button btmLimp;
        private System.Windows.Forms.Button btmSair;
    }
}

