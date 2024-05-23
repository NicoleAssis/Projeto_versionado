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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //buton fechar o programa (X)
            Environment.Exit(0);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //abrir a tela de cadastro
            FrmCadastro telaCadastro = new FrmCadastro();
            //esconde a tela anterior
            this.Hide();
            //tela abre no centro
            telaCadastro.StartPosition = FormStartPosition.CenterScreen;
            telaCadastro.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FrmMenu telaMenu = new FrmMenu();
            this.Hide();
            telaMenu.Show();
        }
    }
}
