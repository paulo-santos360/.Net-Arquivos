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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Entre com os dados");
            }
            else
            {
                cadfuncionarioBindingSource.Filter = "cad_CD='" + textBox1.Text + "'";

                if (textBox1.Text.ToUpper() != textBox3.Text.ToUpper())
                {
                    MessageBox.Show("USUARIO ERRADO");
                    return;
                }
                if (textBox2.Text.ToUpper() != textBox4.Text.ToUpper())
                {
                    MessageBox.Show("SENHA ERRADA");
                    return;
                }
                this.Visible = false;
                MENU newmenu = new MENU();
                newmenu.ShowDialog();
            }

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cad_funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_funcionarioTableAdapter.Fill(this.racaodovaleDataSet.cad_funcionario);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
