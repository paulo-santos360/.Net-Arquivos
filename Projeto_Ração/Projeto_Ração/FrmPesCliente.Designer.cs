﻿namespace Projeto_Ração
{
    partial class FrmPesCliente
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
            this.cadastroCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroRGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroDTNASCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastrofoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastrofonereferenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racaodovaleDataSet = new Projeto_Ração.RacaodovaleDataSet();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cadastro_clienteTableAdapter = new Projeto_Ração.RacaodovaleDataSetTableAdapters.cadastro_clienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaodovaleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cadastroCDDataGridViewTextBoxColumn,
            this.cadastroNMDataGridViewTextBoxColumn,
            this.cadastroRGDataGridViewTextBoxColumn,
            this.cadastroDTNASCDataGridViewTextBoxColumn,
            this.cadastroEmailDataGridViewTextBoxColumn,
            this.cadastrofoneDataGridViewTextBoxColumn,
            this.cadastrofonereferenciaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cadastroclienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(754, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // cadastroCDDataGridViewTextBoxColumn
            // 
            this.cadastroCDDataGridViewTextBoxColumn.DataPropertyName = "cadastro_CD";
            this.cadastroCDDataGridViewTextBoxColumn.HeaderText = "cadastro_CD";
            this.cadastroCDDataGridViewTextBoxColumn.Name = "cadastroCDDataGridViewTextBoxColumn";
            this.cadastroCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cadastroNMDataGridViewTextBoxColumn
            // 
            this.cadastroNMDataGridViewTextBoxColumn.DataPropertyName = "cadastro_NM";
            this.cadastroNMDataGridViewTextBoxColumn.HeaderText = "cadastro_NM";
            this.cadastroNMDataGridViewTextBoxColumn.Name = "cadastroNMDataGridViewTextBoxColumn";
            // 
            // cadastroRGDataGridViewTextBoxColumn
            // 
            this.cadastroRGDataGridViewTextBoxColumn.DataPropertyName = "cadastro_RG";
            this.cadastroRGDataGridViewTextBoxColumn.HeaderText = "cadastro_RG";
            this.cadastroRGDataGridViewTextBoxColumn.Name = "cadastroRGDataGridViewTextBoxColumn";
            // 
            // cadastroDTNASCDataGridViewTextBoxColumn
            // 
            this.cadastroDTNASCDataGridViewTextBoxColumn.DataPropertyName = "cadastro_DT_NASC";
            this.cadastroDTNASCDataGridViewTextBoxColumn.HeaderText = "cadastro_DT_NASC";
            this.cadastroDTNASCDataGridViewTextBoxColumn.Name = "cadastroDTNASCDataGridViewTextBoxColumn";
            // 
            // cadastroEmailDataGridViewTextBoxColumn
            // 
            this.cadastroEmailDataGridViewTextBoxColumn.DataPropertyName = "cadastro_Email";
            this.cadastroEmailDataGridViewTextBoxColumn.HeaderText = "cadastro_Email";
            this.cadastroEmailDataGridViewTextBoxColumn.Name = "cadastroEmailDataGridViewTextBoxColumn";
            // 
            // cadastrofoneDataGridViewTextBoxColumn
            // 
            this.cadastrofoneDataGridViewTextBoxColumn.DataPropertyName = "cadastro_fone";
            this.cadastrofoneDataGridViewTextBoxColumn.HeaderText = "cadastro_fone";
            this.cadastrofoneDataGridViewTextBoxColumn.Name = "cadastrofoneDataGridViewTextBoxColumn";
            // 
            // cadastrofonereferenciaDataGridViewTextBoxColumn
            // 
            this.cadastrofonereferenciaDataGridViewTextBoxColumn.DataPropertyName = "cadastro_fone_referencia";
            this.cadastrofonereferenciaDataGridViewTextBoxColumn.HeaderText = "cadastro_fone_referencia";
            this.cadastrofonereferenciaDataGridViewTextBoxColumn.Name = "cadastrofonereferenciaDataGridViewTextBoxColumn";
            // 
            // cadastroclienteBindingSource
            // 
            this.cadastroclienteBindingSource.DataMember = "cadastro_cliente";
            this.cadastroclienteBindingSource.DataSource = this.racaodovaleDataSet;
            // 
            // racaodovaleDataSet
            // 
            this.racaodovaleDataSet.DataSetName = "RacaodovaleDataSet";
            this.racaodovaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(682, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "DELETAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(682, 87);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "LIMPAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(535, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "ALTERAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(535, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "VOLTAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "PESQUISAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "PESQUISAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "RG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "NOME";
            // 
            // cadastro_clienteTableAdapter
            // 
            this.cadastro_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPesCliente";
            this.Text = "FrmPesCliente";
            this.Load += new System.EventHandler(this.FrmPesCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaodovaleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RacaodovaleDataSet racaodovaleDataSet;
        private System.Windows.Forms.BindingSource cadastroclienteBindingSource;
        private RacaodovaleDataSetTableAdapters.cadastro_clienteTableAdapter cadastro_clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadastroCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadastroNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadastroRGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadastroDTNASCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadastroEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadastrofoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadastrofonereferenciaDataGridViewTextBoxColumn;
    }
}