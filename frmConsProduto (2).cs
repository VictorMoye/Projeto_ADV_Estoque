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
    public partial class frmConsProduto : Form
    {
        public frmConsProduto()
        {
            InitializeComponent();
        }

        // cria uma nova instancia da classe query 
        private Query q = new Query(); 
        private void frmConsProduto_Load(object sender, EventArgs e)
        {
            // executa o metodo que cria e adiciona a tabela produto no DataGridView 
            this.q.CriaTabelaDataSetAndDataBinding(this.dvgProdutos); 
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                this.q.ListaProdutosPorDescricao(txtDescricao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO"); 
            }
        }
    }
}
