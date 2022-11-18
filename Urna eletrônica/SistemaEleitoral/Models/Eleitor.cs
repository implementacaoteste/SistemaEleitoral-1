namespace Models
{
    public class Eleitor
    {
		private int id;
		private string nome;
		private string titulo;
		private bool votou;

		public bool Votou
		{
			get { return votou; }
			set { votou = value; }
		}

		public string Titulo
		{
			get { return titulo; }
			set { titulo = value; }
		}

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

	}
}