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
    public partial class FrmPesCliente : Form
    {
        public FrmPesCliente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadCliente colabh = new CadCliente();
            this.Hide();
            colabh.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            FrmAltClient newAlterar = new FrmAltClient();
            newAlterar.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            cadastroclienteBindingSource.Filter = string.Format("cadastro_CD={0}", textBox1.Text);
        }

        private void FrmPesCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cadastro_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_clienteTableAdapter.Fill(this.racaodovaleDataSet.cadastro_cliente);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                cadastroclienteBindingSource.Filter = "";
            }
            else
            {
                cadastroclienteBindingSource.Filter = string.Format("cadastro_RG like'%{0}%'", textBox2.Text);
            }
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
                cadastroclienteBindingSource.RemoveCurrent();
                cadastro_clienteTableAdapter.Update(racaodovaleDataSet.cadastro_cliente); //salvar
                this.cadastro_clienteTableAdapter.Fill(this.racaodovaleDataSet.cadastro_cliente);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }
    }
}
