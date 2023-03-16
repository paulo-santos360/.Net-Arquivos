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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.colabDataSet.pessoa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Entre com os dados");
            }
            else
            {
                pessoaBindingSource.Filter = "pess_Login='" + textBox1.Text + "'";

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
                Menu newmenu = new Menu();
                newmenu.ShowDialog();
            }
        }
    }
}
