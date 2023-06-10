﻿using ClnRamm;
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
            txtUnidadMedida.Text = producto.unidadMedida;
            txtExistencias.Text = Convert.ToString(producto.existencias);
            txtPrecioVenta.Text = Convert.ToString(producto.precioVenta);
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
            //if (validar())
            {
                var producto = new Producto();
                producto.codigo = txtCodigo.Text.Trim();
                producto.descripcion = txtDescripcion.Text.Trim();
                producto.unidadMedida = txtUnidadMedida.Text;
                producto.existencias = Convert.ToDecimal(txtExistencias.Text);
                producto.precioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                //producto.usuarioRegistro = Util.usuario.usuario;

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
        //private bool validar()
        //{
        //    bool esValido = true;
        //    erpCodigo.SetError(txtCodigo, "");
        //    erpDescripcion.SetError(txtDescripcion, "");
        //    erpUnidadMedida.SetError(cbxUnidadMedida, "");
        //    erpSaldo.SetError(nudSaldo, "");
        //    erpPrecioVenta.SetError(nudPrecioVenta, "");

        //    if (string.IsNullOrEmpty(txtCodigo.Text))
        //    {
        //        erpCodigo.SetError(txtCodigo, "El campo Código es obligatorio");
        //        esValido = false;
        //    }
        //    if (string.IsNullOrEmpty(txtDescripcion.Text))
        //    {
        //        erpDescripcion.SetError(txtDescripcion, "El campo Descripción es obligatorio");
        //        esValido = false;
        //    }
        //    if (string.IsNullOrEmpty(cbxUnidadMedida.Text))
        //    {
        //        erpUnidadMedida.SetError(cbxUnidadMedida, "El campo Unidad de Media es obligatorio");
        //        esValido = false;
        //    }
        //    if (string.IsNullOrEmpty(nudSaldo.Text))
        //    {
        //        erpSaldo.SetError(nudSaldo, "El campo Saldo es obligatorio");
        //        esValido = false;
        //    }
        //    if (nudSaldo.Value < 0)
        //    {
        //        erpSaldo.SetError(nudSaldo, "El campo Saldo debe ser mayor a 0");
        //        esValido = false;
        //    }
        //    if (string.IsNullOrEmpty(nudPrecioVenta.Text))
        //    {
        //        erpPrecioVenta.SetError(nudPrecioVenta, "El campo Precio de Venta es obligatorio");
        //        esValido = false;
        //    }
        //    if (nudPrecioVenta.Value < 0)
        //    {
        //        erpPrecioVenta.SetError(nudPrecioVenta, "El campo Precio de Venta debe ser mayor a 0");
        //        esValido = false;
        //    }
        //    return esValido;
        //}
        private void limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtUnidadMedida.Text = string.Empty;
            txtExistencias.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
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
                ProductoCln.eliminar(id/*, Util.usuario.usuario*/);
                listar();
                MessageBox.Show($"Producto dado de baja correctamente", "::: Diesel Sur - Mensaje :::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}