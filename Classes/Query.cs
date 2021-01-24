using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_35_ESTOQUE.Classes
{
    class Query:Access
    {
        ///<summary>
        // construtor padrão 
        // utiliza a sting padrão para se conectar 
        ///</summary>
        public Query(): base() // constutor da classe Acesses 
        { }

        ///<summary>
        ///contrutor custumizado 
        ///string co mos parametros de conexão
        ///</summary>
        public Query(string strConn) : base(strConn)
        { }

        // metodos 
        ///<summary>
        /*busca os fornecedores dado a string inicial da razão social 
         ex.: nest busca todos os forncededores que a razão social inicie com nest */
        ///</summary>
        ///<param name="rSocial">Razão Social</param>
        ///<param name="ds">DataSet que contem na tabela</param>

        public void BuscaFornecedores(string rSocial, Estoque_ADVDataSet ds)
        {
            string sql = "SELECT F.id, F.razaoSocial, F.nomeFantasia, F.email, F.contato, F.dataCadastro,F.ddd, F.telefone1 , F.telefome2, FROM Fornecedor F WHERE F.razaoSocial LIKE @rSOcial + '%'";

            this.cmd = new System.Data.OleDb.OleDbCommand(sql, this.ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.Text;

            this.cmd.Parameters.AddWithValue("@rSocial", rSocial);

            this.adp = new System.Data.OleDb.OleDbDataAdapter(this.cmd);

            ds.Fornecedor.Clear();
            this.adp.Fill(ds.Fornecedor);
        }
        ///<summary>
        ///metodo que cria : tabela, dataset, e satabing 
        ///em seguida cola a estrutura criada no grid recebido como parametro 
        ///</summary>
        ///<param name="dgv">d=DataSet que recebera o schema</param>
        public void CriaTabelaDataSetAndDataBinding(System.Windows.Forms.DataGridView dgv)
        {
            // cria uma tabela 
            this.tb = new System.Data.DataTable("Produto");

            // adicionar colunas 
            this.tb.Columns.Add("id",typeof(Int32));
            this.tb.Columns.Add("descricao",typeof(string));
            this.tb.Columns.Add("qtdeminima",typeof(Int32));
            this.tb.Columns.Add("valorUnitario",typeof(decimal));
            this.tb.Columns.Add("nomeDoFornecedor",typeof(string));
            this.tb.Columns.Add("contato",typeof(string));
            this.tb.Columns.Add("ddd",typeof(Int32));
            this.tb.Columns.Add("telefone1",typeof(Int32));
            this.tb.Columns.Add("telefone2",typeof(UInt32)).Caption = "telefone 2";
            this.tb.Columns.Add("");

            // cria uma nova instancia do DataSet
            this.ds = new System.Data.DataSet("dsEstoque");

            // adiciona a tabela no dataset 
            this.ds.Tables.Add(this.tb);

            // cria uma instancia no BindingSource
            this.Binding = new System.Windows.Forms.BindingSource(this.ds, "produto");

            // vincula a tabela do BVinding com o DataGridView 
            dgv.DataSource = this.Binding; 

            // configura o cabeçalho das colunas 
 
            // coluna id 
            dgv.Columns["id"].HeaderText = "Código";
            dgv.Columns["id"].Width = 50; 

            // coluna qtdeMinima 
            dgv.Columns["qtdeMinima"].HeaderText = "Qtde Minima";
            dgv.Columns["qtdeMinima"].Width = 60; 

            // coluna descrição 
            dgv.Columns["descricao"].HeaderText = "Descrção";
            dgv.Columns["descricao"].Width = 150; 

            // colona do valor unitario 
            dgv.Columns["valorUnitario"].HeaderText = "Valor Unitario";
            dgv.Columns["valorUnitario"].Width = 80; 

            // coluna nome do fornecedor 
            dgv.Columns["nomeDoFornecedor"].HeaderText = "nome do fornecedor";
            dgv.Columns["nomeDoFornecedor"].Width = 150; 

            // coluna contato 
            dgv.Columns["contato"].HeaderText = "Contato";
            dgv.Columns["id"].Width = 100;

            // coluna ddd
            dgv.Columns["ddd"].HeaderText = "DDD";
            dgv.Columns["ddd"].Width = 60;

            // coluna telefone1
            dgv.Columns["telefone1"].HeaderText = "Telefone 1";
            dgv.Columns["telefone1"].Width = 60;

            // coluna 
            dgv.Columns["telefone2"].HeaderText = "telefone 2";
            dgv.Columns["telefone2"].Width = 60;
        }
        public void ListaProdutosPorDescricao(string descricao)
        {
            // limpa as linhas existentes na tabela 'produto' 
            this.ds.Tables["Produto"].Rows.Clear(); 

            // cria umanova instancia do OLEDDCOMMAND, passando como parametro o 
            // nome do stored prodecure
            this.cmd = new System.Data.OleDb.OleDbCommand("sp_listaProdutosPorDescricao", this.ConexaoAtiva);

            // define que tipo de comando é stored produre 
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure; 

            // passa o parametro necessario para a execução 
            this.cmd.Parameters.AddWithValue("@descricao", descricao); 

            // usando DataReader para lêr linha a linha da tabela retornada 
            this.reader = this.cmd.ExecuteReader();

            // verifica se ha linhas no reader 
            if (this.reader.HasRows)
            {
                // faz um loop pegando linha a alinha da atbela do banco e adicionado 
                // para a tabela do dataset 
                while(this.reader.Read())
                {
                    // cria uma datarow do tipo da tabela 'produto' 
                    System.Data.DataRow row = this.ds.Tables["Produto"].NewRow();
                    row["id"] = this.reader.GetInt32(0);
                    row["descricao"] = this.reader.GetString(1);
                    row["qtdeMinima"] = this.reader.GetInt32(2);
                    row["valorUnitario"] = this.reader.GetDecimal(3);
                    row["nomeDoFornecedor"] = this.reader.GetString(4);
                    row["contato"] = this.reader.GetString(5);
                    row["ddd"] = this.reader.GetInt32(6);
                    row["telefone1"] = this.reader.GetInt32(7);
                    row["telefone2"] = this.reader.GetInt32(8);

                    // adiciona a linha preenchida na tabela produto do dataset 
                    this.ds.Tables["Produto"].Rows.Add(row);
                }
                // libera o reader para ser usado em outras querys 
                this.reader.Close();
            }
        }
    }
}
