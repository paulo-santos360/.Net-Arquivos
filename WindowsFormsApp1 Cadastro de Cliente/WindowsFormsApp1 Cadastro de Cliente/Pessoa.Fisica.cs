using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_Cadastro_de_Cliente
{
    public partial class Pessoa : Form
    {
        public Pessoa()
        {
            InitializeComponent();
        }

        private void Pessoa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.fisica'. Você pode movê-la ou removê-la conforme necessário.
            this.fisicaTableAdapter.Fill(this.colabDataSet.fisica);
            fisicaBindingSource.AddNew();

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
            {
                this.Validate();
                fisicaBindingSource.EndEdit();
                fisicaTableAdapter.Update(colabDataSet.fisica);
                this.fisicaTableAdapter.Fill(this.colabDataSet.fisica);
                fisicaBindingSource.MoveLast();

                //chamar um novo registro
                fisicaBindingSource.AddNew();

                textBox2.Focus();

                //aparece a mensagem quando der certo
                MessageBox.Show("Pessoa fisica cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //limpar tela
                //    textBox1.Text = "";
                //  textbox.Text = (" ");



            }
        }
    }
}
