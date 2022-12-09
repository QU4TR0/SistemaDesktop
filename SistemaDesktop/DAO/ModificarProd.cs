using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaDesktop.DAO
{
    public class ModificarProd
    {
        public bool tem = false;
        public String mensagem = "";//Tudo Ok
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public String nomeProd;
        public String marcaProd;
        public String precoProd;
        public int idProdMod;
        public bool buscar(int idProd)
        {
            //Comandos SQL para verificar se tem no banco
            cmd.CommandText = "SELECT * FROM produtos WHERE ID = @idProd";
            cmd.Parameters.AddWithValue("@idProd", idProd);

            //Conectar com BD ---Conexao
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//Se foi encontrado linhas
                {
                    tem = true;
                    dr.Read();
                    idProdMod = dr.GetInt32(0);
                    nomeProd = dr.GetString(1);
                    marcaProd = dr.GetString(2);
                    precoProd = dr.GetString(3);
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";
            }
            return tem;
        }

        public String salvarAlteracoes(String nomeProd, String marcaProd, String precoProd, int idProdMod, int idProd)
        {
            tem = false;
            //Comando SQL para atualizar banco de dados
            cmd.CommandText = "UPDATE produtos SET Nome = @nome, Marca = @marca, Preco = @preco, ID = @idMod WHERE ID = @idProd";
            cmd.Parameters.AddWithValue("@nome", nomeProd);
            cmd.Parameters.AddWithValue("@marca", marcaProd);
            cmd.Parameters.AddWithValue("@preco", precoProd);
            cmd.Parameters.AddWithValue("@idMod", idProdMod);
            cmd.Parameters.AddWithValue("@idProd", idProd);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Alterações salvas com sucesso";
                tem = true;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro no banco de dados";
            }

            return mensagem;
        }

        public String excluir(String idProd)
        {
            tem = false;
            //Comando SQL para deletar dados no banco
            cmd.CommandText = "DELETE FROM produtos WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", idProd);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Produto excluído com sucesso!";
                tem = true;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro no banco de dados";
            }

            return mensagem;
        }
    }
}
