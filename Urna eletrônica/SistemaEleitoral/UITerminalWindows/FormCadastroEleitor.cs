using BLL;
using Models;

namespace UITerminalWindows
{
    public partial class FormCadastroEleitor : Form
    {
        public FormCadastroEleitor()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastroEleitor_Load(object sender, EventArgs e)
        {
            Eleitor eleitor = new Eleitor();
            bindingSourceEleitor.DataSource = eleitor;
            bindingSourceEleitor.AddNew();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            bindingSourceEleitor.EndEdit();
            EleitorBLL eleitorBLL = new EleitorBLL();
            eleitorBLL.Inerir((Eleitor)bindingSourceEleitor.Current);
            MessageBox.Show("Eleitor cadastrado com sucesso!");
            Close();
        }
    }
}