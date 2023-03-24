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
    public partial class ForAltEstoque : Form
    {
        public ForAltEstoque()
        {
            InitializeComponent();
        }

        private void ForAltEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.controle_estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.controle_estoqueTableAdapter.Fill(this.racaodovaleDataSet.controle_estoque);
            if (Class1.codigo == "")//
            { controleestoqueBindingSource.AddNew(); }//
            else//
            { controleestoqueBindingSource.Filter = string.Format("contro_CD={0}", Class1.codigo); }// textBox1.Text); }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            controleestoqueBindingSource.EndEdit();
            controle_estoqueTableAdapter.Update(racaodovaleDataSet.controle_estoque);
            this.controle_estoqueTableAdapter.Fill(this.racaodovaleDataSet.controle_estoque);
            controleestoqueBindingSource.MoveLast();


            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Estoque Alteradada  com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
            FrmPessEstoque colabE = new FrmPessEstoque();
            this.Hide();
            colabE.ShowDialog();
        }
    }
}
