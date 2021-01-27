namespace ProjetoPessoal1 {
    partial class frmCadastrarProduto {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtCodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomeProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFornecedorProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterarProd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Produto";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(121, 27);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.ReadOnly = true;
            this.txtCodigoProduto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProduto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço de Venda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fornecedor";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(121, 62);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(248, 20);
            this.txtNomeProduto.TabIndex = 3;
            this.txtNomeProduto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(121, 98);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(137, 20);
            this.txtPrecoVenda.TabIndex = 5;
            this.txtPrecoVenda.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(121, 129);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(248, 20);
            this.txtFornecedor.TabIndex = 7;
            this.txtFornecedor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(121, 165);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 27);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grdProdutos
            // 
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCodProd,
            this.txtNomeProd,
            this.txtPrecoProd,
            this.txtFornecedorProd,
            this.btnAlterarProd,
            this.btnExcluir});
            this.grdProdutos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdProdutos.Location = new System.Drawing.Point(0, 321);
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.Size = new System.Drawing.Size(645, 257);
            this.grdProdutos.TabIndex = 10;
            this.grdProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProdutos_CellContentClick);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(239, 165);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(112, 27);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCodProd
            // 
            this.txtCodProd.DataPropertyName = "idProduto";
            this.txtCodProd.HeaderText = "Código";
            this.txtCodProd.Name = "txtCodProd";
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.DataPropertyName = "nomeProduto";
            this.txtNomeProd.HeaderText = "Nome";
            this.txtNomeProd.Name = "txtNomeProd";
            // 
            // txtPrecoProd
            // 
            this.txtPrecoProd.DataPropertyName = "precoVenda";
            this.txtPrecoProd.HeaderText = "Preço de Venda";
            this.txtPrecoProd.Name = "txtPrecoProd";
            // 
            // txtFornecedorProd
            // 
            this.txtFornecedorProd.DataPropertyName = "fornecedor";
            this.txtFornecedorProd.HeaderText = "Fornecedor";
            this.txtFornecedorProd.Name = "txtFornecedorProd";
            // 
            // btnAlterarProd
            // 
            this.btnAlterarProd.HeaderText = "Alterar";
            this.btnAlterarProd.Name = "btnAlterarProd";
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "Excluir";
            this.btnExcluir.Name = "btnExcluir";
            // 
            // frmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 578);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.grdProdutos);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCadastrarProduto";
            this.Text = "Cadastrar Novo Produto";
            this.Load += new System.EventHandler(this.frmCadastrarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNomeProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrecoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFornecedorProd;
        private System.Windows.Forms.DataGridViewButtonColumn btnAlterarProd;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluir;
    }
}