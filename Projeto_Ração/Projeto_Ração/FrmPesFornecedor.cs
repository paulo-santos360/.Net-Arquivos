using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Ração
{
    public partial class FrmPesFornecedor : Form
    {
        public FrmPesFornecedor()
        {
            InitializeComponent();
        }

        private void FrmPesFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cadast_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.cadast_fornecedorTableAdapter.Fill(this.racaodovaleDataSet.cadast_fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cad_funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.cadast_fornecedorTableAdapter.Fill(this.racaodovaleDataSet.cadast_fornecedor);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    TextBox textBox = (TextBox)controle;
                    textBox.Text = string.Empty;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCadFornecedor colabh = new FrmCadFornecedor();
            this.Hide();
            colabh.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cadastfornecedorBindingSource.RemoveCurrent();
                cadast_fornecedorTableAdapter.Update(racaodovaleDataSet.cadast_fornecedor); //salvar
                this.cadast_fornecedorTableAdapter.Fill(this.racaodovaleDataSet.cadast_fornecedor);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            ForAltFornecedor newAlterar = new ForAltFornecedor();
            newAlterar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastfornecedorBindingSource.Filter = string.Format("forn_CD={0}", textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                cadastfornecedorBindingSource.Filter = "";
            }
            else
            {
                cadastfornecedorBindingSource.Filter = string.Format("forn_CNPJ like'%{0}%'", textBox2.Text);
            }
        }
    }
}
