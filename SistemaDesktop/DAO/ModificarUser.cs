using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaDesktop.DAO
{
    public class ModificarUser
    {
        public bool tem = false;
        public String mensagem = "";//Tudo Ok
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public String emailMod;
        public String nome;
        public String cpf;
        public int idArea;
        public bool buscar(String email)
        {
            //Comandos SQL para verificar se tem no banco
            cmd.CommandText = "SELECT * FROM cadastrar WHERE email = @email";
            cmd.Parameters.AddWithValue("@email", email);

            //Conectar com BD ---Conexao
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//Se foi encontrado linhas
                {
                    tem = true;
                    dr.Read();
                    nome = dr.GetString(1);
                    cpf = dr.GetString(2);
                    idArea = dr.GetInt32(3);
                    emailMod = dr.GetString(4);
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";
            }
            return tem;
        }

        public String salvarAlteracoes(String nome, String cpf, int idArea, String mail, String emailBusca)
        {
            tem = false;
            //Comando SQL para atualizar banco de dados
            cmd.CommandText = "UPDATE cadastrar SET Nome = @nome, CPF = @cpf, ID_Area = @idArea, email = @mail WHERE email = @email";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@idArea", idArea);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@email", emailBusca);

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

        public String excluir(String em)
        {
            tem = false;
            //Comando SQL para deletar dados no banco
            cmd.CommandText = "DELETE FROM cadastrar WHERE email = @em";
            cmd.Parameters.AddWithValue("@em", em);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Usuário excluído com sucesso!";
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
