using ClnRamm;
using CadRamm;
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
    public partial class FrmProducto : Form
    {
        bool esNuevo = false;
        public FrmProducto()
        {
            InitializeComponent();
            cbxUnidadMedida.KeyPress += Util.onlyNumbers;
            nudExistencias.KeyPress += Util.onlyNumbers;
            nudPrecioVenta.KeyPress += Util.onlyNumbers;
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            listar();
        }
        private void listar()
        {
            var productos = ProductoCln.listarPa(txtParametros.Text.Trim());
            dgvLista.DataSource = productos;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["codigo"].HeaderText = "Código";
            dgvLista.Columns["descripcion"].HeaderText = "Descripción";
            dgvLista.Columns["unidadMedida"].HeaderText = "Unidad de Medida";
            dgvLista.Columns["existencias"].HeaderText = "Existencias";
            dgvLista.Columns["precioVenta"].HeaderText = "Precio de Venta";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
            btnEditar.Enabled = productos.Count > 0;
            btnEliminar.Enabled = productos.Count > 0;
            if (productos.Count > 0) dgvLista.Rows[0].Cells["codigo"].Selected = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            txtCodigo.Focus();
            limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var producto = ProductoCln.get(id);
            txtCodigo.Text = producto.codigo;
            txtDescripcion.Text = producto.descripcion;
            cbxUnidadMedida.Text = producto.unidadMedida;
            nudExistencias.Value = producto.existencias;
            nudPrecioVenta.Value = producto.precioVenta;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var producto = new Producto();
                producto.codigo = txtCodigo.Text.Trim();
                producto.descripcion = txtDescripcion.Text.Trim();
                producto.unidadMedida = cbxUnidadMedida.Text;
                producto.existencias = Convert.ToDecimal(nudExistencias.Text);
                producto.precioVenta = Convert.ToDecimal(nudPrecioVenta.Text);
                producto.usuarioRegistro = Util.usuario.usuario1;

                if (esNuevo)
                {
                    producto.fechaRegistro = DateTime.Now;
                    producto.registroActivo = true;
                    ProductoCln.insertar(producto);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    producto.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    ProductoCln.actualizar(producto);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Producto guardado correctamente", "::: Diesel Sur - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool validar()
        {
            bool esValido = true;
            erpCodigo.SetError(txtCodigo, "");
            erpDescripcion.SetError(txtDescripcion, "");
            erpUnidadMedida.SetError(cbxUnidadMedida, "");
            erpExistencias.SetError(nudExistencias, "");
            erpPrecioVenta.SetError(nudPrecioVenta, "");

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                erpCodigo.SetError(txtCodigo, "El campo Código es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                erpDescripcion.SetError(txtDescripcion, "El campo Descripción es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(cbxUnidadMedida.Text))
            {
                erpUnidadMedida.SetError(cbxUnidadMedida, "El campo Unidad de Media es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(nudExistencias.Text))
            {
                erpExistencias.SetError(nudExistencias, "El campo Existencias es obligatorio");
                esValido = false;
            }
            if (nudExistencias.Value < 0)
            {
                erpExistencias.SetError(nudExistencias, "El campo Existencias debe ser mayor a 0");
                esValido = false;
            }
            if (string.IsNullOrEmpty(nudPrecioVenta.Text))
            {
                erpPrecioVenta.SetError(nudPrecioVenta, "El campo Precio de Venta es obligatorio");
                esValido = false;
            }
            if (nudPrecioVenta.Value < 0)
            {
                erpPrecioVenta.SetError(nudPrecioVenta, "El campo Precio de Venta debe ser mayor a 0");
                esValido = false;
            }
            return esValido;
        }
        private void limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            cbxUnidadMedida.SelectedIndex = -1;
            nudExistencias.Value = 0;
            nudPrecioVenta.Value = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string codigo = dgvLista.Rows[index].Cells["codigo"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja " +
                $"el producto {codigo}?", "::: Diesel Sur - Mensaje :::",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                ProductoCln.eliminar(id, Util.usuario.usuario1);
                listar();
                MessageBox.Show($"Producto dado de baja correctamente", "::: Diesel Sur - Mensaje :::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
