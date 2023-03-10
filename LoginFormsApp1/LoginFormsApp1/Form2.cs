using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cadastroDePToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 newform3 = new Form3();
            newform3.ShowDialog();
        }
    }
}
