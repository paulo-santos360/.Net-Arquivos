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
    public partial class CONTAS : Form
    {
        public CONTAS()
        {
            InitializeComponent();
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
            contasBindingSource.EndEdit();
            contasTableAdapter.Update(racaodovaleDataSet.contas);
            this.contasTableAdapter.Fill(this.racaodovaleDataSet.contas);
            contasBindingSource.MoveLast();

            //chamar um novo registro
            contasBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Contas cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void CONTAS_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.contas'. Você pode movê-la ou removê-la conforme necessário.
            this.contasTableAdapter.Fill(this.racaodovaleDataSet.contas);
            contasBindingSource.AddNew();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MENU colab5 = new MENU();
            this.Hide();
            colab5.ShowDialog();
        }
    }
}
