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
    public partial class FrmSocios : Form
    {
        private FrmSocios()
        {
            InitializeComponent();
        }

        private static FrmSocios Instancia = null;
        public static FrmSocios OptenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new FrmSocios();
            }

            return Instancia;
        }
    }
}
