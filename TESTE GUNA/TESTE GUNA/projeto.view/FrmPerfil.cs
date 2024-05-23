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
    public partial class FrmPerfil : Form
    {
        public FrmPerfil()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMenu telaMenu = new FrmMenu();
            this.Hide();
            telaMenu.Show();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            FrmDepartamentos telaDepartamentos = new FrmDepartamentos();
            this.Hide();
            telaDepartamentos.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FrmCompras telaCompras = new FrmCompras();
            this.Hide();
            telaCompras.Show();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            Environment.Exit(0);
        }

        private void lblDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            FrmPerfilAlterarSenha telaAlterarSenha = new FrmPerfilAlterarSenha();
            telaAlterarSenha.ShowDialog();
        }
    }
}
