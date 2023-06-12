using CadRamm;
using ClnRamm;
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
    public partial class FrmAutenticacion : Form
    {
        public FrmAutenticacion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool validar()
        {
            bool esValido = true;
            erpUsuario.SetError(txtUsuario, "");
            erpClave.SetError(txtClave, "");

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                erpUsuario.SetError(txtUsuario, "El campo usuario es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                erpClave.SetError(txtClave, "El campo contraseña es obligatorio");
                esValido = false;
            }
            return esValido;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                //new FrmPrincipal().ShowDialog();
                var usuario = UsuarioCln.validar(txtUsuario.Text, Util.Encrypt(txtClave.Text));
                if (usuario != null)
                {
                    Util.usuario = usuario;
                    txtClave.Text = string.Empty;
                    txtUsuario.Focus();
                    txtUsuario.SelectAll();
                    Visible = false;
                    new FrmPrincipal(this).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "::: Diessel Sur - Mensaje :::",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnIniciar.PerformClick();
        }

        private void FrmAutenticacion_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
