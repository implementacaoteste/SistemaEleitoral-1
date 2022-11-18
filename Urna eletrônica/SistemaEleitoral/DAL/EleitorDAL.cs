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
    }
}