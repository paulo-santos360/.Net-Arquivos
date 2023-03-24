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
    public partial class FrmAltCaixa : Form
    {
        public FrmAltCaixa()
        {
            InitializeComponent();
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

        private void button5_Click(object sender, EventArgs e)
        {
            FrmPesCaixa colab1 = new FrmPesCaixa();
            this.Hide();
            colab1.ShowDialog();
        }

        private void FrmAltCaixa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.controle_caixa'. Você pode movê-la ou removê-la conforme necessário.
            this.controle_caixaTableAdapter.Fill(this.racaodovaleDataSet.controle_caixa);
            if (Class1.codigo == "")//
            { controlecaixaBindingSource.AddNew(); }//
            else//
            { controlecaixaBindingSource.Filter = string.Format("controle_cd={0}", Class1.codigo); }// textBox1.Text); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            controlecaixaBindingSource.EndEdit();
            controle_caixaTableAdapter.Update(racaodovaleDataSet.controle_caixa);
            this.controle_caixaTableAdapter.Fill(this.racaodovaleDataSet.controle_caixa);
            controlecaixaBindingSource.MoveLast();


            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa Alteradada  com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }
    }
}
