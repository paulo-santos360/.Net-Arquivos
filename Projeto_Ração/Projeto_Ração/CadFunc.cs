﻿using System;
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

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MENU colab5 = new MENU();
            this.Hide();
            colab5.ShowDialog();
        }
    }
}
