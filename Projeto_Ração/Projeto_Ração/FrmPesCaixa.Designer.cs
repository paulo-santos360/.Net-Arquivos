namespace Projeto_Ração
{
    partial class FrmPesCaixa
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.controlecdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controleaberturacaixaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlefechamentocaixaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlecdbarraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controledescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controleQTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controleVALORPRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoscdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlecaixaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racaodovaleDataSet = new Projeto_Ração.RacaodovaleDataSet();
            this.controle_caixaTableAdapter = new Projeto_Ração.RacaodovaleDataSetTableAdapters.controle_caixaTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlecaixaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaodovaleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROLE DE CAIXA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ABERTURA DE CAIXA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "PESQUISAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "PESQUISAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "VOLTAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "ALTERAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(155, 151);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "LIMPAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(155, 209);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "DELETAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.controlecdDataGridViewTextBoxColumn,
            this.controleaberturacaixaDataGridViewTextBoxColumn,
            this.controlefechamentocaixaDataGridViewTextBoxColumn,
            this.controlecdbarraDataGridViewTextBoxColumn,
            this.controledescDataGridViewTextBoxColumn,
            this.controleQTDataGridViewTextBoxColumn,
            this.controleVALORPRODataGridViewTextBoxColumn,
            this.cadCDDataGridViewTextBoxColumn,
            this.produtoscdDataGridViewTextBoxColumn,
            this.cadastroCDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.controlecaixaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-6, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(806, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // controlecdDataGridViewTextBoxColumn
            // 
            this.controlecdDataGridViewTextBoxColumn.DataPropertyName = "controle_cd";
            this.controlecdDataGridViewTextBoxColumn.HeaderText = "controle_cd";
            this.controlecdDataGridViewTextBoxColumn.Name = "controlecdDataGridViewTextBoxColumn";
            this.controlecdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // controleaberturacaixaDataGridViewTextBoxColumn
            // 
            this.controleaberturacaixaDataGridViewTextBoxColumn.DataPropertyName = "controle_abertura_caixa";
            this.controleaberturacaixaDataGridViewTextBoxColumn.HeaderText = "controle_abertura_caixa";
            this.controleaberturacaixaDataGridViewTextBoxColumn.Name = "controleaberturacaixaDataGridViewTextBoxColumn";
            // 
            // controlefechamentocaixaDataGridViewTextBoxColumn
            // 
            this.controlefechamentocaixaDataGridViewTextBoxColumn.DataPropertyName = "controle_fechamento_caixa";
            this.controlefechamentocaixaDataGridViewTextBoxColumn.HeaderText = "controle_fechamento_caixa";
            this.controlefechamentocaixaDataGridViewTextBoxColumn.Name = "controlefechamentocaixaDataGridViewTextBoxColumn";
            // 
            // controlecdbarraDataGridViewTextBoxColumn
            // 
            this.controlecdbarraDataGridViewTextBoxColumn.DataPropertyName = "controle_cd_barra";
            this.controlecdbarraDataGridViewTextBoxColumn.HeaderText = "controle_cd_barra";
            this.controlecdbarraDataGridViewTextBoxColumn.Name = "controlecdbarraDataGridViewTextBoxColumn";
            // 
            // controledescDataGridViewTextBoxColumn
            // 
            this.controledescDataGridViewTextBoxColumn.DataPropertyName = "controle_desc";
            this.controledescDataGridViewTextBoxColumn.HeaderText = "controle_desc";
            this.controledescDataGridViewTextBoxColumn.Name = "controledescDataGridViewTextBoxColumn";
            // 
            // controleQTDataGridViewTextBoxColumn
            // 
            this.controleQTDataGridViewTextBoxColumn.DataPropertyName = "controle_QT";
            this.controleQTDataGridViewTextBoxColumn.HeaderText = "controle_QT";
            this.controleQTDataGridViewTextBoxColumn.Name = "controleQTDataGridViewTextBoxColumn";
            // 
            // controleVALORPRODataGridViewTextBoxColumn
            // 
            this.controleVALORPRODataGridViewTextBoxColumn.DataPropertyName = "controle_VALOR_PRO";
            this.controleVALORPRODataGridViewTextBoxColumn.HeaderText = "controle_VALOR_PRO";
            this.controleVALORPRODataGridViewTextBoxColumn.Name = "controleVALORPRODataGridViewTextBoxColumn";
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
            // cadastroCDDataGridViewTextBoxColumn
            // 
            this.cadastroCDDataGridViewTextBoxColumn.DataPropertyName = "cadastro_CD";
            this.cadastroCDDataGridViewTextBoxColumn.HeaderText = "cadastro_CD";
            this.cadastroCDDataGridViewTextBoxColumn.Name = "cadastroCDDataGridViewTextBoxColumn";
            // 
            // controlecaixaBindingSource
            // 
            this.controlecaixaBindingSource.DataMember = "controle_caixa";
            this.controlecaixaBindingSource.DataSource = this.racaodovaleDataSet;
            // 
            // racaodovaleDataSet
            // 
            this.racaodovaleDataSet.DataSetName = "RacaodovaleDataSet";
            this.racaodovaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controle_caixaTableAdapter
            // 
            this.controle_caixaTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(12, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "RAÇÃODOVALE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_Ração.Properties.Resources._16_balcao_caixa_574058;
            this.pictureBox1.Location = new System.Drawing.Point(376, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 264);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(250, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "PESQUISA DE CAIXA";
            // 
            // FrmPesCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPesCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPesCaixa";
            this.Load += new System.EventHandler(this.FrmPesCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlecaixaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaodovaleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RacaodovaleDataSet racaodovaleDataSet;
        private System.Windows.Forms.BindingSource controlecaixaBindingSource;
        private RacaodovaleDataSetTableAdapters.controle_caixaTableAdapter controle_caixaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlecdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controleaberturacaixaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlefechamentocaixaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlecdbarraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controledescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controleQTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controleVALORPRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoscdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadastroCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}