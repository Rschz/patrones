using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patrones.IU
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresas frm = FrmEmpresas.ObtenerInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSocios frm = FrmSocios.OptenerInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();

        }
    }
}
