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
    public partial class FrmPessEstoque : Form
    {
        public FrmPessEstoque()
        {
            InitializeComponent();
        }

        private void FrmPessEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.controle_estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.controle_estoqueTableAdapter.Fill(this.racaodovaleDataSet.controle_estoque);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CONTROLE colabE = new CONTROLE();
            this.Hide();
            colabE.ShowDialog();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            ForAltEstoque newAlterar = new ForAltEstoque();
            newAlterar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controleestoqueBindingSource.Filter = string.Format("contro_CD={0}", textBox1.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                controleestoqueBindingSource.Filter = "";
            }
            else
            {
                controleestoqueBindingSource.Filter = string.Format("contro_DATA like'%{0}%'", textBox2.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                controleestoqueBindingSource.RemoveCurrent();
                controle_estoqueTableAdapter.Update(racaodovaleDataSet.controle_estoque); //salvar
                this.controle_estoqueTableAdapter.Fill(this.racaodovaleDataSet.controle_estoque);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }
    }
}
