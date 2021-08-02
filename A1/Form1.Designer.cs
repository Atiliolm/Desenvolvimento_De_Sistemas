
namespace A1
{
    partial class txtV1
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
            this.lblV1 = new System.Windows.Forms.Label();
            this.btmSoma = new System.Windows.Forms.Button();
            this.btmSub = new System.Windows.Forms.Button();
            this.btmDiv = new System.Windows.Forms.Button();
            this.btmMult = new System.Windows.Forms.Button();
            this.lblV2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.btmLimpar = new System.Windows.Forms.Button();
            this.btmSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Location = new System.Drawing.Point(56, 28);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(149, 17);
            this.lblV1.TabIndex = 0;
            this.lblV1.Text = "Digite o Primeiro Valor";
            this.lblV1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btmSoma
            // 
            this.btmSoma.Location = new System.Drawing.Point(490, 38);
            this.btmSoma.Name = "btmSoma";
            this.btmSoma.Size = new System.Drawing.Size(75, 23);
            this.btmSoma.TabIndex = 1;
            this.btmSoma.Text = "+";
            this.btmSoma.UseVisualStyleBackColor = true;
            this.btmSoma.Click += new System.EventHandler(this.button1_Click);
            // 
            // btmSub
            // 
            this.btmSub.Location = new System.Drawing.Point(490, 83);
            this.btmSub.Name = "btmSub";
            this.btmSub.Size = new System.Drawing.Size(75, 25);
            this.btmSub.TabIndex = 2;
            this.btmSub.Text = "-";
            this.btmSub.UseVisualStyleBackColor = true;
            // 
            // btmDiv
            // 
            this.btmDiv.Location = new System.Drawing.Point(490, 130);
            this.btmDiv.Name = "btmDiv";
            this.btmDiv.Size = new System.Drawing.Size(75, 23);
            this.btmDiv.TabIndex = 3;
            this.btmDiv.Text = "/";
            this.btmDiv.UseVisualStyleBackColor = true;
            // 
            // btmMult
            // 
            this.btmMult.Location = new System.Drawing.Point(490, 175);
            this.btmMult.Name = "btmMult";
            this.btmMult.Size = new System.Drawing.Size(75, 23);
            this.btmMult.TabIndex = 4;
            this.btmMult.Text = "*";
            this.btmMult.UseVisualStyleBackColor = true;
            // 
            // lblV2
            // 
            this.lblV2.AutoSize = true;
            this.lblV2.Location = new System.Drawing.Point(56, 71);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(154, 17);
            this.lblV2.TabIndex = 5;
            this.lblV2.Text = "Digite o Segundo Valor";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(242, 65);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(100, 22);
            this.txtV2.TabIndex = 7;
            this.txtV2.TextChanged += new System.EventHandler(this.txtV2_TextChanged);
            // 
            // btmLimpar
            // 
            this.btmLimpar.Location = new System.Drawing.Point(72, 199);
            this.btmLimpar.Name = "btmLimpar";
            this.btmLimpar.Size = new System.Drawing.Size(75, 23);
            this.btmLimpar.TabIndex = 8;
            this.btmLimpar.Text = "Limpar";
            this.btmLimpar.UseVisualStyleBackColor = true;
            // 
            // btmSair
            // 
            this.btmSair.Location = new System.Drawing.Point(72, 256);
            this.btmSair.Name = "btmSair";
            this.btmSair.Size = new System.Drawing.Size(75, 23);
            this.btmSair.TabIndex = 9;
            this.btmSair.Text = "Sair";
            this.btmSair.UseVisualStyleBackColor = true;
            // 
            // txtV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 456);
            this.Controls.Add(this.btmSair);
            this.Controls.Add(this.btmLimpar);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblV2);
            this.Controls.Add(this.btmMult);
            this.Controls.Add(this.btmDiv);
            this.Controls.Add(this.btmSub);
            this.Controls.Add(this.btmSoma);
            this.Controls.Add(this.lblV1);
            this.Name = "txtV1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.Button btmSoma;
        private System.Windows.Forms.Button btmSub;
        private System.Windows.Forms.Button btmDiv;
        private System.Windows.Forms.Button btmMult;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.Button btmLimpar;
        private System.Windows.Forms.Button btmSair;
    }
}

