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
    public partial class PROMOCAO : Form
    {
        public PROMOCAO()
        {
            InitializeComponent();
        }

        private void PROMOCAO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.promocao_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.promocao_produtoTableAdapter.Fill(this.racaodovaleDataSet.promocao_produto);
            promocaoprodutoBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MENU colabF = new MENU();
            this.Hide();
            colabF.ShowDialog();
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
            this.Validate();
            promocaoprodutoBindingSource.EndEdit();
            promocao_produtoTableAdapter.Update(racaodovaleDataSet.promocao_produto);
            this.promocao_produtoTableAdapter.Fill(this.racaodovaleDataSet.promocao_produto);
            promocaoprodutoBindingSource.MoveLast();

            //chamar um novo registro
            promocaoprodutoBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("cliente cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPesPromocao colabE = new FrmPesPromocao();
            this.Hide();
            colabE.ShowDialog();
        }
    }
}
