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
    public partial class CONTROLE : Form
    {
        public CONTROLE()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CONTROLE_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.controle_estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.controle_estoqueTableAdapter.Fill(this.racaodovaleDataSet.controle_estoque);
            controleestoqueBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MENU colabG = new MENU();
            this.Hide();
            colabG.ShowDialog();
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
            controleestoqueBindingSource.EndEdit();
            controle_estoqueTableAdapter.Update(racaodovaleDataSet.controle_estoque);
            this.controle_estoqueTableAdapter.Fill(this.racaodovaleDataSet.controle_estoque);
            controleestoqueBindingSource.MoveLast();

            //chamar um novo registro
            controleestoqueBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Controle de Estoque cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPessEstoque colabh = new FrmPessEstoque();
            this.Hide();
            colabh.ShowDialog();
        }
    }
}
