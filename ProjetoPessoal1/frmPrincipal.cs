﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPessoal1 {
    public partial class frmPrincipal : Form {
        public frmPrincipal() {
            InitializeComponent();
        }

        private void cadastrarNovoProdutoToolStripMenuItem_Click(object sender, EventArgs e) {

            frmCadastrarProduto frmCadastro = new frmCadastrarProduto();
            frmCadastro.Visible = true; 
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close(); 
        }
    }
}
