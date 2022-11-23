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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void eleitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaEleitor frm = new FormConsultaEleitor())
            {
                frm.ShowDialog();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormSobre frm = new FormSobre())
            {
                frm.ShowDialog();
            }
        }
    }
}
