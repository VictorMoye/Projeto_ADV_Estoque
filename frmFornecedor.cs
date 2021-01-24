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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoque_ADVDataSet.Produto' table. You can move, or remove it, as needed.
            // essa linha de codigo carrega dados pra o estoque 'estoque_ADVDataSet.Produto'
            this.produtoTableAdapter.Fill(this.estoque_ADVDataSet.Produto);
            

            // essa linha de codigo careegara dados para o 'estoque_ADVDataSet.Fornecedor'
            // essa linha do codigo carregara dados para o'estoque_ADVDataSet.Fornecedor'
            // por meio do metodo que voc~e criou na atividade anterior 
            fornecedorTableAdapter.Fill(this.estoque_ADVDataSet.Fornecedor);

        }

        private void fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estoque_ADVDataSet);
            fornecedorTableAdapter.Fill(this.estoque_ADVDataSet.Fornecedor);

            // executa o metodo que preenche a tabela com os dados do banco 
            this.produtoTableAdapter.Fill(this.estoque_ADVDataSet.Produto); 
        }

               

    }
}
