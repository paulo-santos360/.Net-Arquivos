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
    public partial class ForAltFunc : Form
    {
        public ForAltFunc()
        {
            InitializeComponent();
        }

        private void ForAltFunc_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cad_funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_funcionarioTableAdapter.Fill(this.racaodovaleDataSet.cad_funcionario);
            if (Class1.codigo == "")//
            { cadfuncionarioBindingSource.AddNew(); }//
            else//
            { cadfuncionarioBindingSource.Filter = string.Format("cad_CD={0}", Class1.codigo); }// textBox1.Text); }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmPesFunc colab1 = new FrmPesFunc();
            this.Hide();
            colab1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            cadfuncionarioBindingSource.EndEdit();
            cad_funcionarioTableAdapter.Update(racaodovaleDataSet.cad_funcionario);
            this.cad_funcionarioTableAdapter.Fill(this.racaodovaleDataSet.cad_funcionario);
            cadfuncionarioBindingSource.MoveLast();


            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa Alteradada  com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
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
    }
}
