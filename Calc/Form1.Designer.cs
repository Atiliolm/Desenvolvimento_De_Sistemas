
namespace Calc
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
            this.btmSoma = new System.Windows.Forms.Button();
            this.lblV1 = new System.Windows.Forms.Label();
            this.lblV2 = new System.Windows.Forms.Label();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.btmSub = new System.Windows.Forms.Button();
            this.btmDiv = new System.Windows.Forms.Button();
            this.btmMult = new System.Windows.Forms.Button();
            this.btmLimpar = new System.Windows.Forms.Button();
            this.btmSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmSoma
            // 
            this.btmSoma.Location = new System.Drawing.Point(364, 33);
            this.btmSoma.Name = "btmSoma";
            this.btmSoma.Size = new System.Drawing.Size(75, 23);
            this.btmSoma.TabIndex = 0;
            this.btmSoma.Text = "Soma";
            this.btmSoma.UseVisualStyleBackColor = true;
            this.btmSoma.Click += new System.EventHandler(this.btmSoma_Click);
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Location = new System.Drawing.Point(75, 39);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(149, 17);
            this.lblV1.TabIndex = 1;
            this.lblV1.Text = "Digite o Primeiro Valor";
            // 
            // lblV2
            // 
            this.lblV2.AutoSize = true;
            this.lblV2.Location = new System.Drawing.Point(78, 85);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(154, 17);
            this.lblV2.TabIndex = 2;
            this.lblV2.Text = "Digite o Segundo Valor";
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(230, 36);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(100, 22);
            this.txtV1.TabIndex = 3;
            this.txtV1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(230, 82);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(100, 22);
            this.txtV2.TabIndex = 4;
            // 
            // btmSub
            // 
            this.btmSub.Location = new System.Drawing.Point(364, 62);
            this.btmSub.Name = "btmSub";
            this.btmSub.Size = new System.Drawing.Size(75, 23);
            this.btmSub.TabIndex = 5;
            this.btmSub.Text = "Subtrair";
            this.btmSub.UseVisualStyleBackColor = true;
            this.btmSub.Click += new System.EventHandler(this.btmSub_Click);
            // 
            // btmDiv
            // 
            this.btmDiv.Location = new System.Drawing.Point(364, 91);
            this.btmDiv.Name = "btmDiv";
            this.btmDiv.Size = new System.Drawing.Size(75, 23);
            this.btmDiv.TabIndex = 6;
            this.btmDiv.Text = "Divisão";
            this.btmDiv.UseVisualStyleBackColor = true;
            this.btmDiv.Click += new System.EventHandler(this.btmDiv_Click);
            // 
            // btmMult
            // 
            this.btmMult.Location = new System.Drawing.Point(364, 120);
            this.btmMult.Name = "btmMult";
            this.btmMult.Size = new System.Drawing.Size(75, 23);
            this.btmMult.TabIndex = 7;
            this.btmMult.Text = "Multiplicar";
            this.btmMult.UseVisualStyleBackColor = true;
            this.btmMult.Click += new System.EventHandler(this.btmMult_Click);
            // 
            // btmLimpar
            // 
            this.btmLimpar.Location = new System.Drawing.Point(78, 120);
            this.btmLimpar.Name = "btmLimpar";
            this.btmLimpar.Size = new System.Drawing.Size(75, 23);
            this.btmLimpar.TabIndex = 8;
            this.btmLimpar.Text = "Limpar";
            this.btmLimpar.UseVisualStyleBackColor = true;
            this.btmLimpar.Click += new System.EventHandler(this.btmLimpar_Click);
            // 
            // btmSair
            // 
            this.btmSair.Location = new System.Drawing.Point(78, 149);
            this.btmSair.Name = "btmSair";
            this.btmSair.Size = new System.Drawing.Size(75, 23);
            this.btmSair.TabIndex = 9;
            this.btmSair.Text = "Sair";
            this.btmSair.UseVisualStyleBackColor = true;
            this.btmSair.Click += new System.EventHandler(this.btmSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 224);
            this.ControlBox = false;
            this.Controls.Add(this.btmSair);
            this.Controls.Add(this.btmLimpar);
            this.Controls.Add(this.btmMult);
            this.Controls.Add(this.btmDiv);
            this.Controls.Add(this.btmSub);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.lblV2);
            this.Controls.Add(this.lblV1);
            this.Controls.Add(this.btmSoma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmSoma;
        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.Button btmSub;
        private System.Windows.Forms.Button btmDiv;
        private System.Windows.Forms.Button btmMult;
        private System.Windows.Forms.Button btmLimpar;
        private System.Windows.Forms.Button btmSair;
    }
}

