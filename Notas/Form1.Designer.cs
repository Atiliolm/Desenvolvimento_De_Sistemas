
namespace Notas
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
            this.lblLab = new System.Windows.Forms.Label();
            this.lblSem = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.btmCalc = new System.Windows.Forms.Button();
            this.btmLimp = new System.Windows.Forms.Button();
            this.btmSair = new System.Windows.Forms.Button();
            this.txtLab = new System.Windows.Forms.TextBox();
            this.txtSem = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLab
            // 
            this.lblLab.AutoSize = true;
            this.lblLab.Location = new System.Drawing.Point(13, 13);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(81, 17);
            this.lblLab.TabIndex = 0;
            this.lblLab.Text = "Laboratório";
            // 
            // lblSem
            // 
            this.lblSem.AutoSize = true;
            this.lblSem.Location = new System.Drawing.Point(12, 47);
            this.lblSem.Name = "lblSem";
            this.lblSem.Size = new System.Drawing.Size(112, 17);
            this.lblSem.TabIndex = 1;
            this.lblSem.Text = "Prova Semestral";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(12, 77);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(79, 17);
            this.lblFin.TabIndex = 2;
            this.lblFin.Text = "Prova Final";
            // 
            // btmCalc
            // 
            this.btmCalc.Location = new System.Drawing.Point(16, 119);
            this.btmCalc.Name = "btmCalc";
            this.btmCalc.Size = new System.Drawing.Size(97, 23);
            this.btmCalc.TabIndex = 3;
            this.btmCalc.Text = "CALCULAR";
            this.btmCalc.UseVisualStyleBackColor = true;
            this.btmCalc.Click += new System.EventHandler(this.btmCalc_Click);
            // 
            // btmLimp
            // 
            this.btmLimp.Location = new System.Drawing.Point(130, 119);
            this.btmLimp.Name = "btmLimp";
            this.btmLimp.Size = new System.Drawing.Size(100, 23);
            this.btmLimp.TabIndex = 4;
            this.btmLimp.Text = "LIMPAR";
            this.btmLimp.UseVisualStyleBackColor = true;
            this.btmLimp.Click += new System.EventHandler(this.btmLimp_Click);
            // 
            // btmSair
            // 
            this.btmSair.Location = new System.Drawing.Point(88, 148);
            this.btmSair.Name = "btmSair";
            this.btmSair.Size = new System.Drawing.Size(75, 23);
            this.btmSair.TabIndex = 5;
            this.btmSair.Text = "SAIR";
            this.btmSair.UseVisualStyleBackColor = true;
            this.btmSair.Click += new System.EventHandler(this.btmSair_Click);
            // 
            // txtLab
            // 
            this.txtLab.Location = new System.Drawing.Point(130, 10);
            this.txtLab.Name = "txtLab";
            this.txtLab.Size = new System.Drawing.Size(100, 22);
            this.txtLab.TabIndex = 6;
            this.txtLab.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSem
            // 
            this.txtSem.Location = new System.Drawing.Point(130, 42);
            this.txtSem.Name = "txtSem";
            this.txtSem.Size = new System.Drawing.Size(100, 22);
            this.txtSem.TabIndex = 7;
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(130, 72);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(100, 22);
            this.txtFin.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 193);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.txtSem);
            this.Controls.Add(this.txtLab);
            this.Controls.Add(this.btmSair);
            this.Controls.Add(this.btmLimp);
            this.Controls.Add(this.btmCalc);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblSem);
            this.Controls.Add(this.lblLab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.Label lblSem;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Button btmCalc;
        private System.Windows.Forms.Button btmLimp;
        private System.Windows.Forms.Button btmSair;
        private System.Windows.Forms.TextBox txtLab;
        private System.Windows.Forms.TextBox txtSem;
        private System.Windows.Forms.TextBox txtFin;
    }
}

