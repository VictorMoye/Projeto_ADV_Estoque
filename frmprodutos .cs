﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADV_35_ESTOQUE
{
    public partial class frmprodutos : Form
    {
        public frmprodutos()
        {
            InitializeComponent();
        }

        private void frmprodutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoque_ADVDataSet.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.estoque_ADVDataSet.Fornecedor);
            // TODO: This line of code loads data into the 'estoque_ADVDataSet.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.estoque_ADVDataSet.Produto);

        }
    }
}
