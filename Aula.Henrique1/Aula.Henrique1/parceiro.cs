using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula.Henrique1
{
    public partial class parceiro : Form
    {
        public parceiro()
        {
            InitializeComponent();
        }

        private void parceiro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.parceiro'. Você pode movê-la ou removê-la conforme necessário.
            this.parceiroTableAdapter.Fill(this.colabDataSet.parceiro);

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
            parceiroBindingSource.EndEdit();
            parceiroTableAdapter.Update(colabDataSet.parceiro);
            this.parceiroTableAdapter.Fill(this.colabDataSet.parceiro);
            parceiroBindingSource.MoveLast();

            //chamar um novo registro
            parceiroBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa parceiro cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu colab = new Menu();
            this.Hide();
            colab.ShowDialog();
        }
    }
}
