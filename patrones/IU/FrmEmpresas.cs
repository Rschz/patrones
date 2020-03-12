using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using patrones.DAO;

namespace patrones.IU
{
    public partial class FrmEmpresas : Form
    {
        //PATRON SINGLETON
        private FrmEmpresas()
        {
            InitializeComponent();
        }

        private static FrmEmpresas Instancia = null;
        public static FrmEmpresas ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new FrmEmpresas();
            }

            return Instancia;
        }


        private void FrmEmpresas_Load(object sender, EventArgs e)
        {
            VerRegistros("");
        }

        private void VerRegistros(string param)
        {
            EmpresaDao DAO = new EmpresaDao();

            dataGridView1.DataSource = DAO.VerRegistros(param);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VerRegistros(txtValor.Text.Trim());
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            VerRegistros(txtValor.Text.Trim());
        }
    }
}
