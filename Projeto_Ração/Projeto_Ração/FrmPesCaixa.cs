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
    public partial class FrmPesCaixa : Form
    {
        public FrmPesCaixa()
        {
            InitializeComponent();
        }

        private void FrmPesCaixa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.controle_caixa'. Você pode movê-la ou removê-la conforme necessário.
            this.controle_caixaTableAdapter.Fill(this.racaodovaleDataSet.controle_caixa);

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
            CadCaixa colabh = new CadCaixa();
            this.Hide();
            colabh.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlecaixaBindingSource.Filter = string.Format("controle_cd={0}", textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                controlecaixaBindingSource.Filter = "";
            }
            else
            {
                controlecaixaBindingSource.Filter = string.Format("controle_abertura_caixa like'%{0}%'", textBox2.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            FrmAltCaixa newAlterar = new FrmAltCaixa();
            newAlterar.ShowDialog();
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
                controlecaixaBindingSource.RemoveCurrent();
                controle_caixaTableAdapter.Update(racaodovaleDataSet.controle_caixa); //salvar
                this.controle_caixaTableAdapter.Fill(this.racaodovaleDataSet.controle_caixa);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }
    }
}
