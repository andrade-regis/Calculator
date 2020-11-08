namespace Calculadora
{
    partial class frmPrincipal
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
            this.pnlCabeçalho = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlRodapé = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlCabeçalho.SuspendLayout();
            this.pnlRodapé.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabeçalho
            // 
            this.pnlCabeçalho.BackColor = System.Drawing.Color.Gray;
            this.pnlCabeçalho.Controls.Add(this.lblTitle);
            this.pnlCabeçalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabeçalho.Name = "pnlCabeçalho";
            this.pnlCabeçalho.Size = new System.Drawing.Size(388, 61);
            this.pnlCabeçalho.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(95, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Calculadora";
            // 
            // pnlRodapé
            // 
            this.pnlRodapé.BackColor = System.Drawing.Color.Gray;
            this.pnlRodapé.Controls.Add(this.btnSair);
            this.pnlRodapé.Location = new System.Drawing.Point(0, 224);
            this.pnlRodapé.Name = "pnlRodapé";
            this.pnlRodapé.Size = new System.Drawing.Size(388, 60);
            this.pnlRodapé.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(153, 16);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.Silver;
            this.pnlBody.Location = new System.Drawing.Point(0, 64);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(388, 157);
            this.pnlBody.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 284);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlRodapé);
            this.Controls.Add(this.pnlCabeçalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlCabeçalho.ResumeLayout(false);
            this.pnlCabeçalho.PerformLayout();
            this.pnlRodapé.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabeçalho;
        private System.Windows.Forms.Panel pnlRodapé;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSair;
    }
}

