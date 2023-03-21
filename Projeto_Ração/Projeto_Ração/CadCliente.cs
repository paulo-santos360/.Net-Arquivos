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
    public partial class CadCliente : Form
    {
        public CadCliente()
        {
            InitializeComponent();
        }

        private void CadCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cadastro_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_clienteTableAdapter.Fill(this.racaodovaleDataSet.cadastro_cliente);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MENU colab3 = new MENU();
            this.Hide();
            colab3.ShowDialog();
        }
    }
}
