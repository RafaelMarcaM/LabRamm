using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpRamm
{
    public partial class FrmPrincipal : Form
    {
        FrmAutenticacion frmAutenticacion;
        public FrmPrincipal(FrmAutenticacion frmAutenticacion)
        {
            InitializeComponent();
            this.frmAutenticacion = frmAutenticacion;
        }
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAutenticacion.Visible = true;
        }
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            new FrmProducto().ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            new FrmUsuario().ShowDialog();
        }

        private void ribbonGroup2_DialogLauncherClick(object sender, EventArgs e)
        {

        }
    }
}
