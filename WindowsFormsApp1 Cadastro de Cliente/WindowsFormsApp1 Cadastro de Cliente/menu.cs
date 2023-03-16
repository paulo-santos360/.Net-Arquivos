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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmColaborador colab = new FrmColaborador();
            this.Hide();
            colab.ShowDialog();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastro_pessoa pessoa = new cadastro_pessoa();
            this.Hide();
            pessoa.ShowDialog();
        }
    }
}
