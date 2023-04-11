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
    public partial class caixasoma : Form
    {
        public caixasoma()
        {
            InitializeComponent();
        }

        private void caixasoma_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'racaodovaleDataSet.cadastro_produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_produtosTableAdapter.Fill(this.racaodovaleDataSet.cadastro_produtos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pesquisa = textBox1.Text;
            foreach (DataGridViewRow row in
                dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value.ToString().Contains(pesquisa))
                {
                    Produtos.Items.Add(row.Cells[1].Value.ToString()
                        + " | " +
                        row.Cells[2].Value.ToString()
                        + " | R$ " +
                        row.Cells[5].Value.ToString()
                        );

                    listBox1.Items.Add(row.Cells[5].Value.ToString());
                    double valorTotal = 0;

                    //listBox2.Items.Add(row.Cells[0].Value.ToString());

                    foreach (string v in listBox1.Items)
                    {
                        double dv = Double.Parse(v);
                        valorTotal += dv;
                    }
                    textBox2.Text = "Valor total: " + valorTotal.ToString();

                    break;

                }


            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                cadastroprodutosBindingSource.Filter = string.Format("produtos_cd={0}", textBox1.Text);
            }
            else
            {
                //cadastroprodutosBindingSource.Filter = "";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MENU colaba = new MENU();
            this.Hide();
            colaba.ShowDialog();
        }
    }
}
