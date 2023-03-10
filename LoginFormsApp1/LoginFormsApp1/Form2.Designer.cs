namespace LoginFormsApp1
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroDePToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosEmVencimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDePToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.produtosEmVencimentoToolStripMenuItem,
            this.produtosEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDePToolStripMenuItem
            // 
            this.cadastroDePToolStripMenuItem.Name = "cadastroDePToolStripMenuItem";
            this.cadastroDePToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.cadastroDePToolStripMenuItem.Text = "Cadastro de Produto";
            this.cadastroDePToolStripMenuItem.Click += new System.EventHandler(this.cadastroDePToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // produtosEmVencimentoToolStripMenuItem
            // 
            this.produtosEmVencimentoToolStripMenuItem.Name = "produtosEmVencimentoToolStripMenuItem";
            this.produtosEmVencimentoToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.produtosEmVencimentoToolStripMenuItem.Text = "Produtos em vencimento";
            // 
            // produtosEToolStripMenuItem
            // 
            this.produtosEToolStripMenuItem.Name = "produtosEToolStripMenuItem";
            this.produtosEToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.produtosEToolStripMenuItem.Text = "Produtos em Promoção";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosEmVencimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosEToolStripMenuItem;
    }
}