namespace Projeto_Ração
{
    partial class caixasoma
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Produtos = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produtoscdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosmarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtostamanhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosvalorcompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosvalorvendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroprodutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racaodovaleDataSet = new Projeto_Ração.RacaodovaleDataSet();
            this.cadastro_produtosTableAdapter = new Projeto_Ração.RacaodovaleDataSetTableAdapters.cadastro_produtosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroprodutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaodovaleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Produtos
            // 
            this.Produtos.FormattingEnabled = true;
            this.Produtos.Location = new System.Drawing.Point(308, 12);
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(120, 95);
            this.Produtos.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de Debito",
            "Cartão de Credito"});
            this.comboBox1.Location = new System.Drawing.Point(561, 376);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(460, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 88);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "VALOR TOTAL";
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
            this.dataGridView1.Location = new System.Drawing.Point(34, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(633, 207);
            this.dataGridView1.TabIndex = 5;
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
            // cadastro_produtosTableAdapter
            // 
            this.cadastro_produtosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Finalizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(247, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Voltar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Forma de Pagamento";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(818, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 11;
            // 
            // caixasoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Produtos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "caixasoma";
            this.Text = "caixasoma";
            this.Load += new System.EventHandler(this.caixasoma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroprodutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaodovaleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox Produtos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RacaodovaleDataSet racaodovaleDataSet;
        private System.Windows.Forms.BindingSource cadastroprodutosBindingSource;
        private RacaodovaleDataSetTableAdapters.cadastro_produtosTableAdapter cadastro_produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoscdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtosdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtosmarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtostamanhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtosvalorcompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtosvalorvendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}