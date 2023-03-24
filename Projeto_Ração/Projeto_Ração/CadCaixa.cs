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

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    TextBox textBox = (TextBox)controle;
                    textBox.Text = string.Empty;
                }
            }
        }

        private void CadCaixa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.controle_caixa'. Você pode movê-la ou removê-la conforme necessário.
            this.controle_caixaTableAdapter.Fill(this.racaodovaleDataSet.controle_caixa);
            controlecaixaBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            controlecaixaBindingSource.EndEdit();
            controle_caixaTableAdapter.Update(racaodovaleDataSet.controle_caixa);
            this.controle_caixaTableAdapter.Fill(this.racaodovaleDataSet.controle_caixa);
            controlecaixaBindingSource.MoveLast();

            //chamar um novo registro
            controlecaixaBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Caixa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPesCaixa colabh = new FrmPesCaixa();
            this.Hide();
            colabh.ShowDialog();
        }
    }
}
