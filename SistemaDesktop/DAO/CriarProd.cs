using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDesktop.DAO
{
    public class CriarProd
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public String mensagem = "";
        public bool tem = false;
        public String cadastro(int idProd, String nome, String marca, String preco)
        {
            //Comando SQL ---SqlCommand
            cmd.CommandText = "INSERT INTO produtos (ID, Nome, Marca, Preco) VALUES (@idProd, @nome, @marca, @preco)";

            //Parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@idProd", idProd);
            cmd.Parameters.AddWithValue("@preco", preco);

            //Conectar com BD ---Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                cmd.ExecuteNonQuery();
                //Desconectar com BD
                conexao.desconectar();
                //Mostrar msg de erro ou sucesso ---Variavel
                this.mensagem = "Produto cadastrado!";
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
