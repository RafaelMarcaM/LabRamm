namespace CpRamm
{
    partial class FrmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCedulaIdentidad = new System.Windows.Forms.TextBox();
            this.lblCedulaIdentidad = new System.Windows.Forms.Label();
            this.txtParametros = new System.Windows.Forms.TextBox();
            this.lblParametros = new System.Windows.Forms.Label();
            this.gbxParametros = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.erpCedulaIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpApellidos = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCelular = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCargo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxDatos.SuspendLayout();
            this.gbxParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDatos
            // 
            this.gbxDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDatos.Controls.Add(this.cbxCargo);
            this.gbxDatos.Controls.Add(this.txtUsuario);
            this.gbxDatos.Controls.Add(this.lblUsuario);
            this.gbxDatos.Controls.Add(this.lblCargo);
            this.gbxDatos.Controls.Add(this.txtCelular);
            this.gbxDatos.Controls.Add(this.lblCelular);
            this.gbxDatos.Controls.Add(this.txtDireccion);
            this.gbxDatos.Controls.Add(this.txtSegundoApellido);
            this.gbxDatos.Controls.Add(this.txtPrimerApellido);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.lblDireccion);
            this.gbxDatos.Controls.Add(this.lblSegundoApellido);
            this.gbxDatos.Controls.Add(this.lblPrimerApellido);
            this.gbxDatos.Controls.Add(this.txtNombre);
            this.gbxDatos.Controls.Add(this.lblNombre);
            this.gbxDatos.Controls.Add(this.txtCedulaIdentidad);
            this.gbxDatos.Controls.Add(this.lblCedulaIdentidad);
            this.gbxDatos.Location = new System.Drawing.Point(94, 366);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(826, 202);
            this.gbxDatos.TabIndex = 19;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // cbxCargo
            // 
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.cbxCargo.Location = new System.Drawing.Point(542, 58);
            this.cbxCargo.MaxLength = 50;
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(221, 26);
            this.cbxCargo.TabIndex = 13;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(542, 88);
            this.txtUsuario.MaxLength = 12;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(221, 24);
            this.txtUsuario.TabIndex = 15;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(426, 88);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 18);
            this.lblUsuario.TabIndex = 20;
            this.lblUsuario.Text = "Usuario :";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(426, 58);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(57, 18);
            this.lblCargo.TabIndex = 19;
            this.lblCargo.Text = "Cargo :";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(542, 28);
            this.txtCelular.MaxLength = 16;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(221, 24);
            this.txtCelular.TabIndex = 12;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(426, 28);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(62, 18);
            this.lblCelular.TabIndex = 17;
            this.lblCelular.Text = "Celular :";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(150, 148);
            this.txtDireccion.MaxLength = 250;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(221, 24);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(150, 118);
            this.txtSegundoApellido.MaxLength = 30;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(221, 24);
            this.txtSegundoApellido.TabIndex = 10;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(150, 88);
            this.txtPrimerApellido.MaxLength = 30;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(221, 24);
            this.txtPrimerApellido.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = global::CpRamm.Properties.Resources._009_disabled;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(614, 137);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 46);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = global::CpRamm.Properties.Resources._011_diskette;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(473, 137);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 46);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 148);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(79, 18);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Direccion :";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Location = new System.Drawing.Point(6, 118);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(130, 18);
            this.lblSegundoApellido.TabIndex = 6;
            this.lblSegundoApellido.Text = "Segundo Apellido :";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Location = new System.Drawing.Point(6, 88);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(115, 18);
            this.lblPrimerApellido.TabIndex = 4;
            this.lblPrimerApellido.Text = "Primer Apellido :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 58);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 24);
            this.txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre :";
            // 
            // txtCedulaIdentidad
            // 
            this.txtCedulaIdentidad.Location = new System.Drawing.Point(150, 28);
            this.txtCedulaIdentidad.MaxLength = 15;
            this.txtCedulaIdentidad.Name = "txtCedulaIdentidad";
            this.txtCedulaIdentidad.Size = new System.Drawing.Size(221, 24);
            this.txtCedulaIdentidad.TabIndex = 7;
            this.txtCedulaIdentidad.TextChanged += new System.EventHandler(this.txtCedulaIdentidad_TextChanged);
            // 
            // lblCedulaIdentidad
            // 
            this.lblCedulaIdentidad.AutoSize = true;
            this.lblCedulaIdentidad.Location = new System.Drawing.Point(6, 28);
            this.lblCedulaIdentidad.Name = "lblCedulaIdentidad";
            this.lblCedulaIdentidad.Size = new System.Drawing.Size(144, 18);
            this.lblCedulaIdentidad.TabIndex = 0;
            this.lblCedulaIdentidad.Text = "Cedula de Identidad :";
            // 
            // txtParametros
            // 
            this.txtParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParametros.Location = new System.Drawing.Point(314, 64);
            this.txtParametros.Name = "txtParametros";
            this.txtParametros.Size = new System.Drawing.Size(545, 24);
            this.txtParametros.TabIndex = 1;
            this.txtParametros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametros_KeyPress);
            // 
            // lblParametros
            // 
            this.lblParametros.AutoSize = true;
            this.lblParametros.Location = new System.Drawing.Point(14, 64);
            this.lblParametros.Name = "lblParametros";
            this.lblParametros.Size = new System.Drawing.Size(279, 18);
            this.lblParametros.TabIndex = 12;
            this.lblParametros.Text = "Buscar por Nombre, Apellido  o Usuario :";
            // 
            // gbxParametros
            // 
            this.gbxParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxParametros.Controls.Add(this.dgvLista);
            this.gbxParametros.Location = new System.Drawing.Point(17, 110);
            this.gbxParametros.Name = "gbxParametros";
            this.gbxParametros.Size = new System.Drawing.Size(955, 198);
            this.gbxParametros.TabIndex = 11;
            this.gbxParametros.TabStop = false;
            this.gbxParametros.Text = "Lista de Usuarios";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(6, 23);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(943, 169);
            this.dgvLista.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(960, 35);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Usuarios";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::CpRamm.Properties.Resources._006_cancel;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(871, 314);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(101, 46);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::CpRamm.Properties.Resources._012_trash;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(575, 314);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 46);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::CpRamm.Properties.Resources._013_pencil;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(278, 314);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 46);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::CpRamm.Properties.Resources._005_plus;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(17, 314);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(101, 46);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Image = global::CpRamm.Properties.Resources._002_search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(865, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 46);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // erpCedulaIdentidad
            // 
            this.erpCedulaIdentidad.ContainerControl = this;
            // 
            // erpNombre
            // 
            this.erpNombre.ContainerControl = this;
            // 
            // erpApellidos
            // 
            this.erpApellidos.ContainerControl = this;
            // 
            // erpDireccion
            // 
            this.erpDireccion.ContainerControl = this;
            // 
            // erpCelular
            // 
            this.erpCelular.ContainerControl = this;
            // 
            // erpCargo
            // 
            this.erpCargo.ContainerControl = this;
            // 
            // erpUsuario
            // 
            this.erpUsuario.ContainerControl = this;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 556);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtParametros);
            this.Controls.Add(this.lblParametros);
            this.Controls.Add(this.gbxParametros);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(14, 75);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Diesel Sur - Usuarios :::";
            this.Load += new System.EventHandler(this.FrmUsuario_Load_1);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.gbxParametros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCedulaIdentidad;
        private System.Windows.Forms.Label lblCedulaIdentidad;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtParametros;
        private System.Windows.Forms.Label lblParametros;
        private System.Windows.Forms.GroupBox gbxParametros;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.ErrorProvider erpCedulaIdentidad;
        private System.Windows.Forms.ErrorProvider erpNombre;
        private System.Windows.Forms.ErrorProvider erpApellidos;
        private System.Windows.Forms.ErrorProvider erpDireccion;
        private System.Windows.Forms.ErrorProvider erpCelular;
        private System.Windows.Forms.ErrorProvider erpCargo;
        private System.Windows.Forms.ErrorProvider erpUsuario;
    }
}