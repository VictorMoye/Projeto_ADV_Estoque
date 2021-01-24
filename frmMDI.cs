using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;  
namespace ADV_35_ESTOQUE
{
    public partial class formMDI : Form
    {
        public formMDI()
        {
            InitializeComponent();
        }

        private void mnuCadFornecedor_Click(object sender, EventArgs e)
        {
            // cria uma intancia no form (frmFornecedor )
            frmFornecedor frFornecedor = new frmFornecedor();

            // define que a instancia é parente do frmMDI
            frFornecedor.MdiParent = this;

            // exibe o formulario 
            frFornecedor.Show();
        }

        private void mnuCadProduto_Click(object sender, EventArgs e)
        {
            // cria uma nova instancia do form (frmProduto)
            frmprodutos frProduto = new frmprodutos();
            
            // define que a instancia e parente do frmMDI
            frProduto.MdiParent = this; 

            // exibe o formulario 
            frProduto.Show();
        }

        private void mnuConsFornecedores_Click(object sender, EventArgs e)
        {
            // cria uma intancia no form (frmFornecedor )
            frmConsFornecedor frFornecedor = new frmConsFornecedor();

            // define que a instancia é parente do frmMDI
            frFornecedor.MdiParent = this;

            // exibe o formulario 
            frFornecedor.Show();
        }

        private void manuConsProdutos_Click(object sender, EventArgs e)
        {
            // cria uma intancia no form (frmProduto )
            frmConsProduto frmProdutos = new frmConsProduto();

            // define que a instancia é parente do frmMDI
            frmProdutos.MdiParent = this;

            // exibe o formulario 
            frmProdutos.Show();
        }

        
    }
}
