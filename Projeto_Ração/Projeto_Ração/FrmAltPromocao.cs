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
    public partial class FrmAltPromocao : Form
    {
        public FrmAltPromocao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            promocaoprodutoBindingSource.EndEdit();
            promocao_produtoTableAdapter.Update(racaodovaleDataSet.promocao_produto);
            this.promocao_produtoTableAdapter.Fill(this.racaodovaleDataSet.promocao_produto);
            promocaoprodutoBindingSource.MoveLast();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Cadastro cliente cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
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

        private void button5_Click(object sender, EventArgs e)
        {
            FrmPesPromocao colabh = new FrmPesPromocao();
            this.Hide();
            colabh.ShowDialog();
        }

        private void FrmAltPromocao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.promocao_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.promocao_produtoTableAdapter.Fill(this.racaodovaleDataSet.promocao_produto);
            this.promocao_produtoTableAdapter.Fill(this.racaodovaleDataSet.promocao_produto);
            if (Class1.codigo == "")//
            { promocaoprodutoBindingSource.AddNew(); }//
            else//
            { promocaoprodutoBindingSource.Filter = string.Format("pro_cd={0}", Class1.codigo); }// textBox1.Text); }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
