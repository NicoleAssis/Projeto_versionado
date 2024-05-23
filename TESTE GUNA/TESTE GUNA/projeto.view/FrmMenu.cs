using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace TESTE_GUNA.projeto.view
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            Environment.Exit(0);
        }


        private void btnDepartamentos_Click_1(object sender, EventArgs e)
        {
            //abrir a tela de cadastro
            FrmDepartamentos telaDepartamentos = new FrmDepartamentos();
            //esconde a tela anterior
            this.Hide();
            //tela abre no centro
            //telaDepartamentos.StartPosition = FormStartPosition.CenterScreen;
            telaDepartamentos.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FrmCompras telaCompras = new FrmCompras();
            //esconde a tela anterior
            this.Hide();
            telaCompras.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil telaPerfil = new FrmPerfil();
            //esconde tela anterior
            this.Hide();
            telaPerfil.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            scrollProdutos.AutoScrollPosition = new System.Drawing.Point(0, e.NewValue);
        }
    }
}
