
namespace Maior
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
            this.lblResp = new System.Windows.Forms.Label();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.txtV3 = new System.Windows.Forms.TextBox();
            this.btmVericar = new System.Windows.Forms.Button();
            this.btmReset = new System.Windows.Forms.Button();
            this.btmDesligar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o Primeiro valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insira o Segundo valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Insira o Terceiro valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "O Maior Número é:";
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Location = new System.Drawing.Point(147, 109);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(20, 17);
            this.lblResp.TabIndex = 4;
            this.lblResp.Text = "...";
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(170, 8);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(100, 22);
            this.txtV1.TabIndex = 5;
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(170, 39);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(100, 22);
            this.txtV2.TabIndex = 6;
            // 
            // txtV3
            // 
            this.txtV3.Location = new System.Drawing.Point(170, 71);
            this.txtV3.Name = "txtV3";
            this.txtV3.Size = new System.Drawing.Size(100, 22);
            this.txtV3.TabIndex = 7;
            // 
            // btmVericar
            // 
            this.btmVericar.Location = new System.Drawing.Point(16, 144);
            this.btmVericar.Name = "btmVericar";
            this.btmVericar.Size = new System.Drawing.Size(75, 23);
            this.btmVericar.TabIndex = 8;
            this.btmVericar.Text = "Verificar";
            this.btmVericar.UseVisualStyleBackColor = true;
            this.btmVericar.Click += new System.EventHandler(this.btmVericar_Click);
            // 
            // btmReset
            // 
            this.btmReset.Location = new System.Drawing.Point(107, 144);
            this.btmReset.Name = "btmReset";
            this.btmReset.Size = new System.Drawing.Size(75, 23);
            this.btmReset.TabIndex = 9;
            this.btmReset.Text = "Resetar";
            this.btmReset.UseVisualStyleBackColor = true;
            this.btmReset.Click += new System.EventHandler(this.btmReset_Click);
            // 
            // btmDesligar
            // 
            this.btmDesligar.Location = new System.Drawing.Point(16, 173);
            this.btmDesligar.Name = "btmDesligar";
            this.btmDesligar.Size = new System.Drawing.Size(166, 23);
            this.btmDesligar.TabIndex = 10;
            this.btmDesligar.Text = "Desligar";
            this.btmDesligar.UseVisualStyleBackColor = true;
            this.btmDesligar.Click += new System.EventHandler(this.btmDesligar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmDesligar);
            this.Controls.Add(this.btmReset);
            this.Controls.Add(this.btmVericar);
            this.Controls.Add(this.txtV3);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.lblResp);
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
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.TextBox txtV3;
        private System.Windows.Forms.Button btmVericar;
        private System.Windows.Forms.Button btmReset;
        private System.Windows.Forms.Button btmDesligar;
    }
}

