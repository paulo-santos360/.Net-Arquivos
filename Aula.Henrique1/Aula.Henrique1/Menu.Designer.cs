namespace Aula.Henrique1
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.colaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fisicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juridicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parceiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaboradorToolStripMenuItem,
            this.fisicToolStripMenuItem,
            this.juridicaToolStripMenuItem,
            this.parceiroToolStripMenuItem,
            this.pessoaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // colaboradorToolStripMenuItem
            // 
            this.colaboradorToolStripMenuItem.Name = "colaboradorToolStripMenuItem";
            this.colaboradorToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.colaboradorToolStripMenuItem.Text = "colaborador";
            this.colaboradorToolStripMenuItem.Click += new System.EventHandler(this.colaboradorToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fisicToolStripMenuItem
            // 
            this.fisicToolStripMenuItem.Name = "fisicToolStripMenuItem";
            this.fisicToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fisicToolStripMenuItem.Text = "Fisica";
            this.fisicToolStripMenuItem.Click += new System.EventHandler(this.fisicToolStripMenuItem_Click);
            // 
            // juridicaToolStripMenuItem
            // 
            this.juridicaToolStripMenuItem.Name = "juridicaToolStripMenuItem";
            this.juridicaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.juridicaToolStripMenuItem.Text = "Juridica";
            this.juridicaToolStripMenuItem.Click += new System.EventHandler(this.juridicaToolStripMenuItem_Click);
            // 
            // parceiroToolStripMenuItem
            // 
            this.parceiroToolStripMenuItem.Name = "parceiroToolStripMenuItem";
            this.parceiroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.parceiroToolStripMenuItem.Text = "parceiro";
            this.parceiroToolStripMenuItem.Click += new System.EventHandler(this.parceiroToolStripMenuItem_Click);
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.pessoaToolStripMenuItem.Text = "pessoa";
            this.pessoaToolStripMenuItem.Click += new System.EventHandler(this.pessoaToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juridicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parceiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}