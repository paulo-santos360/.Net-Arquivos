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
    public partial class ForAltFornecedor : Form
    {
        public ForAltFornecedor()
        {
            InitializeComponent();
        }

        private void ForAltFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cadast_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.cadast_fornecedorTableAdapter.Fill(this.racaodovaleDataSet.cadast_fornecedor);
            if (Class1.codigo == "")//
            { cadastfornecedorBindingSource.AddNew(); }//
            else//
            { cadastfornecedorBindingSource.Filter = string.Format("forn_CD={0}", Class1.codigo); }// textBox1.Text); }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmPesFornecedor colab1 = new FrmPesFornecedor();
            this.Hide();
            colab1.ShowDialog();
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


            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Fornecedor Alteradada  com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }
    }
}
