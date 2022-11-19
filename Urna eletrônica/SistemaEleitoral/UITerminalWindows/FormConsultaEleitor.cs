using BLL;
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
            if (bindingSourceEleitor.Count <= 0)
                return;

            if (MessageBox.Show("Deseja realmente excluir este eleitor?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            EleitorBLL eleitorBLL = new EleitorBLL();
            
            eleitorBLL.Excluir(Convert.ToInt32(((DataRowView)bindingSourceEleitor.Current).Row["Id"]));
            
            buttonBuscar_Click(sender, e);

            MessageBox.Show("Registro excluído com sucesso!");
        }
    }
}
