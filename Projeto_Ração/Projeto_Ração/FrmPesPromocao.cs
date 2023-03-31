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
    public partial class FrmPesPromocao : Form
    {
        public FrmPesPromocao()
        {
            InitializeComponent();
        }

        private void FrmPesPromocao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.promocao_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.promocao_produtoTableAdapter.Fill(this.racaodovaleDataSet.promocao_produto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PROMOCAO colabh = new PROMOCAO();
            this.Hide();
            colabh.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            promocaoprodutoBindingSource.Filter = string.Format("pro_cd={0}", textBox1.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                promocaoprodutoBindingSource.Filter = "";
            }
            else
            {
                promocaoprodutoBindingSource.Filter = string.Format("pro_dt_promocao like'%{0}%'", textBox2.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            FrmAltPromocao newAlterar = new FrmAltPromocao();
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
                promocaoprodutoBindingSource.RemoveCurrent();
                promocao_produtoTableAdapter.Update(racaodovaleDataSet.promocao_produto); //salvar
                this.promocao_produtoTableAdapter.Fill(this.racaodovaleDataSet.promocao_produto);

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
