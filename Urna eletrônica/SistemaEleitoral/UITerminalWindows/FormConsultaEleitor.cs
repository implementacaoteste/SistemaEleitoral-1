using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITerminalWindows
{
    public partial class FormConsultaEleitor : Form
    {
        public FormConsultaEleitor()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            EleitorBLL eleitorBLL = new EleitorBLL();
            bindingSourceEleitor.DataSource = eleitorBLL.BucarPorTitulo(textBoxBuscar.Text);
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            using (FormCadastroEleitor frm = new FormCadastroEleitor())
            {
                frm.ShowDialog();
            }
        }

        private void FormConsultaEleitor_Load(object sender, EventArgs e)
        {
            EleitorBLL eleitorBLL = new EleitorBLL();
            bindingSourceEleitor.DataSource = eleitorBLL.BucarPorTitulo("");
            
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja mesmo excluir este eleitor?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            EleitorBLL eleitorBLL = new EleitorBLL();

            int id = Convert.ToInt32(((DataRowView)bindingSourceEleitor.Current).Row["Id"]);

            eleitorBLL.Excluir(id);
            
            MessageBox.Show("Registro excluído com sucesso!");
        }
    }
}
