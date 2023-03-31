namespace Projeto_Ração
{
    partial class FrmPesProduto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produtoscdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosmarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtostamanhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosvalorcompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosvalorvendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroprodutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racaodovaleDataSet = new Projeto_Ração.RacaodovaleDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cadastro_produtosTableAdapter = new Projeto_Ração.RacaodovaleDataSetTableAdapters.cadastro_produtosTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroprodutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaodovaleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produtoscdDataGridViewTextBoxColumn,
            this.produtosdescDataGridViewTextBoxColumn,
            this.produtosmarcaDataGridViewTextBoxColumn,
            this.produtostamanhoDataGridViewTextBoxColumn,
            this.produtosvalorcompraDataGridViewTextBoxColumn,
            this.produtosvalorvendaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cadastroprodutosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 150);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // produtoscdDataGridViewTextBoxColumn
            // 
            this.produtoscdDataGridViewTextBoxColumn.DataPropertyName = "produtos_cd";
            this.produtoscdDataGridViewTextBoxColumn.HeaderText = "produtos_cd";
            this.produtoscdDataGridViewTextBoxColumn.Name = "produtoscdDataGridViewTextBoxColumn";
            this.produtoscdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtosdescDataGridViewTextBoxColumn
            // 
            this.produtosdescDataGridViewTextBoxColumn.DataPropertyName = "produtos_desc";
            this.produtosdescDataGridViewTextBoxColumn.HeaderText = "produtos_desc";
            this.produtosdescDataGridViewTextBoxColumn.Name = "produtosdescDataGridViewTextBoxColumn";
            // 
            // produtosmarcaDataGridViewTextBoxColumn
            // 
            this.produtosmarcaDataGridViewTextBoxColumn.DataPropertyName = "produtos_marca";
            this.produtosmarcaDataGridViewTextBoxColumn.HeaderText = "produtos_marca";
            this.produtosmarcaDataGridViewTextBoxColumn.Name = "produtosmarcaDataGridViewTextBoxColumn";
            // 
            // produtostamanhoDataGridViewTextBoxColumn
            // 
            this.produtostamanhoDataGridViewTextBoxColumn.DataPropertyName = "produtos_tamanho";
            this.produtostamanhoDataGridViewTextBoxColumn.HeaderText = "produtos_tamanho";
            this.produtostamanhoDataGridViewTextBoxColumn.Name = "produtostamanhoDataGridViewTextBoxColumn";
            // 
            // produtosvalorcompraDataGridViewTextBoxColumn
            // 
            this.produtosvalorcompraDataGridViewTextBoxColumn.DataPropertyName = "produtos_valor_compra";
            this.produtosvalorcompraDataGridViewTextBoxColumn.HeaderText = "produtos_valor_compra";
            this.produtosvalorcompraDataGridViewTextBoxColumn.Name = "produtosvalorcompraDataGridViewTextBoxColumn";
            // 
            // produtosvalorvendaDataGridViewTextBoxColumn
            // 
            this.produtosvalorvendaDataGridViewTextBoxColumn.DataPropertyName = "produtos_valor_venda";
            this.produtosvalorvendaDataGridViewTextBoxColumn.HeaderText = "produtos_valor_venda";
            this.produtosvalorvendaDataGridViewTextBoxColumn.Name = "produtosvalorvendaDataGridViewTextBoxColumn";
            // 
            // cadastroprodutosBindingSource
            // 
            this.cadastroprodutosBindingSource.DataMember = "cadastro_produtos";
            this.cadastroprodutosBindingSource.DataSource = this.racaodovaleDataSet;
            // 
            // racaodovaleDataSet
            // 
            this.racaodovaleDataSet.DataSetName = "RacaodovaleDataSet";
            this.racaodovaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "DESCRIÇÃO DO PRODUTO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "NOME DO PRODUTO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(650, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "DELETAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(497, 172);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "ALTERAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(355, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "PESQUISAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(355, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "PESQUISAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "LIMPAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cadastro_produtosTableAdapter
            // 
            this.cadastro_produtosTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(73, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "RAÇÃODOVALE";
            // 
            // FrmPesProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmPesProduto";
            this.Text = "FrmPesProduto";
            this.Load += new System.EventHandler(this.FrmPesProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroprodutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaodovaleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private RacaodovaleDataSet racaodovaleDataSet;
        private System.Windows.Forms.BindingSource cadastroprodutosBindingSource;
        private RacaodovaleDataSetTableAdapters.cadastro_produtosTableAdapter cadastro_produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoscdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtosdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtosmarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtostamanhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtosvalorcompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtosvalorvendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}