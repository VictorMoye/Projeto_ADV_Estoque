using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace ADV_35_ESTOQUE.Classes
{
    // nao permite que seja criadas novas instancias apenas ser herdadas 
    class Access
    {

        private OleDbConnection conn;
        // atributos privados 
        protected string strConn;
        protected OleDbCommand cmd;
        protected OleDbDataAdapter adp;
        protected OleDbDataReader reader;
        protected DataTable tb;
        protected DataSet ds;
        protected System.Windows.Forms.BindingSource Binding; 

        // contrutores padrão 
        public Access() 
        {
            // inicia a string de conexão padrão (atençõ : mude o caminho do 
            // banco de dados para a pasta 'BIN' do seu projeto )

            this.strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;DataSource=Z:\C# 2010\Victor Hugo M. da Silva_11522\ADV-35_ESTOQUE\bin\Debug\EstoqueADV.accdb"; 

            // cria um novo objeto OleDdConnection 
            this.conn = new OleDbConnection(this.strConn); 
        }
        // customizado 
        protected Access(string srtConn)
        {
            this.strConn = strConn; 

            // cria um novo objeto OleDdConnetion 
            this.conn = new OleDbConnection(this.strConn);  
        }
        // propriedades 
        protected OleDbConnection ConexaoAtiva
        {
            get
            {
                if (this.conn.State == ConnectionState.Closed)
                    this.conn.Open();

                if (this.conn.State == ConnectionState.Closed)
                    throw new Exception("não foi possivel abrir a conexão"); 

                return this.conn;
            }
        }
    }
}
