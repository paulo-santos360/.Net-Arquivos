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
    public partial class produto : Form
    {
        public produto()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MENU colabE = new MENU();
            this.Hide();
            colabE.ShowDialog();
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

        private void CADASTRAR_Click(object sender, EventArgs e)
        {
            this.Validate();
            cadastroprodutosBindingSource.EndEdit();
            cadastro_produtosTableAdapter.Update(racaodovaleDataSet.cadastro_produtos);
            this.cadastro_produtosTableAdapter.Fill(this.racaodovaleDataSet.cadastro_produtos);
            cadastroprodutosBindingSource.MoveLast();

            //chamar um novo registro
            cadastroprodutosBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Produto cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void produto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cadastro_produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_produtosTableAdapter.Fill(this.racaodovaleDataSet.cadastro_produtos);
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.controle_estoque'. Você pode movê-la ou removê-la conforme necessário.
            //this.controle_estoqueTableAdapter.Fill(this.racaodovaleDataSet.controle_estoque);
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cadastro_produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_produtosTableAdapter.Fill(this.racaodovaleDataSet.cadastro_produtos);
            cadastroprodutosBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPesProduto colabh = new FrmPesProduto();
            this.Hide();
            colabh.ShowDialog();
        }
    }
}
