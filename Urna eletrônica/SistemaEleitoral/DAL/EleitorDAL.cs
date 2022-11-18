using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class EleitorDAL
    {
        public void Inserir(Eleitor _eleitor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "INSERT INTO Eleitor(Nome, Titutlo, Votou)VALUES(@Nome, @Titutlo, @Votou)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _eleitor.Nome);
                cmd.Parameters.AddWithValue("@Titulo", _eleitor.Titulo);
                cmd.Parameters.AddWithValue("@Votou", _eleitor.Votou);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }

        public void Excluir(Eleitor _eleitor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Eleitor WHERE Id = @Id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _eleitor.Id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Eleitor _eleitor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "UPDATE Eleitor SET Nome = @Nome, Titulo = @Titulo, Votou = @Votou WHERE Id = @Id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _eleitor.Nome);
                cmd.Parameters.AddWithValue("@Titulo", _eleitor.Titulo);
                cmd.Parameters.AddWithValue("@Votou", _eleitor.Votou);
                cmd.Parameters.AddWithValue("@Id", _eleitor.Id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }
    }
}