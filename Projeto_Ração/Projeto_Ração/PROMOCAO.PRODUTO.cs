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
    public partial class PROMOCAO : Form
    {
        public PROMOCAO()
        {
            InitializeComponent();
        }

        private void PROMOCAO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.promocao_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.promocao_produtoTableAdapter.Fill(this.racaodovaleDataSet.promocao_produto);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MENU colabF = new MENU();
            this.Hide();
            colabF.ShowDialog();
        }
    }
}
