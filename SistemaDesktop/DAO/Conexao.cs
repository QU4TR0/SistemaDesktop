<<<<<<< HEAD
﻿using System.Data.SqlClient;
=======
﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8

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
<<<<<<< HEAD
            if (con.State == System.Data.ConnectionState.Closed)
=======
            if(con.State == System.Data.ConnectionState.Closed)
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
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
