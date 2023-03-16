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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colaborador colab = new colaborador();
            this.Hide();
            colab.ShowDialog();

        }

        private void fisicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fisica colabe = new fisica();
            this.Hide();
            colabe.ShowDialog();
        }

        private void juridicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            juridica colabi = new juridica();
            this.Hide();
            colabi.ShowDialog();
        }

        private void parceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parceiro colabu = new parceiro();
            this.Hide();
            colabu.ShowDialog();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pessoa colab8 = new pessoa();
            this.Hide();
            colab8.ShowDialog();
        }
    }
}
