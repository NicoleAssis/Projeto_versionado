﻿using System;
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
    public partial class FrmDepartamentoEscolhido : Form
    {
        public FrmDepartamentoEscolhido()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //fechar o programa
            this.Close();
            FrmDepartamentos telaDep = new FrmDepartamentos();
            telaDep.ShowDialog();
        }

        public void NomeDepartamento(string departamento)
        {
            lblDepartamento.Text = departamento;
        }
        

        private void FrmDepartamentoEscolhido_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
