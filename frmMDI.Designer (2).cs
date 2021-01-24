namespace ADV_35_ESTOQUE
{
    partial class formMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label razaoSocialLabel;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsutas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.manuConsProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tableAdapterManager = new ADV_35_ESTOQUE.Estoque_ADVDataSetTableAdapters.TableAdapterManager();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoque_ADVDataSet = new ADV_35_ESTOQUE.Estoque_ADVDataSet();
            razaoSocialLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoque_ADVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // razaoSocialLabel
            // 
            razaoSocialLabel.AutoSize = true;
            razaoSocialLabel.Location = new System.Drawing.Point(12, 68);
            razaoSocialLabel.Name = "razaoSocialLabel";
            razaoSocialLabel.Size = new System.Drawing.Size(0, 13);
            razaoSocialLabel.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.mnuConsutas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadFornecedor,
            this.mnuCadProduto,
            this.mnuSair});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(59, 20);
            this.mnuArquivo.Text = "Arquivo ";
            // 
            // mnuCadFornecedor
            // 
            this.mnuCadFornecedor.Name = "mnuCadFornecedor";
            this.mnuCadFornecedor.Size = new System.Drawing.Size(143, 22);
            this.mnuCadFornecedor.Text = "&Fornecedor ";
            this.mnuCadFornecedor.Click += new System.EventHandler(this.mnuCadFornecedor_Click);
            // 
            // mnuCadProduto
            // 
            this.mnuCadProduto.Name = "mnuCadProduto";
            this.mnuCadProduto.Size = new System.Drawing.Size(143, 22);
            this.mnuCadProduto.Text = "Produto ";
            this.mnuCadProduto.Click += new System.EventHandler(this.mnuCadProduto_Click);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(143, 22);
            this.mnuSair.Text = "&Sair";
            // 
            // mnuConsutas
            // 
            this.mnuConsutas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConsFornecedores,
            this.manuConsProdutos});
            this.mnuConsutas.Name = "mnuConsutas";
            this.mnuConsutas.Size = new System.Drawing.Size(69, 20);
            this.mnuConsutas.Text = "Consultas ";
            // 
            // mnuConsFornecedores
            // 
            this.mnuConsFornecedores.Name = "mnuConsFornecedores";
            this.mnuConsFornecedores.Size = new System.Drawing.Size(152, 22);
            this.mnuConsFornecedores.Text = "Fornecedores";
            this.mnuConsFornecedores.Click += new System.EventHandler(this.mnuConsFornecedores_Click);
            // 
            // manuConsProdutos
            // 
            this.manuConsProdutos.Name = "manuConsProdutos";
            this.manuConsProdutos.Size = new System.Drawing.Size(152, 22);
            this.manuConsProdutos.Text = "Produtos ";
            this.manuConsProdutos.Click += new System.EventHandler(this.manuConsProdutos_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ADV_35_ESTOQUE.Estoque_ADVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.estoque_ADVDataSet;
            // 
            // estoque_ADVDataSet
            // 
            this.estoque_ADVDataSet.DataSetName = "Estoque_ADVDataSet";
            this.estoque_ADVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formMDI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(954, 493);
            this.Controls.Add(razaoSocialLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMDI";
            this.Text = "Estoque ADV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoque_ADVDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem mnuCadFornecedor;
        private System.Windows.Forms.ToolStripMenuItem mnuCadProduto;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuConsutas;
        private System.Windows.Forms.ToolStripMenuItem mnuConsFornecedores;
        private System.Windows.Forms.ToolStripMenuItem manuConsProdutos;
        private Estoque_ADVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private Estoque_ADVDataSet estoque_ADVDataSet;
    }
}

