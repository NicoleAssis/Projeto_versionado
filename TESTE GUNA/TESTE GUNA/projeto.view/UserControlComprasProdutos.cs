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
    public partial class UserControlComprasProdutos : UserControl
    {
        public UserControlComprasProdutos()
        {
            InitializeComponent();
        }

        string label;
        private void labelDescricao_Click(object sender, EventArgs e)
        {

        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            int valorAtual = Convert.ToInt32(txtQuantidade.Text);
            // Incrementa o valor
            valorAtual++;
            // Atualiza o valor do TextBox
            txtQuantidade.Text = valorAtual.ToString();

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int valorAtual = Convert.ToInt32(txtQuantidade.Text);
            // Incrementa o valor
            if (valorAtual > 0)
            {
                valorAtual--;
                // Atualiza o valor do TextBox
                txtQuantidade.Text = valorAtual.ToString();
            }
            
        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }
    }
}
