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
    public partial class CadCaixa : Form
    {
        public CadCaixa()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            MENU colabC = new MENU();
            this.Hide();
            colabC.ShowDialog();
        }
    }
}
