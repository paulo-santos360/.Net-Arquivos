namespace Projeto_Ração
{
    partial class MENU
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
            this.cadastroDeFunciorarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promoçãoDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeFunciorarioToolStripMenuItem,
            this.cToolStripMenuItem,
            this.cadastroDeFornecedorToolStripMenuItem,
            this.controleDeCaixaToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.contrToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.restoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDeFunciorarioToolStripMenuItem
            // 
            this.cadastroDeFunciorarioToolStripMenuItem.Name = "cadastroDeFunciorarioToolStripMenuItem";
            this.cadastroDeFunciorarioToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.cadastroDeFunciorarioToolStripMenuItem.Text = "Cad Funciorario";
            this.cadastroDeFunciorarioToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFunciorarioToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.cToolStripMenuItem.Text = "Cad Cliente";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // cadastroDeFornecedorToolStripMenuItem
            // 
            this.cadastroDeFornecedorToolStripMenuItem.Name = "cadastroDeFornecedorToolStripMenuItem";
            this.cadastroDeFornecedorToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.cadastroDeFornecedorToolStripMenuItem.Text = "Cad Fornecedor";
            this.cadastroDeFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFornecedorToolStripMenuItem_Click);
            // 
            // controleDeCaixaToolStripMenuItem
            // 
            this.controleDeCaixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleDeToolStripMenuItem});
            this.controleDeCaixaToolStripMenuItem.Name = "controleDeCaixaToolStripMenuItem";
            this.controleDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.controleDeCaixaToolStripMenuItem.Text = "Controle de Caixa";
            this.controleDeCaixaToolStripMenuItem.Click += new System.EventHandler(this.controleDeCaixaToolStripMenuItem_Click);
            // 
            // controleDeToolStripMenuItem
            // 
            this.controleDeToolStripMenuItem.Name = "controleDeToolStripMenuItem";
            this.controleDeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.controleDeToolStripMenuItem.Text = "Contas ";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promoçãoDeProdutosToolStripMenuItem,
            this.cadProdutosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.cadastroToolStripMenuItem.Text = "Produtos";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // promoçãoDeProdutosToolStripMenuItem
            // 
            this.promoçãoDeProdutosToolStripMenuItem.Name = "promoçãoDeProdutosToolStripMenuItem";
            this.promoçãoDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.promoçãoDeProdutosToolStripMenuItem.Text = "Promoção de Produtos";
            this.promoçãoDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.promoçãoDeProdutosToolStripMenuItem_Click);
            // 
            // contrToolStripMenuItem
            // 
            this.contrToolStripMenuItem.Name = "contrToolStripMenuItem";
            this.contrToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.contrToolStripMenuItem.Text = "Contr Estoque";
            this.contrToolStripMenuItem.Click += new System.EventHandler(this.contrToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.restoreToolStripMenuItem.Text = "Restore";
            // 
            // cadProdutosToolStripMenuItem
            // 
            this.cadProdutosToolStripMenuItem.Name = "cadProdutosToolStripMenuItem";
            this.cadProdutosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cadProdutosToolStripMenuItem.Text = "Cad Produtos";
            this.cadProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadProdutosToolStripMenuItem_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MENU";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFunciorarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promoçãoDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadProdutosToolStripMenuItem;
    }
}