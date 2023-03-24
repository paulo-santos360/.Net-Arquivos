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
    public partial class FrmCadFornecedor : Form
    {
        public FrmCadFornecedor()
        {
            InitializeComponent();
        }

        private void FrmCadFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cadast_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.cadast_fornecedorTableAdapter.Fill(this.racaodovaleDataSet.cadast_fornecedor);
            cadastfornecedorBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MENU colab4 = new MENU();
            this.Hide();
            colab4.ShowDialog();
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
            this.Validate();
            cadastfornecedorBindingSource.EndEdit();
            cadast_fornecedorTableAdapter.Update(racaodovaleDataSet.cadast_fornecedor);
            this.cadast_fornecedorTableAdapter.Fill(this.racaodovaleDataSet.cadast_fornecedor);
            cadastfornecedorBindingSource.MoveLast();

            //chamar um novo registro
            cadastfornecedorBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Fornecedor cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPesFornecedor colabh = new FrmPesFornecedor();
            this.Hide();
            colabh.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
