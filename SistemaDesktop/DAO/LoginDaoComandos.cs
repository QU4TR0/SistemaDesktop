using System;
<<<<<<< HEAD
using System.Data.SqlClient;
=======
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDesktop.Modelo;
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8

namespace SistemaDesktop.DAO
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";//Tudo Ok
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {
            //Comandos SQL para verificar se tem no banco
            cmd.CommandText = "SELECT * FROM usuarios WHERE email = @login AND senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            //Conectar com BD ---Conexao
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//Se foi encontrado linhas
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {
<<<<<<< HEAD
                this.mensagem = "Erro com Banco de Dados";
=======
                this.mensagem = "Erro com Banco de Dados"; 
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            tem = false;
            //comandos para inserir
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "INSERT INTO usuarios VALUES (@email, @s);";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com Banco de Dados";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            return mensagem;
        }
    }
}
