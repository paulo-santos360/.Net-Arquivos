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
    public partial class Alterar : Form
    {
        public Alterar()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            colaboradorBindingSource.EndEdit();
            colaboradorTableAdapter.Update(colabDataSet.colaborador);
            this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);
            colaboradorBindingSource.MoveLast();


            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa Alteradada  com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Alterar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.colaborador'. Você pode movê-la ou removê-la conforme necessário.
            this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmPesquisar colab1 = new FrmPesquisar();
            this.Hide();
            colab1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

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
    }
}
