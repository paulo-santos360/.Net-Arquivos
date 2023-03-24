namespace Projeto_Ração
{
    partial class FrmPesFunc
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.racaodovaleDataSet = new Projeto_Ração.RacaodovaleDataSet();
            this.cadfuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cad_funcionarioTableAdapter = new Projeto_Ração.RacaodovaleDataSetTableAdapters.cad_funcionarioTableAdapter();
            this.cadCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadCPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadRGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadDTNASCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadSENHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadCARGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaodovaleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadfuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "LIMPAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(357, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "PESQUISAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(357, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "PESQUISAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(499, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "ALTERAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(652, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "DELETAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "NOME DO FUNCIONARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CPF DO FUNCIONARIO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cadCDDataGridViewTextBoxColumn,
            this.cadNMDataGridViewTextBoxColumn,
            this.cadCPFDataGridViewTextBoxColumn,
            this.cadRGDataGridViewTextBoxColumn,
            this.cadDTNASCDataGridViewTextBoxColumn,
            this.cadENDDataGridViewTextBoxColumn,
            this.cadEMAILDataGridViewTextBoxColumn,
            this.cadUSUARIODataGridViewTextBoxColumn,
            this.cadSENHADataGridViewTextBoxColumn,
            this.cadCARGODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cadfuncionarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(58, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // racaodovaleDataSet
            // 
            this.racaodovaleDataSet.DataSetName = "RacaodovaleDataSet";
            this.racaodovaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadfuncionarioBindingSource
            // 
            this.cadfuncionarioBindingSource.DataMember = "cad_funcionario";
            this.cadfuncionarioBindingSource.DataSource = this.racaodovaleDataSet;
            // 
            // cad_funcionarioTableAdapter
            // 
            this.cad_funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // cadCDDataGridViewTextBoxColumn
            // 
            this.cadCDDataGridViewTextBoxColumn.DataPropertyName = "cad_CD";
            this.cadCDDataGridViewTextBoxColumn.HeaderText = "cad_CD";
            this.cadCDDataGridViewTextBoxColumn.Name = "cadCDDataGridViewTextBoxColumn";
            this.cadCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cadNMDataGridViewTextBoxColumn
            // 
            this.cadNMDataGridViewTextBoxColumn.DataPropertyName = "cad_NM";
            this.cadNMDataGridViewTextBoxColumn.HeaderText = "cad_NM";
            this.cadNMDataGridViewTextBoxColumn.Name = "cadNMDataGridViewTextBoxColumn";
            // 
            // cadCPFDataGridViewTextBoxColumn
            // 
            this.cadCPFDataGridViewTextBoxColumn.DataPropertyName = "cad_CPF";
            this.cadCPFDataGridViewTextBoxColumn.HeaderText = "cad_CPF";
            this.cadCPFDataGridViewTextBoxColumn.Name = "cadCPFDataGridViewTextBoxColumn";
            // 
            // cadRGDataGridViewTextBoxColumn
            // 
            this.cadRGDataGridViewTextBoxColumn.DataPropertyName = "cad_RG";
            this.cadRGDataGridViewTextBoxColumn.HeaderText = "cad_RG";
            this.cadRGDataGridViewTextBoxColumn.Name = "cadRGDataGridViewTextBoxColumn";
            // 
            // cadDTNASCDataGridViewTextBoxColumn
            // 
            this.cadDTNASCDataGridViewTextBoxColumn.DataPropertyName = "cad_DT_NASC";
            this.cadDTNASCDataGridViewTextBoxColumn.HeaderText = "cad_DT_NASC";
            this.cadDTNASCDataGridViewTextBoxColumn.Name = "cadDTNASCDataGridViewTextBoxColumn";
            // 
            // cadENDDataGridViewTextBoxColumn
            // 
            this.cadENDDataGridViewTextBoxColumn.DataPropertyName = "cad_END";
            this.cadENDDataGridViewTextBoxColumn.HeaderText = "cad_END";
            this.cadENDDataGridViewTextBoxColumn.Name = "cadENDDataGridViewTextBoxColumn";
            // 
            // cadEMAILDataGridViewTextBoxColumn
            // 
            this.cadEMAILDataGridViewTextBoxColumn.DataPropertyName = "cad_EMAIL";
            this.cadEMAILDataGridViewTextBoxColumn.HeaderText = "cad_EMAIL";
            this.cadEMAILDataGridViewTextBoxColumn.Name = "cadEMAILDataGridViewTextBoxColumn";
            // 
            // cadUSUARIODataGridViewTextBoxColumn
            // 
            this.cadUSUARIODataGridViewTextBoxColumn.DataPropertyName = "cad_USUARIO";
            this.cadUSUARIODataGridViewTextBoxColumn.HeaderText = "cad_USUARIO";
            this.cadUSUARIODataGridViewTextBoxColumn.Name = "cadUSUARIODataGridViewTextBoxColumn";
            // 
            // cadSENHADataGridViewTextBoxColumn
            // 
            this.cadSENHADataGridViewTextBoxColumn.DataPropertyName = "cad_SENHA";
            this.cadSENHADataGridViewTextBoxColumn.HeaderText = "cad_SENHA";
            this.cadSENHADataGridViewTextBoxColumn.Name = "cadSENHADataGridViewTextBoxColumn";
            // 
            // cadCARGODataGridViewTextBoxColumn
            // 
            this.cadCARGODataGridViewTextBoxColumn.DataPropertyName = "cad_CARGO";
            this.cadCARGODataGridViewTextBoxColumn.HeaderText = "cad_CARGO";
            this.cadCARGODataGridViewTextBoxColumn.Name = "cadCARGODataGridViewTextBoxColumn";
            // 
            // FrmPesFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FrmPesFunc";
            this.Text = "FrmPesFunc";
            this.Load += new System.EventHandler(this.FrmPesFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaodovaleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadfuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RacaodovaleDataSet racaodovaleDataSet;
        private System.Windows.Forms.BindingSource cadfuncionarioBindingSource;
        private RacaodovaleDataSetTableAdapters.cad_funcionarioTableAdapter cad_funcionarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadCPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadRGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadDTNASCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadSENHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadCARGODataGridViewTextBoxColumn;
    }
}