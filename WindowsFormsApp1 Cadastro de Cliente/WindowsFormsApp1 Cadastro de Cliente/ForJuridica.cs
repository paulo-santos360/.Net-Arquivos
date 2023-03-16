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
    public partial class ForJuridica : Form
    {
        public ForJuridica()
        {
            InitializeComponent();
        }

        private void ForJuridica_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.juridica'. Você pode movê-la ou removê-la conforme necessário.
            this.juridicaTableAdapter.Fill(this.colabDataSet.juridica);

        }

        private void button4_Click(object sender, EventArgs e)
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
