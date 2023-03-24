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
    public partial class FrmAltClient : Form
    {
        public FrmAltClient()
        {
            InitializeComponent();
        }

        private void FrmAltClient_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cadastro_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_clienteTableAdapter.Fill(this.racaodovaleDataSet.cadastro_cliente);
            if (Class1.codigo == "")//
            { cadastroclienteBindingSource.AddNew(); }//
            else//
            { cadastroclienteBindingSource.Filter = string.Format("cadastro_CD={0}", Class1.codigo); }// textBox1.Text); }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            cadastroclienteBindingSource.EndEdit();
            cadastro_clienteTableAdapter.Update(racaodovaleDataSet.cadastro_cliente);
            this.cadastro_clienteTableAdapter.Fill(this.racaodovaleDataSet.cadastro_cliente);
            cadastroclienteBindingSource.MoveLast();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Cadastro cliente cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            cadastroclienteBindingSource.EndEdit();
            cadastro_clienteTableAdapter.Update(racaodovaleDataSet.cadastro_cliente);
            this.cadastro_clienteTableAdapter.Fill(this.racaodovaleDataSet.cadastro_cliente);
            cadastroclienteBindingSource.MoveLast();

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
            FrmPesCliente colab1 = new FrmPesCliente();
            this.Hide();
            colab1.ShowDialog();
        }
    }
}
