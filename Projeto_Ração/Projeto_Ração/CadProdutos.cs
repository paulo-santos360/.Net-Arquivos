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
    public partial class BUTTON1 : Form
    {
        public BUTTON1()
        {
            InitializeComponent();
        }

        private void CadProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cadastro_produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_produtosTableAdapter.Fill(this.racaodovaleDataSet.cadastro_produtos);

        }
    }
}
