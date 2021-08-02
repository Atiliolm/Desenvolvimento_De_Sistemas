
namespace HorasTrabalhadas
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
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblValorH = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btmCalc = new System.Windows.Forms.Button();
            this.btmLimpar = new System.Windows.Forms.Button();
            this.btmSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(12, 54);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(113, 17);
            this.lblHoras.TabIndex = 0;
            this.lblHoras.Text = "Horas trabalhas:";
            // 
            // lblValorH
            // 
            this.lblValorH.AutoSize = true;
            this.lblValorH.Location = new System.Drawing.Point(12, 20);
            this.lblValorH.Name = "lblValorH";
            this.lblValorH.Size = new System.Drawing.Size(165, 17);
            this.lblValorH.TabIndex = 1;
            this.lblValorH.Text = "Quanto recebe por hora:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(12, 83);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(79, 17);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descontos:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(184, 20);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 3;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(184, 49);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 22);
            this.txtHora.TabIndex = 4;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(184, 77);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 22);
            this.txtDesc.TabIndex = 5;
            // 
            // btmCalc
            // 
            this.btmCalc.Location = new System.Drawing.Point(325, 18);
            this.btmCalc.Name = "btmCalc";
            this.btmCalc.Size = new System.Drawing.Size(75, 23);
            this.btmCalc.TabIndex = 6;
            this.btmCalc.Text = "Calcular";
            this.btmCalc.UseVisualStyleBackColor = true;
            this.btmCalc.Click += new System.EventHandler(this.btmCalc_Click);
            // 
            // btmLimpar
            // 
            this.btmLimpar.Location = new System.Drawing.Point(325, 47);
            this.btmLimpar.Name = "btmLimpar";
            this.btmLimpar.Size = new System.Drawing.Size(75, 23);
            this.btmLimpar.TabIndex = 7;
            this.btmLimpar.Text = "Limpar";
            this.btmLimpar.UseVisualStyleBackColor = true;
            this.btmLimpar.Click += new System.EventHandler(this.btmLimpar_Click);
            // 
            // btmSair
            // 
            this.btmSair.Location = new System.Drawing.Point(325, 76);
            this.btmSair.Name = "btmSair";
            this.btmSair.Size = new System.Drawing.Size(75, 23);
            this.btmSair.TabIndex = 8;
            this.btmSair.Text = "Sair";
            this.btmSair.UseVisualStyleBackColor = true;
            this.btmSair.Click += new System.EventHandler(this.btmSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 125);
            this.Controls.Add(this.btmSair);
            this.Controls.Add(this.btmLimpar);
            this.Controls.Add(this.btmCalc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblValorH);
            this.Controls.Add(this.lblHoras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblValorH;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btmCalc;
        private System.Windows.Forms.Button btmLimpar;
        private System.Windows.Forms.Button btmSair;
    }
}

