using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ADV_35_ESTOQUE.Classes;

namespace ADV_35_ESTOQUE
{
    public partial class frmConsFornecedor : Form
    {
        public frmConsFornecedor()
        {
            InitializeComponent();
        }

        private void frmConsFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoque_ADVDataSet.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.estoque_ADVDataSet.Fornecedor);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                // cria uma nova instancia da classe query 
                Query q = new Query();
                q.BuscaFornecedores(txtRsocial.Text, estoque_ADVDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO"); 
            }
        }
    }
}
