
namespace Apps
{
    partial class Tabuada_Init_End
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInit = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btmExec = new System.Windows.Forms.Button();
            this.btmMenu = new System.Windows.Forms.Button();
            this.btmLimp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Final:";
            // 
            // txtInit
            // 
            this.txtInit.Location = new System.Drawing.Point(124, 10);
            this.txtInit.Name = "txtInit";
            this.txtInit.Size = new System.Drawing.Size(125, 27);
            this.txtInit.TabIndex = 2;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(124, 44);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(125, 27);
            this.txtEnd.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(13, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 284);
            this.listBox1.TabIndex = 4;
            // 
            // btmExec
            // 
            this.btmExec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btmExec.Location = new System.Drawing.Point(278, 88);
            this.btmExec.Name = "btmExec";
            this.btmExec.Size = new System.Drawing.Size(94, 80);
            this.btmExec.TabIndex = 5;
            this.btmExec.Text = "Calcular";
            this.btmExec.UseVisualStyleBackColor = true;
            this.btmExec.Click += new System.EventHandler(this.btmExec_Click);
            // 
            // btmMenu
            // 
            this.btmMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btmMenu.Location = new System.Drawing.Point(278, 289);
            this.btmMenu.Name = "btmMenu";
            this.btmMenu.Size = new System.Drawing.Size(94, 82);
            this.btmMenu.TabIndex = 6;
            this.btmMenu.Text = "Menu";
            this.btmMenu.UseVisualStyleBackColor = true;
            this.btmMenu.Click += new System.EventHandler(this.btmMenu_Click);
            // 
            // btmLimp
            // 
            this.btmLimp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btmLimp.Location = new System.Drawing.Point(278, 188);
            this.btmLimp.Name = "btmLimp";
            this.btmLimp.Size = new System.Drawing.Size(94, 83);
            this.btmLimp.TabIndex = 7;
            this.btmLimp.Text = "Limpar";
            this.btmLimp.UseVisualStyleBackColor = true;
            this.btmLimp.Click += new System.EventHandler(this.btmLimp_Click);
            // 
            // Tabuada_Init_End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 398);
            this.Controls.Add(this.btmLimp);
            this.Controls.Add(this.btmMenu);
            this.Controls.Add(this.btmExec);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtInit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tabuada_Init_End";
            this.Text = "Tabuada_Init_End";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInit;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btmExec;
        private System.Windows.Forms.Button btmMenu;
        private System.Windows.Forms.Button btmLimp;
    }
}