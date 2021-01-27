using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoPessoal1.Model {
    class Banco {

        public static MySqlCommand AbrirBanco() {
            MySqlCommand cmd = new MySqlCommand();
            string strCon = @"server = 127.0.0.1; user id = root; persistsecurityinfo = True; database = projetolojabd";
            MySqlConnection cn = new MySqlConnection(strCon);
            cn.Open();
            cmd.Connection = cn;
            return cmd;
        }
    }
}
