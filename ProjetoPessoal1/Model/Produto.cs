using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoPessoal1.Model {
    class Produto {

        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public double PrecoVenda { get; set; }
        public string Fornecedor { get; set; }

        string UrlCon = @"server=127.0.0.1;user id=root;persistsecurityinfo=True;database=projetolojabd";

        public Produto(int idProduto = 0, string nomeProduto = "", double precoVenda = 0, string fornecedor = "") {
            IdProduto = idProduto;
            NomeProduto = nomeProduto;
            PrecoVenda = precoVenda;
            Fornecedor = fornecedor;
        }

        public Produto(){}
        public void CadastrarProduto() {


            try {

                
                MySqlConnection conexao = new MySqlConnection(UrlCon);
                conexao.Open();

                MySqlCommand comandoInserir = new MySqlCommand();
                comandoInserir.Connection = conexao;

                comandoInserir.CommandText = "insert into produto values (0,'" + NomeProduto + "', '" + PrecoVenda + "', '" + Fornecedor + "')";
                comandoInserir.ExecuteNonQuery();
                comandoInserir.Connection.Close();

                
            }

            catch (Exception erro) {

                MessageBox.Show("Problema Indentificado: " + erro);                 
            }

            
        }

        public List<Produto> ListardoBanco() {
            List<Produto> oList = new List<Produto>();
            MySqlCommand cmd = Banco.AbrirBanco();
            cmd.CommandText = "select * from produto";
            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read()) {
                oList.Add(new Produto(
                        dataReader.GetInt32(0),
                        dataReader.GetString(1),
                        dataReader.GetDouble(2),
                        dataReader.GetString(3)
                    ));
            }

            return oList;
        }



    }
}
