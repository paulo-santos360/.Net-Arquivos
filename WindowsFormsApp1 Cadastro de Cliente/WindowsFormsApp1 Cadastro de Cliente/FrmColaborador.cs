using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_Cadastro_de_Cliente
{
    public partial class FrmColaborador : Form
    {
        public FrmColaborador()
        {
            InitializeComponent();
        }

        private void FrmColaborador_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.colaborador'. Você pode movê-la ou removê-la conforme necessário.
            //this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.colaborador'. Você pode movê-la ou removê-la conforme necessário.
            //this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.colaborador'. Você pode movê-la ou removê-la conforme necessário.
            //this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.colaborador'. Você pode movê-la ou removê-la conforme necessário.
            //this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.colaborador'. Você pode movê-la ou removê-la conforme necessário.
            this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);
            colaboradorBindingSource.AddNew();
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
                colaboradorBindingSource.EndEdit();
                colaboradorTableAdapter.Update(colabDataSet.colaborador);
                this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);
                colaboradorBindingSource.MoveLast();

                //chamar um novo registro
                colaboradorBindingSource.AddNew();

                textBox2.Focus();

                //aparece a mensagem quando der certo
                MessageBox.Show("colaborador cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        private void button3_Click(object sender, EventArgs e)
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
