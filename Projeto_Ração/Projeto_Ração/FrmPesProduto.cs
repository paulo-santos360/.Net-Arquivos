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
    public partial class FrmPesProduto : Form
    {
        public FrmPesProduto()
        {
            InitializeComponent();
        }

        private void FrmPesProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cadastro_produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_produtosTableAdapter.Fill(this.racaodovaleDataSet.cadastro_produtos);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadastroprodutosBindingSource.Filter = string.Format("produtos_cd={0}", textBox1.Text);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                cadastroprodutosBindingSource.Filter = "";
            }
            else
            {
                cadastroprodutosBindingSource.Filter = string.Format("produtos_desc like'%{0}%'", textBox2.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            produto colabh = new produto();
            this.Hide();
            colabh.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            FrmAltProduto newAlterar = new FrmAltProduto();
            newAlterar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cadastroprodutosBindingSource.RemoveCurrent();
                cadastro_produtosTableAdapter.Update(racaodovaleDataSet.cadastro_produtos); //salvar
                this.cadastro_produtosTableAdapter.Fill(this.racaodovaleDataSet.cadastro_produtos);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
