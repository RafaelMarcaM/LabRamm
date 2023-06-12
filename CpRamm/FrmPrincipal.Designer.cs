namespace CpRamm
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.C1Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnProductos = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonTab2 = new C1.Win.C1Ribbon.RibbonTab();
            this.Emp = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonButton2 = new C1.Win.C1Ribbon.RibbonButton();
            this.btnUsuario = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonTopToolBar1 = new C1.Win.C1Ribbon.RibbonTopToolBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ribbonTab3 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup2 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonButton1 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton3 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonTab4 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup3 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonButton4 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonGroup4 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonButton5 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton6 = new C1.Win.C1Ribbon.RibbonButton();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(968, 154);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab2);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab3);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab4);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            this.c1Ribbon1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Silver;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Groups.Add(this.ribbonGroup4);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Catalogo";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.btnProductos);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Administracion de Catalogos";
            // 
            // btnProductos
            // 
            this.btnProductos.Description = "Productos";
            this.btnProductos.LargeImage = global::CpRamm.Properties.Resources._008_settings;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.SmallImage")));
            this.btnProductos.Text = "Productos";
            this.btnProductos.ToolTip = "Productos";
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Groups.Add(this.Emp);
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Administracion";
            // 
            // Emp
            // 
            this.Emp.Items.Add(this.ribbonButton2);
            this.Emp.Items.Add(this.btnUsuario);
            this.Emp.LauncherToolTip = "Administración";
            this.Emp.Name = "Emp";
            this.Emp.Text = "Administración";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Description = "Empleados";
            this.ribbonButton2.LargeImage = global::CpRamm.Properties.Resources._014_cooperation;
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "Empleados";
            this.ribbonButton2.ToolTip = "Empleados";
            // 
            // btnUsuario
            // 
            this.btnUsuario.Description = "Usuarios";
            this.btnUsuario.LargeImage = global::CpRamm.Properties.Resources._015_user;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnUsuario.SmallImage")));
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.ToolTip = "Usuarios";
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CpRamm.Properties.Resources.FondeRepuestos1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(968, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Groups.Add(this.ribbonGroup2);
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "Clientes";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.ribbonButton1);
            this.ribbonGroup2.Items.Add(this.ribbonButton3);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Clientes y Proveedores";
            this.ribbonGroup2.DialogLauncherClick += new System.EventHandler(this.ribbonGroup2_DialogLauncherClick);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Clientes";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.LargeImage")));
            this.ribbonButton3.Name = "ribbonButton3";
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "Proveedores";
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Groups.Add(this.ribbonGroup3);
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Text = "Información";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Items.Add(this.ribbonButton4);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Información";
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.LargeImage")));
            this.ribbonButton4.Name = "ribbonButton4";
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Text = "Acerca de";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Items.Add(this.ribbonButton5);
            this.ribbonGroup4.Items.Add(this.ribbonButton6);
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Ventas";
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.LargeImage")));
            this.ribbonButton5.Name = "ribbonButton5";
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Text = "Detalle de Ventas";
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.LargeImage")));
            this.ribbonButton6.Name = "ribbonButton6";
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            this.ribbonButton6.Text = "Detalle de Compras";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(968, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.c1Ribbon1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.C1Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.C1Ribbon.RibbonQat ribbonQat1;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab1;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.C1Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private C1.Win.C1Ribbon.RibbonButton btnProductos;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab2;
        private C1.Win.C1Ribbon.RibbonGroup Emp;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton2;
        private C1.Win.C1Ribbon.RibbonButton btnUsuario;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab3;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton1;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton3;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab4;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton4;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton5;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton6;
    }
}