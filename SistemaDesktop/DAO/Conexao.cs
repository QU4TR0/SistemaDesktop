using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDesktop
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        //Construtor
        public Conexao()
        {
            con.ConnectionString = @"Data Source=localhost;Initial Catalog=SISTEMA;Integrated Security=True";
        }
        //Método pra conectar com db
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Método pra desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
