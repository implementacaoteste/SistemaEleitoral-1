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
                cmd.CommandText = "INSERT INTO Eleitor(Nome, Titulo, Votou)VALUES(@Nome, @Titulo, @Votou)";
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

        public DataTable BuscarPorTitulo(string _titulo)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT Id, Nome, Titulo, Votou FROM Eleitor WHERE Titulo LIKE @Titulo";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("@Titulo", "%" + _titulo + "%");
                da.Fill(dt);
                return dt;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}