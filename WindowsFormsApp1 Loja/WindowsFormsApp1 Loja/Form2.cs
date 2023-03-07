using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_Loja
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 logar = new Form4();
            this.Hide();
            logar.ShowDialog();
        }

        private void cadastrarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 logar = new Form3();
            this.Hide();
            logar.ShowDialog();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 logar = new Form4();
            this.Hide();
            logar.ShowDialog();
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 logar = new Form5();
            this.Hide();
            logar.ShowDialog();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 logar = new Form6();
            this.Hide();
            logar.ShowDialog();
        }

        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 logar = new Form7();
            this.Hide();
            logar.ShowDialog();
        }

        private void controleDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 logar = new Form8();
            this.Hide();
            logar.ShowDialog();
        }

        private void pedidosDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 logar = new Form9();
            this.Hide();
            logar.ShowDialog();
        }
    }
}
