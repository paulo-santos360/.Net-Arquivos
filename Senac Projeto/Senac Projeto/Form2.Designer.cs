namespace Senac_Projeto
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
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cadastrarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagDeContasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promoçaoDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFuncionarioToolStripMenuItem,
            this.cadastrarFornecedorToolStripMenuItem,
            this.controleDeEstoqueToolStripMenuItem,
            this.cadastroDeProdutosToolStripMenuItem,
            this.cadastroDeClienteToolStripMenuItem,
            this.controleDeCaixaToolStripMenuItem,
            this.pagDeContasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 11;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // cadastrarFuncionarioToolStripMenuItem
            // 
            this.cadastrarFuncionarioToolStripMenuItem.Name = "cadastrarFuncionarioToolStripMenuItem";
            this.cadastrarFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.cadastrarFuncionarioToolStripMenuItem.Text = "Cad Funcionario";
            // 
            // cadastrarFornecedorToolStripMenuItem
            // 
            this.cadastrarFornecedorToolStripMenuItem.Name = "cadastrarFornecedorToolStripMenuItem";
            this.cadastrarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.cadastrarFornecedorToolStripMenuItem.Text = "Cad Fornecedor";
            this.cadastrarFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFornecedorToolStripMenuItem_Click);
            // 
            // controleDeEstoqueToolStripMenuItem
            // 
            this.controleDeEstoqueToolStripMenuItem.Name = "controleDeEstoqueToolStripMenuItem";
            this.controleDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.controleDeEstoqueToolStripMenuItem.Text = "Controle de Estoque";
            this.controleDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.controleDeEstoqueToolStripMenuItem_Click);
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promoçaoDeProdutosToolStripMenuItem});
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cad de Produtos";
            this.cadastroDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutosToolStripMenuItem_Click);
            // 
            // cadastroDeClienteToolStripMenuItem
            // 
            this.cadastroDeClienteToolStripMenuItem.Name = "cadastroDeClienteToolStripMenuItem";
            this.cadastroDeClienteToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.cadastroDeClienteToolStripMenuItem.Text = "Cad Cliente";
            this.cadastroDeClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClienteToolStripMenuItem_Click);
            // 
            // controleDeCaixaToolStripMenuItem
            // 
            this.controleDeCaixaToolStripMenuItem.Name = "controleDeCaixaToolStripMenuItem";
            this.controleDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.controleDeCaixaToolStripMenuItem.Text = "Controle de Caixa";
            // 
            // pagDeContasToolStripMenuItem
            // 
            this.pagDeContasToolStripMenuItem.Name = "pagDeContasToolStripMenuItem";
            this.pagDeContasToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.pagDeContasToolStripMenuItem.Text = "Pag de Contas";
            // 
            // promoçaoDeProdutosToolStripMenuItem
            // 
            this.promoçaoDeProdutosToolStripMenuItem.Name = "promoçaoDeProdutosToolStripMenuItem";
            this.promoçaoDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.promoçaoDeProdutosToolStripMenuItem.Text = "Promoçao de Produtos";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Menu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promoçaoDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagDeContasToolStripMenuItem;
    }
}