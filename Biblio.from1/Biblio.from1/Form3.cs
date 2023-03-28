using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio.from1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'biblioDataSet.autores'. Você pode movê-la ou removê-la conforme necessário.
            this.autoresTableAdapter.Fill(this.biblioDataSet.autores);
            // TODO: esta linha de código carrega dados na tabela 'biblioDataSet.livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.biblioDataSet.livros);
            // TODO: esta linha de código carrega dados na tabela 'biblioDataSet.acervo'. Você pode movê-la ou removê-la conforme necessário.
            this.acervoTableAdapter.Fill(this.biblioDataSet.acervo);
            acervoBindingSource.AddNew();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                this.Validate();
                acervoBindingSource.EndEdit();
                acervoTableAdapter.Update(biblioDataSet.acervo);
                this.acervoTableAdapter.Fill(this.biblioDataSet.acervo);
                acervoBindingSource.MoveLast();

                //chamar um novo registro
                acervoBindingSource.AddNew();

                textBox2.Focus();

                //aparece a mensagem quando der certo
                MessageBox.Show("Acervo cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //limpar tela
                //    textBox1.Text = "";
                //  textbox.Text = (" ");

            }
        }
    }
}
