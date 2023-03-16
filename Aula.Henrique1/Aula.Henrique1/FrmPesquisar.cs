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
    public partial class FrmPesquisar : Form
    {
        public FrmPesquisar()
        {
            InitializeComponent();
        }

        private void FrmPesquisar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.colaborador'. Você pode movê-la ou removê-la conforme necessário.
            this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colaboradorBindingSource.Filter = string.Format("col_CD={0}", textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                colaboradorBindingSource.Filter = "";
            }
            else
            {
                colaboradorBindingSource.Filter = string.Format("col_ctps like'%{0}%'", textBox2.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
