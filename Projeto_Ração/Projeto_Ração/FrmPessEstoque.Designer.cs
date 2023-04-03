namespace Projeto_Ração
{
    partial class FrmPessEstoque
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
            this.controCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controCDPRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controDESCRIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controDATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controDATAENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controDATASAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controCODFORNECEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controRSOCIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controUNIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoscdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controleestoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.controle_estoqueTableAdapter = new Projeto_Ração.RacaodovaleDataSetTableAdapters.controle_estoqueTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleestoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaodovaleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.controCDDataGridViewTextBoxColumn,
            this.controCDPRODataGridViewTextBoxColumn,
            this.controDESCRIDataGridViewTextBoxColumn,
            this.controDATADataGridViewTextBoxColumn,
            this.controDATAENTDataGridViewTextBoxColumn,
            this.controDATASAIDADataGridViewTextBoxColumn,
            this.controCODFORNECEDORDataGridViewTextBoxColumn,
            this.controRSOCIALDataGridViewTextBoxColumn,
            this.controUNIDADEDataGridViewTextBoxColumn,
            this.cadCDDataGridViewTextBoxColumn,
            this.produtoscdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.controleestoqueBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 150);
            this.dataGridView1.TabIndex = 43;
            // 
            // controCDDataGridViewTextBoxColumn
            // 
            this.controCDDataGridViewTextBoxColumn.DataPropertyName = "contro_CD";
            this.controCDDataGridViewTextBoxColumn.HeaderText = "contro_CD";
            this.controCDDataGridViewTextBoxColumn.Name = "controCDDataGridViewTextBoxColumn";
            this.controCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // controCDPRODataGridViewTextBoxColumn
            // 
            this.controCDPRODataGridViewTextBoxColumn.DataPropertyName = "contro_CD_PRO";
            this.controCDPRODataGridViewTextBoxColumn.HeaderText = "contro_CD_PRO";
            this.controCDPRODataGridViewTextBoxColumn.Name = "controCDPRODataGridViewTextBoxColumn";
            // 
            // controDESCRIDataGridViewTextBoxColumn
            // 
            this.controDESCRIDataGridViewTextBoxColumn.DataPropertyName = "contro_DESCRI";
            this.controDESCRIDataGridViewTextBoxColumn.HeaderText = "contro_DESCRI";
            this.controDESCRIDataGridViewTextBoxColumn.Name = "controDESCRIDataGridViewTextBoxColumn";
            // 
            // controDATADataGridViewTextBoxColumn
            // 
            this.controDATADataGridViewTextBoxColumn.DataPropertyName = "contro_DATA";
            this.controDATADataGridViewTextBoxColumn.HeaderText = "contro_DATA";
            this.controDATADataGridViewTextBoxColumn.Name = "controDATADataGridViewTextBoxColumn";
            // 
            // controDATAENTDataGridViewTextBoxColumn
            // 
            this.controDATAENTDataGridViewTextBoxColumn.DataPropertyName = "contro_DATA_ENT";
            this.controDATAENTDataGridViewTextBoxColumn.HeaderText = "contro_DATA_ENT";
            this.controDATAENTDataGridViewTextBoxColumn.Name = "controDATAENTDataGridViewTextBoxColumn";
            // 
            // controDATASAIDADataGridViewTextBoxColumn
            // 
            this.controDATASAIDADataGridViewTextBoxColumn.DataPropertyName = "contro_DATA_SAIDA";
            this.controDATASAIDADataGridViewTextBoxColumn.HeaderText = "contro_DATA_SAIDA";
            this.controDATASAIDADataGridViewTextBoxColumn.Name = "controDATASAIDADataGridViewTextBoxColumn";
            // 
            // controCODFORNECEDORDataGridViewTextBoxColumn
            // 
            this.controCODFORNECEDORDataGridViewTextBoxColumn.DataPropertyName = "contro_COD_FORNECEDOR";
            this.controCODFORNECEDORDataGridViewTextBoxColumn.HeaderText = "contro_COD_FORNECEDOR";
            this.controCODFORNECEDORDataGridViewTextBoxColumn.Name = "controCODFORNECEDORDataGridViewTextBoxColumn";
            // 
            // controRSOCIALDataGridViewTextBoxColumn
            // 
            this.controRSOCIALDataGridViewTextBoxColumn.DataPropertyName = "contro_RSOCIAL";
            this.controRSOCIALDataGridViewTextBoxColumn.HeaderText = "contro_RSOCIAL";
            this.controRSOCIALDataGridViewTextBoxColumn.Name = "controRSOCIALDataGridViewTextBoxColumn";
            // 
            // controUNIDADEDataGridViewTextBoxColumn
            // 
            this.controUNIDADEDataGridViewTextBoxColumn.DataPropertyName = "contro_UNIDADE";
            this.controUNIDADEDataGridViewTextBoxColumn.HeaderText = "contro_UNIDADE";
            this.controUNIDADEDataGridViewTextBoxColumn.Name = "controUNIDADEDataGridViewTextBoxColumn";
            // 
            // cadCDDataGridViewTextBoxColumn
            // 
            this.cadCDDataGridViewTextBoxColumn.DataPropertyName = "cad_CD";
            this.cadCDDataGridViewTextBoxColumn.HeaderText = "cad_CD";
            this.cadCDDataGridViewTextBoxColumn.Name = "cadCDDataGridViewTextBoxColumn";
            // 
            // produtoscdDataGridViewTextBoxColumn
            // 
            this.produtoscdDataGridViewTextBoxColumn.DataPropertyName = "produtos_cd";
            this.produtoscdDataGridViewTextBoxColumn.HeaderText = "produtos_cd";
            this.produtoscdDataGridViewTextBoxColumn.Name = "produtoscdDataGridViewTextBoxColumn";
            // 
            // controleestoqueBindingSource
            // 
            this.controleestoqueBindingSource.DataMember = "controle_estoque";
            this.controleestoqueBindingSource.DataSource = this.racaodovaleDataSet;
            // 
            // racaodovaleDataSet
            // 
            this.racaodovaleDataSet.DataSetName = "RacaodovaleDataSet";
            this.racaodovaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "DATA DA PRODUTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "NOME DO PRODUTO";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 40;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 39;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(163, 210);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 38;
            this.button6.Text = "DELETAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 37;
            this.button5.Text = "ALTERAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(163, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "PESQUISAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "PESQUISAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "LIMPAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // controle_estoqueTableAdapter
            // 
            this.controle_estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(12, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 31);
            this.label3.TabIndex = 44;
            this.label3.Text = "RAÇÃODOVALE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_Ração.Properties.Resources.raçao1;
            this.pictureBox1.Location = new System.Drawing.Point(277, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 272);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPessEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
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
            this.Name = "FrmPessEstoque";
            this.Text = "FrmPesEstoque";
            this.Load += new System.EventHandler(this.FrmPessEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleestoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaodovaleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.BindingSource controleestoqueBindingSource;
        private RacaodovaleDataSetTableAdapters.controle_estoqueTableAdapter controle_estoqueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn controCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controCDPRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controDESCRIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controDATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controDATAENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controDATASAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controCODFORNECEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controRSOCIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controUNIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoscdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}