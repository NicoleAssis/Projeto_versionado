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
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //fechar o programa
            Environment.Exit(0);
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

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil telaPerfil = new FrmPerfil();
            this.Hide();
            telaPerfil.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCalcularFrete_Click(object sender, EventArgs e)
        {
            FrmFrete telaFrete = new FrmFrete();
            telaFrete.ShowDialog();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            FrmPagamento telaPag = new FrmPagamento();
            telaPag.ShowDialog();
        }
    }
}
