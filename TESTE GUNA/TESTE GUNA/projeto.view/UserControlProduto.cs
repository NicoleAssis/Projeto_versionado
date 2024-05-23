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
    public partial class UserControlProduto : UserControl
    {
        public UserControlProduto()
        {
            InitializeComponent();
        }

        private string labelProduto;

        public string NomeProduto
        {
            get { return labelProduto; }
            set { labelProduto = value; labelNome.Text = value; }
        }


        private void UserControlProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
