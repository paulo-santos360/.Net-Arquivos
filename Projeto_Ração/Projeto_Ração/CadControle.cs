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
    public partial class CadControle : Form
    {
        public CadControle()
        {
            InitializeComponent();
        }

        private void CadControle_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cadastro_produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_produtosTableAdapter.Fill(this.racaodovaleDataSet.cadastro_produtos);
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.controle_estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.controle_estoqueTableAdapter.Fill(this.racaodovaleDataSet.controle_estoque);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            controleestoqueBindingSource.EndEdit();
            controle_estoqueTableAdapter.Update(racaodovaleDataSet.controle_estoque);
            this.controle_estoqueTableAdapter.Fill(this.racaodovaleDataSet.controle_estoque);
            controleestoqueBindingSource.MoveLast();

            //chamar um novo registro
            controleestoqueBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Fornecedor cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            MENU colab4 = new MENU();
            this.Hide();
            colab4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPesProduto colabh = new FrmPesProduto();
            this.Hide();
            colabh.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
