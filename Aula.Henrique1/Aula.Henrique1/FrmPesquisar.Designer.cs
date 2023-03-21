namespace Aula.Henrique1
{
    partial class FrmPesquisar
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colctpsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltiteleitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colreservistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colestcivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnumdepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsetorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsalarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colemailPesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colemailcorpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaboradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colabDataSet = new Aula.Henrique1.colabDataSet();
            this.colaboradorTableAdapter = new Aula.Henrique1.colabDataSetTableAdapters.colaboradorTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colabDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCDDataGridViewTextBoxColumn,
            this.colctpsDataGridViewTextBoxColumn,
            this.colpisDataGridViewTextBoxColumn,
            this.coltiteleitorDataGridViewTextBoxColumn,
            this.colreservistaDataGridViewTextBoxColumn,
            this.colestcivilDataGridViewTextBoxColumn,
            this.colnumdepDataGridViewTextBoxColumn,
            this.colativoDataGridViewTextBoxColumn,
            this.colsetorDataGridViewTextBoxColumn,
            this.colcargoDataGridViewTextBoxColumn,
            this.colsalarioDataGridViewTextBoxColumn,
            this.colfone1DataGridViewTextBoxColumn,
            this.colfone2DataGridViewTextBoxColumn,
            this.colemailPesDataGridViewTextBoxColumn,
            this.colemailcorpDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.colaboradorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 200);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colCDDataGridViewTextBoxColumn
            // 
            this.colCDDataGridViewTextBoxColumn.DataPropertyName = "col_CD";
            this.colCDDataGridViewTextBoxColumn.HeaderText = "col_CD";
            this.colCDDataGridViewTextBoxColumn.Name = "colCDDataGridViewTextBoxColumn";
            // 
            // colctpsDataGridViewTextBoxColumn
            // 
            this.colctpsDataGridViewTextBoxColumn.DataPropertyName = "col_ctps";
            this.colctpsDataGridViewTextBoxColumn.HeaderText = "col_ctps";
            this.colctpsDataGridViewTextBoxColumn.Name = "colctpsDataGridViewTextBoxColumn";
            // 
            // colpisDataGridViewTextBoxColumn
            // 
            this.colpisDataGridViewTextBoxColumn.DataPropertyName = "col_pis";
            this.colpisDataGridViewTextBoxColumn.HeaderText = "col_pis";
            this.colpisDataGridViewTextBoxColumn.Name = "colpisDataGridViewTextBoxColumn";
            // 
            // coltiteleitorDataGridViewTextBoxColumn
            // 
            this.coltiteleitorDataGridViewTextBoxColumn.DataPropertyName = "col_tit_eleitor";
            this.coltiteleitorDataGridViewTextBoxColumn.HeaderText = "col_tit_eleitor";
            this.coltiteleitorDataGridViewTextBoxColumn.Name = "coltiteleitorDataGridViewTextBoxColumn";
            // 
            // colreservistaDataGridViewTextBoxColumn
            // 
            this.colreservistaDataGridViewTextBoxColumn.DataPropertyName = "col_reservista";
            this.colreservistaDataGridViewTextBoxColumn.HeaderText = "col_reservista";
            this.colreservistaDataGridViewTextBoxColumn.Name = "colreservistaDataGridViewTextBoxColumn";
            // 
            // colestcivilDataGridViewTextBoxColumn
            // 
            this.colestcivilDataGridViewTextBoxColumn.DataPropertyName = "col_est_civil";
            this.colestcivilDataGridViewTextBoxColumn.HeaderText = "col_est_civil";
            this.colestcivilDataGridViewTextBoxColumn.Name = "colestcivilDataGridViewTextBoxColumn";
            // 
            // colnumdepDataGridViewTextBoxColumn
            // 
            this.colnumdepDataGridViewTextBoxColumn.DataPropertyName = "col_num_dep";
            this.colnumdepDataGridViewTextBoxColumn.HeaderText = "col_num_dep";
            this.colnumdepDataGridViewTextBoxColumn.Name = "colnumdepDataGridViewTextBoxColumn";
            // 
            // colativoDataGridViewTextBoxColumn
            // 
            this.colativoDataGridViewTextBoxColumn.DataPropertyName = "col_ativo";
            this.colativoDataGridViewTextBoxColumn.HeaderText = "col_ativo";
            this.colativoDataGridViewTextBoxColumn.Name = "colativoDataGridViewTextBoxColumn";
            // 
            // colsetorDataGridViewTextBoxColumn
            // 
            this.colsetorDataGridViewTextBoxColumn.DataPropertyName = "col_setor";
            this.colsetorDataGridViewTextBoxColumn.HeaderText = "col_setor";
            this.colsetorDataGridViewTextBoxColumn.Name = "colsetorDataGridViewTextBoxColumn";
            // 
            // colcargoDataGridViewTextBoxColumn
            // 
            this.colcargoDataGridViewTextBoxColumn.DataPropertyName = "col_cargo";
            this.colcargoDataGridViewTextBoxColumn.HeaderText = "col_cargo";
            this.colcargoDataGridViewTextBoxColumn.Name = "colcargoDataGridViewTextBoxColumn";
            // 
            // colsalarioDataGridViewTextBoxColumn
            // 
            this.colsalarioDataGridViewTextBoxColumn.DataPropertyName = "col_salario";
            this.colsalarioDataGridViewTextBoxColumn.HeaderText = "col_salario";
            this.colsalarioDataGridViewTextBoxColumn.Name = "colsalarioDataGridViewTextBoxColumn";
            // 
            // colfone1DataGridViewTextBoxColumn
            // 
            this.colfone1DataGridViewTextBoxColumn.DataPropertyName = "col_fone1";
            this.colfone1DataGridViewTextBoxColumn.HeaderText = "col_fone1";
            this.colfone1DataGridViewTextBoxColumn.Name = "colfone1DataGridViewTextBoxColumn";
            // 
            // colfone2DataGridViewTextBoxColumn
            // 
            this.colfone2DataGridViewTextBoxColumn.DataPropertyName = "col_fone2";
            this.colfone2DataGridViewTextBoxColumn.HeaderText = "col_fone2";
            this.colfone2DataGridViewTextBoxColumn.Name = "colfone2DataGridViewTextBoxColumn";
            // 
            // colemailPesDataGridViewTextBoxColumn
            // 
            this.colemailPesDataGridViewTextBoxColumn.DataPropertyName = "col_email_Pes";
            this.colemailPesDataGridViewTextBoxColumn.HeaderText = "col_email_Pes";
            this.colemailPesDataGridViewTextBoxColumn.Name = "colemailPesDataGridViewTextBoxColumn";
            // 
            // colemailcorpDataGridViewTextBoxColumn
            // 
            this.colemailcorpDataGridViewTextBoxColumn.DataPropertyName = "col_email_corp";
            this.colemailcorpDataGridViewTextBoxColumn.HeaderText = "col_email_corp";
            this.colemailcorpDataGridViewTextBoxColumn.Name = "colemailcorpDataGridViewTextBoxColumn";
            // 
            // colaboradorBindingSource
            // 
            this.colaboradorBindingSource.DataMember = "colaborador";
            this.colaboradorBindingSource.DataSource = this.colabDataSet;
            // 
            // colabDataSet
            // 
            this.colabDataSet.DataSetName = "colabDataSet";
            this.colabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colaboradorTableAdapter
            // 
            this.colaboradorTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pesquisar Nome";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(511, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(511, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Alterar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(671, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Limpar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(671, 114);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Deletar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(692, 120);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(8, 17);
            this.button7.TabIndex = 12;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // FrmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPesquisar";
            this.Text = "FrmPesquisar";
            this.Load += new System.EventHandler(this.FrmPesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colabDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private colabDataSet colabDataSet;
        private System.Windows.Forms.BindingSource colaboradorBindingSource;
        private colabDataSetTableAdapters.colaboradorTableAdapter colaboradorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colctpsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltiteleitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colreservistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colestcivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnumdepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsetorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsalarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colemailPesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colemailcorpDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}