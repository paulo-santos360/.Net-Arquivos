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
    public partial class CONTROLE : Form
    {
        public CONTROLE()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CONTROLE_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.controle_estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.controle_estoqueTableAdapter.Fill(this.racaodovaleDataSet.controle_estoque);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MENU colabG = new MENU();
            this.Hide();
            colabG.ShowDialog();
        }
    }
}
