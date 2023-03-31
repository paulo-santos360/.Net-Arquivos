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
    public partial class FrmPesFunc : Form
    {
        public FrmPesFunc()
        {
            InitializeComponent();
        }

        private void FrmPesFunc_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cad_funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_funcionarioTableAdapter.Fill(this.racaodovaleDataSet.cad_funcionario);

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

        private void button1_Click(object sender, EventArgs e)
        {
            CadFunc colabh = new CadFunc();
            this.Hide();
            colabh.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            ForAltFunc newAlterar = new ForAltFunc();
            newAlterar.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadfuncionarioBindingSource.Filter = string.Format("cad_CD={0}", textBox1.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                cadfuncionarioBindingSource.Filter = "";
            }
            else
            {
                cadfuncionarioBindingSource.Filter = string.Format("cad_CPF like'%{0}%'", textBox2.Text);
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
                cadfuncionarioBindingSource.RemoveCurrent();
                cad_funcionarioTableAdapter.Update(racaodovaleDataSet.cad_funcionario); //salvar
                this.cad_funcionarioTableAdapter.Fill(this.racaodovaleDataSet.cad_funcionario);

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
