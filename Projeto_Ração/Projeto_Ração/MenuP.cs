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
    public partial class MenuP : Form
    {
        private Button btnAtual;
        private Form formAtual;
        public MenuP()
        {
            InitializeComponent();
        }

        private void MenuP_Load(object sender, EventArgs e)
        {
        
        }
        private void AbrirForm(Form formSel, Object btnSender)
        {
            if (formAtual != null)
            {
                formAtual.Close();
            }
            AtivarBtn(btnSender);
            formAtual = formSel;
            formSel.TopLevel = false; //nivel de controle
            formSel.FormBorderStyle = FormBorderStyle.None;//caixa de controle desativada
            formSel.Dock = DockStyle.Fill; // Posicionamento
            this.panelContainer.Controls.Add(formSel); //adicionar o form ao painel
            this.panelContainer.Tag = formSel;
            formSel.BringToFront();//Traz o controle para frente na ordem Z
            formSel.Show();// Chama o Form
            label1.Text = formSel.Text;

        }

        private void Resetar()
        {
            DesativarBtn();
            label1.Text = "HOME";
            btnHome.Visible = false;
        }


        private void AtivarBtn(Object btnSender)
        {
            if (btnSender != null)
            {
                if (btnAtual != (Button)btnSender)
                {
                    btnHome.Visible = true;
                    DesativarBtn();
                    btnAtual = (Button)btnSender;
                    btnAtual.BackColor = Color.FromArgb(31, 80, 31);
                    btnAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DesativarBtn()
        {
            foreach (Control antBtn in panelMenu.Controls)
            {
                if (antBtn.GetType() == typeof(Button))
                {
                    antBtn.BackColor = Color.FromArgb(51, 51, 76);
                    antBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForm(new CadCaixa(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new CadCliente(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm(new CadFunc(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirForm(new produto(), sender);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new CadCaixa(), sender);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new FrmCadFornecedor(), sender);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new CadCliente(), sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(formAtual != null)
            {
                formAtual.Close();
                Resetar();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirForm(new CONTROLE(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirForm(new CONTAS(), sender);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new produto(), sender);
        }
    }

}

