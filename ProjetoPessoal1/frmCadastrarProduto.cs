using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPessoal1.Model;
using MySql.Data.MySqlClient;

namespace ProjetoPessoal1 {
    public partial class frmCadastrarProduto : Form {
        public frmCadastrarProduto() {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            try {
                Produto novoProduto = new Produto(0, txtNomeProduto.Text, double.Parse(txtPrecoVenda.Text), txtFornecedor.Text);
                novoProduto.CadastrarProduto();
                MessageBox.Show("Produto Cadastrado com Sucesso!");
                LimparCampos();              
                ListarGrid();             
            }

            catch (Exception erro) {
                MessageBox.Show("Alguns dos dados digitados não estão de acordo com seus tipos.");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                btnCadastrar.Enabled = true;
                Produto oProd = new Produto();
                var cmd = Banco.AbrirBanco();
                cmd.CommandText = "update produto set nomeProduto = '" + txtNomeProduto.Text + "', precoVenda = '" + txtPrecoVenda.Text + "', fornecedor = '" + txtFornecedor.Text + "' where idProduto = '" + txtCodigoProduto.Text + "'";
                cmd.ExecuteNonQuery();
                LimparCampos();
                ListarGrid();
            }
            catch (Exception erro) {
                MessageBox.Show("Alguns dos dados Digitados não estão de acordo com seus tipos.");   
            }                     

        }

        private void frmCadastrarProduto_Load(object sender, EventArgs e) {
            ListarGrid();
        }

        public void ListarGrid() {
            Produto newProduto = new Produto();
            grdProdutos.DataSource = newProduto.ListardoBanco();
        }

        private void grdProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (grdProdutos.Rows[e.RowIndex].DataBoundItem != null) {
                if (grdProdutos.Columns[e.ColumnIndex].Name == "btnAlterarProd") {
                    btnCadastrar.Enabled = false;
                    Produto oProd = (Produto)grdProdutos.Rows[e.RowIndex].DataBoundItem;
                    txtCodigoProduto.Text = oProd.IdProduto.ToString();
                    txtNomeProduto.Text = oProd.NomeProduto;
                    txtPrecoVenda.Text = oProd.PrecoVenda.ToString();
                    txtFornecedor.Text = oProd.Fornecedor;
                }
                else if (grdProdutos.Columns[e.ColumnIndex].Name == "btnExcluir") {

                    if (MessageBox.Show("Tem certeza que deseja excluir permanentemente esse item?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { 
                        try {
                        Produto oProd = (Produto)grdProdutos.Rows[e.RowIndex].DataBoundItem;
                        var cmd = Banco.AbrirBanco();
                        cmd.CommandText = "delete from produto where idProduto = '" + oProd.IdProduto + "'";
                        cmd.ExecuteNonQuery();
                        grdProdutos.DataSource = oProd.ListardoBanco();
                        }
                        catch (Exception erro) {
                             MessageBox.Show("Erro: "+ erro);
                        }
                    }

                }
            }
        }

        public void LimparCampos() {
            txtCodigoProduto.Text = "";
            txtFornecedor.Text = "";
            txtNomeProduto.Text = "";
            txtPrecoVenda.Text = "";
        }

    }
}

