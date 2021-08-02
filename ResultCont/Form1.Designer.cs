
namespace ResultCont
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
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.btmCalc = new System.Windows.Forms.Button();
            this.btmLimpar = new System.Windows.Forms.Button();
            this.btmSoma = new System.Windows.Forms.Button();
            this.btmDiv = new System.Windows.Forms.Button();
            this.btmSub = new System.Windows.Forms.Button();
            this.btmMult = new System.Windows.Forms.Button();
            this.btmSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 2:";
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(76, 7);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(100, 22);
            this.txtV1.TabIndex = 2;
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(76, 39);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(100, 22);
            this.txtV2.TabIndex = 3;
            // 
            // btmCalc
            // 
            this.btmCalc.Location = new System.Drawing.Point(260, 10);
            this.btmCalc.Name = "btmCalc";
            this.btmCalc.Size = new System.Drawing.Size(75, 23);
            this.btmCalc.TabIndex = 6;
            this.btmCalc.Text = "Calcular";
            this.btmCalc.UseVisualStyleBackColor = true;
            this.btmCalc.Click += new System.EventHandler(this.btmCalc_Click);
            // 
            // btmLimpar
            // 
            this.btmLimpar.Location = new System.Drawing.Point(260, 39);
            this.btmLimpar.Name = "btmLimpar";
            this.btmLimpar.Size = new System.Drawing.Size(75, 23);
            this.btmLimpar.TabIndex = 7;
            this.btmLimpar.Text = "Limpar";
            this.btmLimpar.UseVisualStyleBackColor = true;
            this.btmLimpar.Click += new System.EventHandler(this.btmLimpar_Click);
            // 
            // btmSoma
            // 
            this.btmSoma.Location = new System.Drawing.Point(16, 76);
            this.btmSoma.Name = "btmSoma";
            this.btmSoma.Size = new System.Drawing.Size(74, 23);
            this.btmSoma.TabIndex = 8;
            this.btmSoma.Text = "+";
            this.btmSoma.UseVisualStyleBackColor = true;
            this.btmSoma.Click += new System.EventHandler(this.button1_Click);
            // 
            // btmDiv
            // 
            this.btmDiv.Location = new System.Drawing.Point(96, 105);
            this.btmDiv.Name = "btmDiv";
            this.btmDiv.Size = new System.Drawing.Size(74, 23);
            this.btmDiv.TabIndex = 9;
            this.btmDiv.Text = "/";
            this.btmDiv.UseVisualStyleBackColor = true;
            this.btmDiv.Click += new System.EventHandler(this.btmDiv_Click);
            // 
            // btmSub
            // 
            this.btmSub.Location = new System.Drawing.Point(16, 105);
            this.btmSub.Name = "btmSub";
            this.btmSub.Size = new System.Drawing.Size(74, 23);
            this.btmSub.TabIndex = 10;
            this.btmSub.Text = "-";
            this.btmSub.UseVisualStyleBackColor = true;
            this.btmSub.Click += new System.EventHandler(this.btmSub_Click);
            // 
            // btmMult
            // 
            this.btmMult.Location = new System.Drawing.Point(96, 76);
            this.btmMult.Name = "btmMult";
            this.btmMult.Size = new System.Drawing.Size(74, 23);
            this.btmMult.TabIndex = 11;
            this.btmMult.Text = "*";
            this.btmMult.UseVisualStyleBackColor = true;
            this.btmMult.Click += new System.EventHandler(this.btmMult_Click);
            // 
            // btmSair
            // 
            this.btmSair.Location = new System.Drawing.Point(260, 69);
            this.btmSair.Name = "btmSair";
            this.btmSair.Size = new System.Drawing.Size(75, 23);
            this.btmSair.TabIndex = 12;
            this.btmSair.Text = "Sair";
            this.btmSair.UseVisualStyleBackColor = true;
            this.btmSair.Click += new System.EventHandler(this.btmSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 348);
            this.Controls.Add(this.btmSair);
            this.Controls.Add(this.btmMult);
            this.Controls.Add(this.btmSub);
            this.Controls.Add(this.btmDiv);
            this.Controls.Add(this.btmSoma);
            this.Controls.Add(this.btmLimpar);
            this.Controls.Add(this.btmCalc);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.txtV1);
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
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.Button btmCalc;
        private System.Windows.Forms.Button btmLimpar;
        private System.Windows.Forms.Button btmSoma;
        private System.Windows.Forms.Button btmDiv;
        private System.Windows.Forms.Button btmSub;
        private System.Windows.Forms.Button btmMult;
        private System.Windows.Forms.Button btmSair;
    }
}

