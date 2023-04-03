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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void cadastroDeFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadFornecedor colaba = new FrmCadFornecedor();
            this.Hide();
            colaba.ShowDialog();
        }

        private void controleDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void cadastroDeFunciorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadCliente colabB = new CadCliente();
            this.Hide();
            colabB.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PROMOCAO colabD = new PROMOCAO();
            this.Hide();
            colabD.ShowDialog();

        }

        private void contrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONTROLE colabE = new CONTROLE();
            this.Hide();
            colabE.ShowDialog();
        }

        private void promoçãoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PROMOCAO colabD = new PROMOCAO();
            this.Hide();
            colabD.ShowDialog();
        }

        private void cadProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            produto colabE = new produto();
            this.Hide();
            colabE.ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadFunc colaba = new CadFunc();
            this.Hide();
            colaba.ShowDialog();
        }

        private void cadClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadCliente colabB = new CadCliente();
            this.Hide();
            colabB.ShowDialog();
        }

        private void cadFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadFornecedor colaba = new FrmCadFornecedor();
            this.Hide();
            colaba.ShowDialog();
        }

        private void controleDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONTAS colabE = new CONTAS();
            this.Hide();
            colabE.ShowDialog();
        }

        private void cadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            produto colabE = new produto();
            this.Hide();
            colabE.ShowDialog();
        }

        private void cONTROLEDEESTOQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONTROLE colabE = new CONTROLE();
            this.Hide();
            colabE.ShowDialog();
        }

        private void cONTROLEDECAIXAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadCaixa colaba = new CadCaixa();
            this.Hide();
            colaba.ShowDialog();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }
    }
}
