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
    public partial class CadFunc : Form
    {
        public CadFunc()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CadFunc_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cad_funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_funcionarioTableAdapter.Fill(this.racaodovaleDataSet.cad_funcionario);
            cadfuncionarioBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MENU colab5 = new MENU();
            this.Hide();
            colab5.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            cadfuncionarioBindingSource.EndEdit();
            cad_funcionarioTableAdapter.Update(racaodovaleDataSet.cad_funcionario);
            this.cad_funcionarioTableAdapter.Fill(this.racaodovaleDataSet.cad_funcionario);
            cadfuncionarioBindingSource.MoveLast();

            //chamar um novo registro
            cadfuncionarioBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Funcionario cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPesFunc colabh = new FrmPesFunc();
            this.Hide();
            colabh.ShowDialog();
        }
    }
}
