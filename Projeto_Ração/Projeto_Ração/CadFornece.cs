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
    public partial class FrmCadFornecedor : Form
    {
        public FrmCadFornecedor()
        {
            InitializeComponent();
        }

        private void FrmCadFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cadast_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.cadast_fornecedorTableAdapter.Fill(this.racaodovaleDataSet.cadast_fornecedor);

        }
    }
}
