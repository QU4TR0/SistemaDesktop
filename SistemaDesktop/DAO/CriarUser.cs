using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDesktop
{
    public class CriarUser
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public String mensagem = "";
        public bool tem = false;
        public String cadastro(String nome, String cpf, String idArea, String user)
        {
            //Comando SQL ---SqlCommand
            /*cmd.CommandText = "SELECT * FROM usuarios WHERE user = @user AND senha = @senha";*/
            cmd.CommandText = "INSERT INTO cadastrar VALUES (@nome, @cpf, @idArea, @usuario)";

            //Parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@idArea", idArea);
            cmd.Parameters.AddWithValue("@usuario", user);

            //Conectar com BD ---Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                cmd.ExecuteNonQuery();
                //Desconectar com BD
                conexao.desconectar();
                //Mostrar msg de erro ou sucesso ---Variavel
                this.mensagem = "Usuario cadastrado!";
                tem = true;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de Dados";
                
            }
            return mensagem;
        }
    }
}
