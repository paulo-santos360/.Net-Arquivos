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
    public partial class FrmPesContas : Form
    {
        public FrmPesContas()
        {
            InitializeComponent();
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
            CONTAS colabh = new CONTAS();
            this.Hide();
            colabh.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                contasBindingSource.RemoveCurrent();
                contasTableAdapter.Update(racaodovaleDataSet.contas); //salvar
                this.contasTableAdapter.Fill(this.racaodovaleDataSet.contas);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }

        private void FrmPesContas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.contas'. Você pode movê-la ou removê-la conforme necessário.
            this.contasTableAdapter.Fill(this.racaodovaleDataSet.contas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contasBindingSource.Filter = string.Format("contas_CD={0}", textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                contasBindingSource.Filter = "";
            }
            else
            {
                contasBindingSource.Filter = string.Format("contas_barra like'%{0}%'", textBox2.Text);
            }
        }
    }
}
