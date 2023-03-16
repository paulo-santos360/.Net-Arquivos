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
    public partial class juridica : Form
    {
        public juridica()
        {
            InitializeComponent();
        }

        private void juridica_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.juridica'. Você pode movê-la ou removê-la conforme necessário.
            this.juridicaTableAdapter.Fill(this.colabDataSet.juridica);

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

        private void button6_Click(object sender, EventArgs e)
        {
            colaborador colab = new colaborador();
            this.Hide();
            colab.ShowDialog();
        }
    }
}
