using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTE_GUNA.projeto.view
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //abrir a tela de login
            FrmLogin telaLogin = new FrmLogin();
            //esconde a tela anterior
            this.Hide();
            //tela abre no centro
            telaLogin.StartPosition = FormStartPosition.CenterScreen;
            telaLogin.Show();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            Environment.Exit(0);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmMenu telaMenu = new FrmMenu();
            this.Hide();
            telaMenu.Show();
        }

        private void guna2TextBox2_Click(object sender, EventArgs e)
        {
            //aparece o masked box em cima desse text box p coletar os dados do CPF corretamente
            txtCPF.Visible= true;
            guna2TextBox2.Enabled= false;
        }
    }
}
