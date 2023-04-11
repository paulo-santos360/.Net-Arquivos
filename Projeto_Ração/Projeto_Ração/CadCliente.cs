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
    public partial class CadCliente : Form
    {
        public CadCliente()
        {
            InitializeComponent();
        }

        private void CadCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cadastro_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_clienteTableAdapter.Fill(this.racaodovaleDataSet.cadastro_cliente);
            cadastroclienteBindingSource.AddNew();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MENU colab3 = new MENU();
            this.Hide();
            colab3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
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
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Entre com os dados");
            }
            else
                this.Validate();
            cadastroclienteBindingSource.EndEdit();
            cadastro_clienteTableAdapter.Update(racaodovaleDataSet.cadastro_cliente);
            this.cadastro_clienteTableAdapter.Fill(this.racaodovaleDataSet.cadastro_cliente);
            cadastroclienteBindingSource.MoveLast();

            //chamar um novo registro
            cadastroclienteBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("cliente cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPesCliente colabh = new FrmPesCliente();
            this.Hide();
            colabh.ShowDialog();
        }
    }
}
