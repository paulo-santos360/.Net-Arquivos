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
    public partial class FrmAltProduto : Form
    {
        public FrmAltProduto()
        {
            InitializeComponent();
        }

        private void CADASTRAR_Click(object sender, EventArgs e)
        {

            this.Validate();
            cadastroprodutosBindingSource.EndEdit();
            cadastro_produtosTableAdapter.Update(racaodovaleDataSet.cadastro_produtos);
            this.cadastro_produtosTableAdapter.Fill(this.racaodovaleDataSet.cadastro_produtos);
            cadastroprodutosBindingSource.MoveLast();

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
            FrmPesProduto colab1 = new FrmPesProduto();
            this.Hide();
            colab1.ShowDialog();
        }

        private void FrmAltProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cadastro_produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_produtosTableAdapter.Fill(this.racaodovaleDataSet.cadastro_produtos);
            if (Class1.codigo == "")//
            { cadastroprodutosBindingSource.AddNew(); }//
            else//
            { cadastroprodutosBindingSource.Filter = string.Format("produtos_cd={0}", Class1.codigo); }// textBox1.Text); }
        }
    }
}
