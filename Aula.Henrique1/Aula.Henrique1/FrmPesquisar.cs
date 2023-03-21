using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula.Henrique1
{
    public partial class FrmPesquisar : Form
    {
        public FrmPesquisar()
        {
            InitializeComponent();
        }

        private void FrmPesquisar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.colaborador'. Você pode movê-la ou removê-la conforme necessário.
            this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colaboradorBindingSource.Filter = string.Format("col_CD={0}", textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                colaboradorBindingSource.Filter = "";
            }
            else
            {
                colaboradorBindingSource.Filter = string.Format("col_ctps like'%{0}%'", textBox2.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            Alterar newAlterar = new Alterar();
            newAlterar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colaborador colab = new colaborador();
            this.Hide();
            colab.ShowDialog();
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                colaboradorBindingSource.RemoveCurrent();
                colaboradorTableAdapter.Update(colabDataSet.colaborador); //salvar
                this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }
    }
}
