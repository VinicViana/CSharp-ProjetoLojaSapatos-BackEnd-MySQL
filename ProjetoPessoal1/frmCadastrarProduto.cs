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

                Produto novoProduto = new Produto(txtNomeProduto.Text, double.Parse(txtPrecoVenda.Text), txtFornecedor.Text);
                novoProduto.CadastrarProduto();

                txtCodigoProduto.Text = "";
                txtFornecedor.Text = "";
                txtNomeProduto.Text = "";
                txtPrecoVenda.Text = "";

                MessageBox.Show("Produto Cadastrado com Sucesso!");
            }

            catch (Exception erro) {

                MessageBox.Show("Alguns dos dados Digitados não estão de acordo com seus tipos.");
            }




        }


    }
}
