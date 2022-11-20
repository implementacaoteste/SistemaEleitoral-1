using BLL;
using Models;

namespace UITerminalWindows
{
    public partial class FormCadastroEleitor : Form
    {
        private int id;
        public FormCadastroEleitor(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastroEleitor_Load(object sender, EventArgs e)
        {
            if (id == 0)
            {
                Eleitor eleitor = new Eleitor();
                bindingSourceEleitor.DataSource = eleitor;
                bindingSourceEleitor.AddNew();
            }
            else
            {
                EleitorBLL eleitorBLL = new EleitorBLL();
                bindingSourceEleitor.DataSource = eleitorBLL.BucarPorId(id);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            EleitorBLL eleitorBLL = new EleitorBLL();
            if (id == 0)
            {
                bindingSourceEleitor.EndEdit();
                eleitorBLL.Inerir((Eleitor)bindingSourceEleitor.Current);
                MessageBox.Show("Eleitor cadastrado com sucesso!");
            }
            else
            {
                Eleitor eleitor = new Eleitor();
                eleitor.Id = id;
                eleitor.Nome = textBoxNome.Text;
                eleitor.Titulo = textBoxTitulo.Text;
                eleitor.Votou = checkBoxVotou.Checked;
                eleitorBLL.Alterar(eleitor);
                MessageBox.Show("Eleitor alterado com sucesso!");
            }
            Close();
        }
    }
}