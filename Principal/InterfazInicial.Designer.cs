namespace sistema_de_facturacion.Principal
{
    partial class InterfazInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazInicial));
            this.panelVertical = new System.Windows.Forms.Panel();
            this.ayudaButton = new System.Windows.Forms.Button();
            this.administracionButton = new System.Windows.Forms.Button();
            this.estadisticasButton = new System.Windows.Forms.Button();
            this.estimadosButton = new System.Windows.Forms.Button();
            this.proveedoresButton = new System.Windows.Forms.Button();
            this.clientesButton = new System.Windows.Forms.Button();
            this.facturacionButton = new System.Windows.Forms.Button();
            this.inventarioButton = new System.Windows.Forms.Button();
            this.pctrLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.pctrMenu = new System.Windows.Forms.PictureBox();
            this.contenedor = new System.Windows.Forms.Panel();
            this.bienvenidatxt = new System.Windows.Forms.Label();
            this.submenuAdministracion = new System.Windows.Forms.Panel();
            this.categoriaB = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.submenuAyuda = new System.Windows.Forms.Panel();
            this.infoButton = new System.Windows.Forms.Button();
            this.manuaButton = new System.Windows.Forms.Button();
            this.submenuUsuarios = new System.Windows.Forms.Panel();
            this.misDatosButton = new System.Windows.Forms.Button();
            this.gestionarUsuarioButton = new System.Windows.Forms.Button();
            this.eliminarUsuarioButton = new System.Windows.Forms.Button();
            this.modificarUsuarioButton = new System.Windows.Forms.Button();
            this.agregarUsuarioButton = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.submenuEstadisticas = new System.Windows.Forms.Panel();
            this.ventasPeriodoButton = new System.Windows.Forms.Button();
            this.submenuEstimados = new System.Windows.Forms.Panel();
            this.revisarProformaButton = new System.Windows.Forms.Button();
            this.anularProformaButton = new System.Windows.Forms.Button();
            this.nuevaProformaButton = new System.Windows.Forms.Button();
            this.submenuProveedores = new System.Windows.Forms.Panel();
            this.consultarProveedorButton = new System.Windows.Forms.Button();
            this.eliminarProveedorButton = new System.Windows.Forms.Button();
            this.modificarProveedorButton = new System.Windows.Forms.Button();
            this.agregarProveedorButton = new System.Windows.Forms.Button();
            this.submenuClientes = new System.Windows.Forms.Panel();
            this.consultarClienteButton = new System.Windows.Forms.Button();
            this.eliminarClienteButton = new System.Windows.Forms.Button();
            this.modificarClienteButton = new System.Windows.Forms.Button();
            this.agregarClienteButton = new System.Windows.Forms.Button();
            this.submenuFacturacion = new System.Windows.Forms.Panel();
            this.revisarFacturaButton = new System.Windows.Forms.Button();
            this.anularFacturaButton = new System.Windows.Forms.Button();
            this.nuevaFacturaButton = new System.Windows.Forms.Button();
            this.submenuInventario = new System.Windows.Forms.Panel();
            this.consultarProductoButton = new System.Windows.Forms.Button();
            this.eliminarProductoButton = new System.Windows.Forms.Button();
            this.editarProductoButton = new System.Windows.Forms.Button();
            this.nuevoProductoButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.salirButton = new System.Windows.Forms.Button();
            this.panelVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrMenu)).BeginInit();
            this.contenedor.SuspendLayout();
            this.submenuAdministracion.SuspendLayout();
            this.submenuAyuda.SuspendLayout();
            this.submenuUsuarios.SuspendLayout();
            this.submenuEstadisticas.SuspendLayout();
            this.submenuEstimados.SuspendLayout();
            this.submenuProveedores.SuspendLayout();
            this.submenuClientes.SuspendLayout();
            this.submenuFacturacion.SuspendLayout();
            this.submenuInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVertical
            // 
            this.panelVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(196)))), ((int)(((byte)(63)))));
            this.panelVertical.Controls.Add(this.salirButton);
            this.panelVertical.Controls.Add(this.ayudaButton);
            this.panelVertical.Controls.Add(this.administracionButton);
            this.panelVertical.Controls.Add(this.estadisticasButton);
            this.panelVertical.Controls.Add(this.estimadosButton);
            this.panelVertical.Controls.Add(this.proveedoresButton);
            this.panelVertical.Controls.Add(this.clientesButton);
            this.panelVertical.Controls.Add(this.facturacionButton);
            this.panelVertical.Controls.Add(this.inventarioButton);
            this.panelVertical.Controls.Add(this.pctrLogo);
            this.panelVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVertical.Location = new System.Drawing.Point(0, 0);
            this.panelVertical.Name = "panelVertical";
            this.panelVertical.Size = new System.Drawing.Size(280, 750);
            this.panelVertical.TabIndex = 0;
            this.panelVertical.Click += new System.EventHandler(this.PanelVertical_Click);
            this.panelVertical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelVertical_MouseDown);
            // 
            // ayudaButton
            // 
            this.ayudaButton.FlatAppearance.BorderSize = 0;
            this.ayudaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.ayudaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayudaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ayudaButton.Image = ((System.Drawing.Image)(resources.GetObject("ayudaButton.Image")));
            this.ayudaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ayudaButton.Location = new System.Drawing.Point(0, 546);
            this.ayudaButton.Name = "ayudaButton";
            this.ayudaButton.Size = new System.Drawing.Size(280, 52);
            this.ayudaButton.TabIndex = 32;
            this.ayudaButton.Text = "Ayuda";
            this.ayudaButton.UseVisualStyleBackColor = true;
            this.ayudaButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AyudaButton_MouseDown);
            this.ayudaButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AyudaButton_MouseMove);
            // 
            // administracionButton
            // 
            this.administracionButton.FlatAppearance.BorderSize = 0;
            this.administracionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.administracionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.administracionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administracionButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.administracionButton.Image = ((System.Drawing.Image)(resources.GetObject("administracionButton.Image")));
            this.administracionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.administracionButton.Location = new System.Drawing.Point(0, 484);
            this.administracionButton.Name = "administracionButton";
            this.administracionButton.Size = new System.Drawing.Size(280, 52);
            this.administracionButton.TabIndex = 31;
            this.administracionButton.Text = "Administración";
            this.administracionButton.UseVisualStyleBackColor = true;
            this.administracionButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseMove);
            // 
            // estadisticasButton
            // 
            this.estadisticasButton.FlatAppearance.BorderSize = 0;
            this.estadisticasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.estadisticasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estadisticasButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadisticasButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.estadisticasButton.Image = ((System.Drawing.Image)(resources.GetObject("estadisticasButton.Image")));
            this.estadisticasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.estadisticasButton.Location = new System.Drawing.Point(0, 423);
            this.estadisticasButton.Name = "estadisticasButton";
            this.estadisticasButton.Size = new System.Drawing.Size(280, 52);
            this.estadisticasButton.TabIndex = 3;
            this.estadisticasButton.Text = "Estadísticas";
            this.estadisticasButton.UseVisualStyleBackColor = true;
            this.estadisticasButton.Click += new System.EventHandler(this.Button6_Click);
            this.estadisticasButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EstadisticasButton_MouseMove);
            // 
            // estimadosButton
            // 
            this.estimadosButton.FlatAppearance.BorderSize = 0;
            this.estimadosButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.estimadosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estimadosButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimadosButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.estimadosButton.Image = ((System.Drawing.Image)(resources.GetObject("estimadosButton.Image")));
            this.estimadosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.estimadosButton.Location = new System.Drawing.Point(0, 365);
            this.estimadosButton.Name = "estimadosButton";
            this.estimadosButton.Size = new System.Drawing.Size(280, 52);
            this.estimadosButton.TabIndex = 3;
            this.estimadosButton.Text = "Estimados";
            this.estimadosButton.UseVisualStyleBackColor = true;
            this.estimadosButton.Click += new System.EventHandler(this.Button5_Click);
            this.estimadosButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EstimadosButton_MouseMove);
            // 
            // proveedoresButton
            // 
            this.proveedoresButton.FlatAppearance.BorderSize = 0;
            this.proveedoresButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.proveedoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proveedoresButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedoresButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.proveedoresButton.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresButton.Image")));
            this.proveedoresButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proveedoresButton.Location = new System.Drawing.Point(0, 307);
            this.proveedoresButton.Name = "proveedoresButton";
            this.proveedoresButton.Size = new System.Drawing.Size(280, 52);
            this.proveedoresButton.TabIndex = 3;
            this.proveedoresButton.Text = "Proveedores";
            this.proveedoresButton.UseVisualStyleBackColor = true;
            this.proveedoresButton.Click += new System.EventHandler(this.Button4_Click);
            this.proveedoresButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProveedoresButton_MouseMove);
            // 
            // clientesButton
            // 
            this.clientesButton.FlatAppearance.BorderSize = 0;
            this.clientesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.clientesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.clientesButton.Image = ((System.Drawing.Image)(resources.GetObject("clientesButton.Image")));
            this.clientesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientesButton.Location = new System.Drawing.Point(0, 249);
            this.clientesButton.Name = "clientesButton";
            this.clientesButton.Size = new System.Drawing.Size(280, 52);
            this.clientesButton.TabIndex = 3;
            this.clientesButton.Text = "Clientes";
            this.clientesButton.UseVisualStyleBackColor = true;
            this.clientesButton.Click += new System.EventHandler(this.ClientesButton_Click);
            this.clientesButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientesButton_MouseMove);
            // 
            // facturacionButton
            // 
            this.facturacionButton.FlatAppearance.BorderSize = 0;
            this.facturacionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.facturacionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facturacionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturacionButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.facturacionButton.Image = ((System.Drawing.Image)(resources.GetObject("facturacionButton.Image")));
            this.facturacionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.facturacionButton.Location = new System.Drawing.Point(0, 191);
            this.facturacionButton.Name = "facturacionButton";
            this.facturacionButton.Size = new System.Drawing.Size(280, 52);
            this.facturacionButton.TabIndex = 3;
            this.facturacionButton.Text = "Facturación";
            this.facturacionButton.UseVisualStyleBackColor = true;
            this.facturacionButton.Click += new System.EventHandler(this.Button2_Click);
            this.facturacionButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FacturacionButton_MouseMove);
            // 
            // inventarioButton
            // 
            this.inventarioButton.FlatAppearance.BorderSize = 0;
            this.inventarioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.inventarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventarioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.inventarioButton.Image = ((System.Drawing.Image)(resources.GetObject("inventarioButton.Image")));
            this.inventarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventarioButton.Location = new System.Drawing.Point(0, 133);
            this.inventarioButton.Name = "inventarioButton";
            this.inventarioButton.Size = new System.Drawing.Size(280, 52);
            this.inventarioButton.TabIndex = 2;
            this.inventarioButton.Text = "Inventario";
            this.inventarioButton.UseVisualStyleBackColor = true;
            this.inventarioButton.Click += new System.EventHandler(this.Button1_Click);
            this.inventarioButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InventarioButton_MouseDown);
            this.inventarioButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InventarioButton_MouseMove);
            // 
            // pctrLogo
            // 
            this.pctrLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctrLogo.Image")));
            this.pctrLogo.Location = new System.Drawing.Point(3, 3);
            this.pctrLogo.Name = "pctrLogo";
            this.pctrLogo.Size = new System.Drawing.Size(274, 88);
            this.pctrLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrLogo.TabIndex = 0;
            this.pctrLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.minimizar);
            this.panel2.Controls.Add(this.maximizar);
            this.panel2.Controls.Add(this.cerrar);
            this.panel2.Controls.Add(this.pctrMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(280, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 50);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(924, 9);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(24, 24);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 2;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(954, 9);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(24, 24);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar.TabIndex = 2;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(984, 9);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(24, 24);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 1;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // pctrMenu
            // 
            this.pctrMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrMenu.Image = ((System.Drawing.Image)(resources.GetObject("pctrMenu.Image")));
            this.pctrMenu.Location = new System.Drawing.Point(6, 9);
            this.pctrMenu.Name = "pctrMenu";
            this.pctrMenu.Size = new System.Drawing.Size(35, 35);
            this.pctrMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrMenu.TabIndex = 0;
            this.pctrMenu.TabStop = false;
            this.pctrMenu.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.bienvenidatxt);
            this.contenedor.Controls.Add(this.submenuAdministracion);
            this.contenedor.Controls.Add(this.submenuAyuda);
            this.contenedor.Controls.Add(this.submenuUsuarios);
            this.contenedor.Controls.Add(this.lblFecha);
            this.contenedor.Controls.Add(this.lblhora);
            this.contenedor.Controls.Add(this.submenuEstadisticas);
            this.contenedor.Controls.Add(this.submenuEstimados);
            this.contenedor.Controls.Add(this.submenuProveedores);
            this.contenedor.Controls.Add(this.submenuClientes);
            this.contenedor.Controls.Add(this.submenuFacturacion);
            this.contenedor.Controls.Add(this.submenuInventario);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(280, 50);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1020, 700);
            this.contenedor.TabIndex = 2;
            this.contenedor.Click += new System.EventHandler(this.Contenedor_Click);
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            this.contenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Contenedor_MouseDown);
            this.contenedor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Contenedor_MouseMove);
            // 
            // bienvenidatxt
            // 
            this.bienvenidatxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bienvenidatxt.AutoSize = true;
            this.bienvenidatxt.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenidatxt.Location = new System.Drawing.Point(26, 0);
            this.bienvenidatxt.Name = "bienvenidatxt";
            this.bienvenidatxt.Size = new System.Drawing.Size(982, 78);
            this.bienvenidatxt.TabIndex = 33;
            this.bienvenidatxt.Text = "Bienvenido al Sistema SOCHEF";
            // 
            // submenuAdministracion
            // 
            this.submenuAdministracion.Controls.Add(this.categoriaB);
            this.submenuAdministracion.Controls.Add(this.button7);
            this.submenuAdministracion.Controls.Add(this.button8);
            this.submenuAdministracion.Location = new System.Drawing.Point(0, 429);
            this.submenuAdministracion.Name = "submenuAdministracion";
            this.submenuAdministracion.Size = new System.Drawing.Size(273, 178);
            this.submenuAdministracion.TabIndex = 31;
            this.submenuAdministracion.Visible = false;
            // 
            // categoriaB
            // 
            this.categoriaB.FlatAppearance.BorderSize = 0;
            this.categoriaB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.categoriaB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriaB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.categoriaB.Image = ((System.Drawing.Image)(resources.GetObject("categoriaB.Image")));
            this.categoriaB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoriaB.Location = new System.Drawing.Point(1, 126);
            this.categoriaB.Name = "categoriaB";
            this.categoriaB.Size = new System.Drawing.Size(270, 52);
            this.categoriaB.TabIndex = 33;
            this.categoriaB.Text = "Categorías";
            this.categoriaB.UseVisualStyleBackColor = true;
            this.categoriaB.Click += new System.EventHandler(this.CategoriaB_Click);
            this.categoriaB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CategoriaB_MouseMove);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(270, 52);
            this.button7.TabIndex = 4;
            this.button7.Text = "Usuarios";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click_1);
            this.button7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button7_MouseMove);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 61);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(270, 52);
            this.button8.TabIndex = 5;
            this.button8.Text = "Parámetros";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click_1);
            this.button8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button8_MouseMove);
            // 
            // submenuAyuda
            // 
            this.submenuAyuda.Controls.Add(this.infoButton);
            this.submenuAyuda.Controls.Add(this.manuaButton);
            this.submenuAyuda.Location = new System.Drawing.Point(1, 485);
            this.submenuAyuda.Name = "submenuAyuda";
            this.submenuAyuda.Size = new System.Drawing.Size(273, 121);
            this.submenuAyuda.TabIndex = 32;
            this.submenuAyuda.Visible = false;
            // 
            // infoButton
            // 
            this.infoButton.FlatAppearance.BorderSize = 0;
            this.infoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.infoButton.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.Image")));
            this.infoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoButton.Location = new System.Drawing.Point(-3, 61);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(286, 52);
            this.infoButton.TabIndex = 6;
            this.infoButton.Text = "Acerca de Sochef";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // manuaButton
            // 
            this.manuaButton.FlatAppearance.BorderSize = 0;
            this.manuaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.manuaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manuaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manuaButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.manuaButton.Image = ((System.Drawing.Image)(resources.GetObject("manuaButton.Image")));
            this.manuaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manuaButton.Location = new System.Drawing.Point(-3, 3);
            this.manuaButton.Name = "manuaButton";
            this.manuaButton.Size = new System.Drawing.Size(286, 52);
            this.manuaButton.TabIndex = 4;
            this.manuaButton.Text = "Manual de Usuario";
            this.manuaButton.UseVisualStyleBackColor = true;
            this.manuaButton.Click += new System.EventHandler(this.ManuaButton_Click_1);
            // 
            // submenuUsuarios
            // 
            this.submenuUsuarios.Controls.Add(this.misDatosButton);
            this.submenuUsuarios.Controls.Add(this.gestionarUsuarioButton);
            this.submenuUsuarios.Controls.Add(this.eliminarUsuarioButton);
            this.submenuUsuarios.Controls.Add(this.modificarUsuarioButton);
            this.submenuUsuarios.Controls.Add(this.agregarUsuarioButton);
            this.submenuUsuarios.Location = new System.Drawing.Point(274, 429);
            this.submenuUsuarios.Name = "submenuUsuarios";
            this.submenuUsuarios.Size = new System.Drawing.Size(273, 290);
            this.submenuUsuarios.TabIndex = 7;
            this.submenuUsuarios.Visible = false;
            // 
            // misDatosButton
            // 
            this.misDatosButton.FlatAppearance.BorderSize = 0;
            this.misDatosButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.misDatosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.misDatosButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.misDatosButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.misDatosButton.Image = ((System.Drawing.Image)(resources.GetObject("misDatosButton.Image")));
            this.misDatosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.misDatosButton.Location = new System.Drawing.Point(-3, 177);
            this.misDatosButton.Name = "misDatosButton";
            this.misDatosButton.Size = new System.Drawing.Size(286, 52);
            this.misDatosButton.TabIndex = 7;
            this.misDatosButton.Text = "Modificar Mis Datos";
            this.misDatosButton.UseVisualStyleBackColor = true;
            this.misDatosButton.Click += new System.EventHandler(this.MisDatosButton_Click);
            // 
            // gestionarUsuarioButton
            // 
            this.gestionarUsuarioButton.FlatAppearance.BorderSize = 0;
            this.gestionarUsuarioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.gestionarUsuarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestionarUsuarioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionarUsuarioButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gestionarUsuarioButton.Image = ((System.Drawing.Image)(resources.GetObject("gestionarUsuarioButton.Image")));
            this.gestionarUsuarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gestionarUsuarioButton.Location = new System.Drawing.Point(-3, 61);
            this.gestionarUsuarioButton.Name = "gestionarUsuarioButton";
            this.gestionarUsuarioButton.Size = new System.Drawing.Size(286, 52);
            this.gestionarUsuarioButton.TabIndex = 6;
            this.gestionarUsuarioButton.Text = "Ver usuarios";
            this.gestionarUsuarioButton.UseVisualStyleBackColor = true;
            this.gestionarUsuarioButton.Click += new System.EventHandler(this.Button15_Click);
            // 
            // eliminarUsuarioButton
            // 
            this.eliminarUsuarioButton.FlatAppearance.BorderSize = 0;
            this.eliminarUsuarioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.eliminarUsuarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarUsuarioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarUsuarioButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.eliminarUsuarioButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarUsuarioButton.Image")));
            this.eliminarUsuarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarUsuarioButton.Location = new System.Drawing.Point(-3, 235);
            this.eliminarUsuarioButton.Name = "eliminarUsuarioButton";
            this.eliminarUsuarioButton.Size = new System.Drawing.Size(286, 52);
            this.eliminarUsuarioButton.TabIndex = 4;
            this.eliminarUsuarioButton.Text = "Eliminar Usuario";
            this.eliminarUsuarioButton.UseVisualStyleBackColor = true;
            this.eliminarUsuarioButton.Click += new System.EventHandler(this.Button16_Click);
            // 
            // modificarUsuarioButton
            // 
            this.modificarUsuarioButton.FlatAppearance.BorderSize = 0;
            this.modificarUsuarioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.modificarUsuarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarUsuarioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarUsuarioButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.modificarUsuarioButton.Image = ((System.Drawing.Image)(resources.GetObject("modificarUsuarioButton.Image")));
            this.modificarUsuarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarUsuarioButton.Location = new System.Drawing.Point(-3, 119);
            this.modificarUsuarioButton.Name = "modificarUsuarioButton";
            this.modificarUsuarioButton.Size = new System.Drawing.Size(286, 52);
            this.modificarUsuarioButton.TabIndex = 4;
            this.modificarUsuarioButton.Text = "Modificar Rol Usuario";
            this.modificarUsuarioButton.UseVisualStyleBackColor = true;
            this.modificarUsuarioButton.Click += new System.EventHandler(this.Button17_Click);
            // 
            // agregarUsuarioButton
            // 
            this.agregarUsuarioButton.FlatAppearance.BorderSize = 0;
            this.agregarUsuarioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.agregarUsuarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarUsuarioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarUsuarioButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.agregarUsuarioButton.Image = ((System.Drawing.Image)(resources.GetObject("agregarUsuarioButton.Image")));
            this.agregarUsuarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarUsuarioButton.Location = new System.Drawing.Point(-3, 3);
            this.agregarUsuarioButton.Name = "agregarUsuarioButton";
            this.agregarUsuarioButton.Size = new System.Drawing.Size(286, 52);
            this.agregarUsuarioButton.TabIndex = 4;
            this.agregarUsuarioButton.Text = "Agregar Usuario";
            this.agregarUsuarioButton.UseVisualStyleBackColor = true;
            this.agregarUsuarioButton.Click += new System.EventHandler(this.Button18_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFecha.Location = new System.Drawing.Point(318, 343);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(516, 40);
            this.lblFecha.TabIndex = 30;
            this.lblFecha.Text = "Miercoles, 10  noviembre  2017";
            this.lblFecha.Click += new System.EventHandler(this.LblFecha_Click);
            // 
            // lblhora
            // 
            this.lblhora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Century Gothic", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblhora.Location = new System.Drawing.Point(340, 214);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(467, 129);
            this.lblhora.TabIndex = 29;
            this.lblhora.Text = "10:59:58";
            this.lblhora.Click += new System.EventHandler(this.Lblhora_Click);
            // 
            // submenuEstadisticas
            // 
            this.submenuEstadisticas.Controls.Add(this.ventasPeriodoButton);
            this.submenuEstadisticas.Location = new System.Drawing.Point(0, 373);
            this.submenuEstadisticas.Name = "submenuEstadisticas";
            this.submenuEstadisticas.Size = new System.Drawing.Size(282, 59);
            this.submenuEstadisticas.TabIndex = 8;
            this.submenuEstadisticas.Visible = false;
            // 
            // ventasPeriodoButton
            // 
            this.ventasPeriodoButton.FlatAppearance.BorderSize = 0;
            this.ventasPeriodoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.ventasPeriodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ventasPeriodoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasPeriodoButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ventasPeriodoButton.Image = ((System.Drawing.Image)(resources.GetObject("ventasPeriodoButton.Image")));
            this.ventasPeriodoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ventasPeriodoButton.Location = new System.Drawing.Point(0, 3);
            this.ventasPeriodoButton.Name = "ventasPeriodoButton";
            this.ventasPeriodoButton.Size = new System.Drawing.Size(286, 52);
            this.ventasPeriodoButton.TabIndex = 4;
            this.ventasPeriodoButton.Text = "Resumen de Ventas";
            this.ventasPeriodoButton.UseVisualStyleBackColor = true;
            this.ventasPeriodoButton.Click += new System.EventHandler(this.VentasPeriodoButton_Click);
            // 
            // submenuEstimados
            // 
            this.submenuEstimados.Controls.Add(this.revisarProformaButton);
            this.submenuEstimados.Controls.Add(this.anularProformaButton);
            this.submenuEstimados.Controls.Add(this.nuevaProformaButton);
            this.submenuEstimados.Location = new System.Drawing.Point(0, 315);
            this.submenuEstimados.Name = "submenuEstimados";
            this.submenuEstimados.Size = new System.Drawing.Size(273, 171);
            this.submenuEstimados.TabIndex = 4;
            this.submenuEstimados.Visible = false;
            // 
            // revisarProformaButton
            // 
            this.revisarProformaButton.FlatAppearance.BorderSize = 0;
            this.revisarProformaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.revisarProformaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revisarProformaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revisarProformaButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.revisarProformaButton.Image = ((System.Drawing.Image)(resources.GetObject("revisarProformaButton.Image")));
            this.revisarProformaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.revisarProformaButton.Location = new System.Drawing.Point(0, 61);
            this.revisarProformaButton.Name = "revisarProformaButton";
            this.revisarProformaButton.Size = new System.Drawing.Size(286, 52);
            this.revisarProformaButton.TabIndex = 5;
            this.revisarProformaButton.Text = "Revisar Proforma";
            this.revisarProformaButton.UseVisualStyleBackColor = true;
            this.revisarProformaButton.Click += new System.EventHandler(this.RevisarProformaButton_Click);
            // 
            // anularProformaButton
            // 
            this.anularProformaButton.FlatAppearance.BorderSize = 0;
            this.anularProformaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.anularProformaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anularProformaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anularProformaButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.anularProformaButton.Image = ((System.Drawing.Image)(resources.GetObject("anularProformaButton.Image")));
            this.anularProformaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anularProformaButton.Location = new System.Drawing.Point(0, 119);
            this.anularProformaButton.Name = "anularProformaButton";
            this.anularProformaButton.Size = new System.Drawing.Size(286, 52);
            this.anularProformaButton.TabIndex = 4;
            this.anularProformaButton.Text = "Anular Proforma";
            this.anularProformaButton.UseVisualStyleBackColor = true;
            this.anularProformaButton.Click += new System.EventHandler(this.AnularProformaButton_Click);
            // 
            // nuevaProformaButton
            // 
            this.nuevaProformaButton.FlatAppearance.BorderSize = 0;
            this.nuevaProformaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.nuevaProformaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevaProformaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaProformaButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nuevaProformaButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevaProformaButton.Image")));
            this.nuevaProformaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevaProformaButton.Location = new System.Drawing.Point(0, 3);
            this.nuevaProformaButton.Name = "nuevaProformaButton";
            this.nuevaProformaButton.Size = new System.Drawing.Size(286, 52);
            this.nuevaProformaButton.TabIndex = 4;
            this.nuevaProformaButton.Text = "Nueva Proforma";
            this.nuevaProformaButton.UseVisualStyleBackColor = true;
            this.nuevaProformaButton.Click += new System.EventHandler(this.NuevaProformaButton_Click);
            // 
            // submenuProveedores
            // 
            this.submenuProveedores.Controls.Add(this.consultarProveedorButton);
            this.submenuProveedores.Controls.Add(this.eliminarProveedorButton);
            this.submenuProveedores.Controls.Add(this.modificarProveedorButton);
            this.submenuProveedores.Controls.Add(this.agregarProveedorButton);
            this.submenuProveedores.Location = new System.Drawing.Point(0, 257);
            this.submenuProveedores.Name = "submenuProveedores";
            this.submenuProveedores.Size = new System.Drawing.Size(273, 233);
            this.submenuProveedores.TabIndex = 1;
            this.submenuProveedores.Visible = false;
            // 
            // consultarProveedorButton
            // 
            this.consultarProveedorButton.FlatAppearance.BorderSize = 0;
            this.consultarProveedorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.consultarProveedorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarProveedorButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarProveedorButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.consultarProveedorButton.Image = ((System.Drawing.Image)(resources.GetObject("consultarProveedorButton.Image")));
            this.consultarProveedorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultarProveedorButton.Location = new System.Drawing.Point(0, 61);
            this.consultarProveedorButton.Name = "consultarProveedorButton";
            this.consultarProveedorButton.Size = new System.Drawing.Size(286, 52);
            this.consultarProveedorButton.TabIndex = 6;
            this.consultarProveedorButton.Text = "Consultar Proveedor";
            this.consultarProveedorButton.UseVisualStyleBackColor = true;
            this.consultarProveedorButton.Click += new System.EventHandler(this.Button5_Click_1);
            // 
            // eliminarProveedorButton
            // 
            this.eliminarProveedorButton.FlatAppearance.BorderSize = 0;
            this.eliminarProveedorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.eliminarProveedorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarProveedorButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarProveedorButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.eliminarProveedorButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarProveedorButton.Image")));
            this.eliminarProveedorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarProveedorButton.Location = new System.Drawing.Point(0, 178);
            this.eliminarProveedorButton.Name = "eliminarProveedorButton";
            this.eliminarProveedorButton.Size = new System.Drawing.Size(286, 52);
            this.eliminarProveedorButton.TabIndex = 4;
            this.eliminarProveedorButton.Text = "Cambiar Estado Proveedor";
            this.eliminarProveedorButton.UseVisualStyleBackColor = true;
            this.eliminarProveedorButton.Click += new System.EventHandler(this.EliminarProveedorButton_Click);
            // 
            // modificarProveedorButton
            // 
            this.modificarProveedorButton.FlatAppearance.BorderSize = 0;
            this.modificarProveedorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.modificarProveedorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarProveedorButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarProveedorButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.modificarProveedorButton.Image = ((System.Drawing.Image)(resources.GetObject("modificarProveedorButton.Image")));
            this.modificarProveedorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarProveedorButton.Location = new System.Drawing.Point(0, 119);
            this.modificarProveedorButton.Name = "modificarProveedorButton";
            this.modificarProveedorButton.Size = new System.Drawing.Size(286, 52);
            this.modificarProveedorButton.TabIndex = 4;
            this.modificarProveedorButton.Text = "Modificar Proveedor";
            this.modificarProveedorButton.UseVisualStyleBackColor = true;
            this.modificarProveedorButton.Click += new System.EventHandler(this.ModificarProveedorButton_Click);
            // 
            // agregarProveedorButton
            // 
            this.agregarProveedorButton.FlatAppearance.BorderSize = 0;
            this.agregarProveedorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.agregarProveedorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarProveedorButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarProveedorButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.agregarProveedorButton.Image = ((System.Drawing.Image)(resources.GetObject("agregarProveedorButton.Image")));
            this.agregarProveedorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarProveedorButton.Location = new System.Drawing.Point(3, 3);
            this.agregarProveedorButton.Name = "agregarProveedorButton";
            this.agregarProveedorButton.Size = new System.Drawing.Size(286, 52);
            this.agregarProveedorButton.TabIndex = 4;
            this.agregarProveedorButton.Text = "Agregar Proveedor";
            this.agregarProveedorButton.UseVisualStyleBackColor = true;
            this.agregarProveedorButton.Click += new System.EventHandler(this.Button11_Click);
            // 
            // submenuClientes
            // 
            this.submenuClientes.Controls.Add(this.consultarClienteButton);
            this.submenuClientes.Controls.Add(this.eliminarClienteButton);
            this.submenuClientes.Controls.Add(this.modificarClienteButton);
            this.submenuClientes.Controls.Add(this.agregarClienteButton);
            this.submenuClientes.Location = new System.Drawing.Point(3, 194);
            this.submenuClientes.Name = "submenuClientes";
            this.submenuClientes.Size = new System.Drawing.Size(273, 232);
            this.submenuClientes.TabIndex = 0;
            this.submenuClientes.Visible = false;
            this.submenuClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // consultarClienteButton
            // 
            this.consultarClienteButton.FlatAppearance.BorderSize = 0;
            this.consultarClienteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.consultarClienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarClienteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarClienteButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.consultarClienteButton.Image = ((System.Drawing.Image)(resources.GetObject("consultarClienteButton.Image")));
            this.consultarClienteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultarClienteButton.Location = new System.Drawing.Point(-3, 61);
            this.consultarClienteButton.Name = "consultarClienteButton";
            this.consultarClienteButton.Size = new System.Drawing.Size(286, 52);
            this.consultarClienteButton.TabIndex = 6;
            this.consultarClienteButton.Text = "Consultar Cliente";
            this.consultarClienteButton.UseVisualStyleBackColor = true;
            this.consultarClienteButton.Click += new System.EventHandler(this.Button6_Click_1);
            // 
            // eliminarClienteButton
            // 
            this.eliminarClienteButton.FlatAppearance.BorderSize = 0;
            this.eliminarClienteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.eliminarClienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarClienteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarClienteButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.eliminarClienteButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarClienteButton.Image")));
            this.eliminarClienteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarClienteButton.Location = new System.Drawing.Point(0, 177);
            this.eliminarClienteButton.Name = "eliminarClienteButton";
            this.eliminarClienteButton.Size = new System.Drawing.Size(286, 52);
            this.eliminarClienteButton.TabIndex = 4;
            this.eliminarClienteButton.Text = "Cambio Estado Cliente";
            this.eliminarClienteButton.UseVisualStyleBackColor = true;
            this.eliminarClienteButton.Click += new System.EventHandler(this.Button9_Click);
            // 
            // modificarClienteButton
            // 
            this.modificarClienteButton.FlatAppearance.BorderSize = 0;
            this.modificarClienteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.modificarClienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarClienteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarClienteButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.modificarClienteButton.Image = ((System.Drawing.Image)(resources.GetObject("modificarClienteButton.Image")));
            this.modificarClienteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarClienteButton.Location = new System.Drawing.Point(-3, 119);
            this.modificarClienteButton.Name = "modificarClienteButton";
            this.modificarClienteButton.Size = new System.Drawing.Size(286, 52);
            this.modificarClienteButton.TabIndex = 4;
            this.modificarClienteButton.Text = "Modificar Cliente";
            this.modificarClienteButton.UseVisualStyleBackColor = true;
            this.modificarClienteButton.Click += new System.EventHandler(this.Button8_Click);
            // 
            // agregarClienteButton
            // 
            this.agregarClienteButton.FlatAppearance.BorderSize = 0;
            this.agregarClienteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.agregarClienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarClienteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarClienteButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.agregarClienteButton.Image = ((System.Drawing.Image)(resources.GetObject("agregarClienteButton.Image")));
            this.agregarClienteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarClienteButton.Location = new System.Drawing.Point(-3, 3);
            this.agregarClienteButton.Name = "agregarClienteButton";
            this.agregarClienteButton.Size = new System.Drawing.Size(286, 52);
            this.agregarClienteButton.TabIndex = 4;
            this.agregarClienteButton.Text = "Agregar Cliente";
            this.agregarClienteButton.UseVisualStyleBackColor = true;
            this.agregarClienteButton.Click += new System.EventHandler(this.Button7_Click);
            // 
            // submenuFacturacion
            // 
            this.submenuFacturacion.Controls.Add(this.revisarFacturaButton);
            this.submenuFacturacion.Controls.Add(this.anularFacturaButton);
            this.submenuFacturacion.Controls.Add(this.nuevaFacturaButton);
            this.submenuFacturacion.Location = new System.Drawing.Point(0, 141);
            this.submenuFacturacion.Name = "submenuFacturacion";
            this.submenuFacturacion.Size = new System.Drawing.Size(273, 171);
            this.submenuFacturacion.TabIndex = 3;
            this.submenuFacturacion.Visible = false;
            // 
            // revisarFacturaButton
            // 
            this.revisarFacturaButton.FlatAppearance.BorderSize = 0;
            this.revisarFacturaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.revisarFacturaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revisarFacturaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revisarFacturaButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.revisarFacturaButton.Image = ((System.Drawing.Image)(resources.GetObject("revisarFacturaButton.Image")));
            this.revisarFacturaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.revisarFacturaButton.Location = new System.Drawing.Point(0, 61);
            this.revisarFacturaButton.Name = "revisarFacturaButton";
            this.revisarFacturaButton.Size = new System.Drawing.Size(286, 52);
            this.revisarFacturaButton.TabIndex = 5;
            this.revisarFacturaButton.Text = "Revisar Factura";
            this.revisarFacturaButton.UseVisualStyleBackColor = true;
            this.revisarFacturaButton.Click += new System.EventHandler(this.RevisarFacturaButton_Click);
            // 
            // anularFacturaButton
            // 
            this.anularFacturaButton.FlatAppearance.BorderSize = 0;
            this.anularFacturaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.anularFacturaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anularFacturaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anularFacturaButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.anularFacturaButton.Image = ((System.Drawing.Image)(resources.GetObject("anularFacturaButton.Image")));
            this.anularFacturaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anularFacturaButton.Location = new System.Drawing.Point(0, 119);
            this.anularFacturaButton.Name = "anularFacturaButton";
            this.anularFacturaButton.Size = new System.Drawing.Size(286, 52);
            this.anularFacturaButton.TabIndex = 4;
            this.anularFacturaButton.Text = "Anular Factura";
            this.anularFacturaButton.UseVisualStyleBackColor = true;
            this.anularFacturaButton.Click += new System.EventHandler(this.AnularFacturaButton_Click);
            // 
            // nuevaFacturaButton
            // 
            this.nuevaFacturaButton.FlatAppearance.BorderSize = 0;
            this.nuevaFacturaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.nuevaFacturaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevaFacturaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaFacturaButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nuevaFacturaButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevaFacturaButton.Image")));
            this.nuevaFacturaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevaFacturaButton.Location = new System.Drawing.Point(0, 3);
            this.nuevaFacturaButton.Name = "nuevaFacturaButton";
            this.nuevaFacturaButton.Size = new System.Drawing.Size(286, 52);
            this.nuevaFacturaButton.TabIndex = 4;
            this.nuevaFacturaButton.Text = "Nueva Factura";
            this.nuevaFacturaButton.UseVisualStyleBackColor = true;
            this.nuevaFacturaButton.Click += new System.EventHandler(this.NuevaFacturaButton_Click);
            // 
            // submenuInventario
            // 
            this.submenuInventario.Controls.Add(this.consultarProductoButton);
            this.submenuInventario.Controls.Add(this.eliminarProductoButton);
            this.submenuInventario.Controls.Add(this.editarProductoButton);
            this.submenuInventario.Controls.Add(this.nuevoProductoButton);
            this.submenuInventario.Location = new System.Drawing.Point(3, 83);
            this.submenuInventario.Name = "submenuInventario";
            this.submenuInventario.Size = new System.Drawing.Size(273, 227);
            this.submenuInventario.TabIndex = 2;
            this.submenuInventario.Visible = false;
            // 
            // consultarProductoButton
            // 
            this.consultarProductoButton.FlatAppearance.BorderSize = 0;
            this.consultarProductoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.consultarProductoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarProductoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarProductoButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.consultarProductoButton.Image = ((System.Drawing.Image)(resources.GetObject("consultarProductoButton.Image")));
            this.consultarProductoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultarProductoButton.Location = new System.Drawing.Point(0, 61);
            this.consultarProductoButton.Name = "consultarProductoButton";
            this.consultarProductoButton.Size = new System.Drawing.Size(286, 52);
            this.consultarProductoButton.TabIndex = 5;
            this.consultarProductoButton.Text = "Consultar Producto";
            this.consultarProductoButton.UseVisualStyleBackColor = true;
            this.consultarProductoButton.Click += new System.EventHandler(this.ConsultarProductoButton_Click);
            // 
            // eliminarProductoButton
            // 
            this.eliminarProductoButton.FlatAppearance.BorderSize = 0;
            this.eliminarProductoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.eliminarProductoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarProductoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarProductoButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.eliminarProductoButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarProductoButton.Image")));
            this.eliminarProductoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarProductoButton.Location = new System.Drawing.Point(0, 175);
            this.eliminarProductoButton.Name = "eliminarProductoButton";
            this.eliminarProductoButton.Size = new System.Drawing.Size(286, 52);
            this.eliminarProductoButton.TabIndex = 4;
            this.eliminarProductoButton.Text = "Cambiar Estado Producto";
            this.eliminarProductoButton.UseVisualStyleBackColor = true;
            this.eliminarProductoButton.Click += new System.EventHandler(this.EliminarProductoButton_Click);
            // 
            // editarProductoButton
            // 
            this.editarProductoButton.FlatAppearance.BorderSize = 0;
            this.editarProductoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.editarProductoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarProductoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarProductoButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.editarProductoButton.Image = ((System.Drawing.Image)(resources.GetObject("editarProductoButton.Image")));
            this.editarProductoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editarProductoButton.Location = new System.Drawing.Point(0, 119);
            this.editarProductoButton.Name = "editarProductoButton";
            this.editarProductoButton.Size = new System.Drawing.Size(286, 52);
            this.editarProductoButton.TabIndex = 4;
            this.editarProductoButton.Text = "Modificar Producto";
            this.editarProductoButton.UseVisualStyleBackColor = true;
            this.editarProductoButton.Click += new System.EventHandler(this.EditarProductoButton_Click);
            // 
            // nuevoProductoButton
            // 
            this.nuevoProductoButton.FlatAppearance.BorderSize = 0;
            this.nuevoProductoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.nuevoProductoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoProductoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoProductoButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nuevoProductoButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevoProductoButton.Image")));
            this.nuevoProductoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevoProductoButton.Location = new System.Drawing.Point(0, 3);
            this.nuevoProductoButton.Name = "nuevoProductoButton";
            this.nuevoProductoButton.Size = new System.Drawing.Size(286, 52);
            this.nuevoProductoButton.TabIndex = 4;
            this.nuevoProductoButton.Text = "Nuevo Producto";
            this.nuevoProductoButton.UseVisualStyleBackColor = true;
            this.nuevoProductoButton.Click += new System.EventHandler(this.NuevoProductoButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // salirButton
            // 
            this.salirButton.FlatAppearance.BorderSize = 0;
            this.salirButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.salirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.salirButton.Image = ((System.Drawing.Image)(resources.GetObject("salirButton.Image")));
            this.salirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salirButton.Location = new System.Drawing.Point(0, 695);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(280, 52);
            this.salirButton.TabIndex = 33;
            this.salirButton.Text = "Salir del Sistema";
            this.salirButton.UseVisualStyleBackColor = true;
            this.salirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // InterfazInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazInicial";
            this.Text = "InterazInicial";
            this.panelVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrMenu)).EndInit();
            this.contenedor.ResumeLayout(false);
            this.contenedor.PerformLayout();
            this.submenuAdministracion.ResumeLayout(false);
            this.submenuAyuda.ResumeLayout(false);
            this.submenuUsuarios.ResumeLayout(false);
            this.submenuEstadisticas.ResumeLayout(false);
            this.submenuEstimados.ResumeLayout(false);
            this.submenuProveedores.ResumeLayout(false);
            this.submenuClientes.ResumeLayout(false);
            this.submenuFacturacion.ResumeLayout(false);
            this.submenuInventario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVertical;
        private System.Windows.Forms.PictureBox pctrLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctrMenu;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Button inventarioButton;
        private System.Windows.Forms.Button estadisticasButton;
        private System.Windows.Forms.Button estimadosButton;
        private System.Windows.Forms.Button proveedoresButton;
        private System.Windows.Forms.Button clientesButton;
        private System.Windows.Forms.Button facturacionButton;
        private System.Windows.Forms.Button eliminarClienteButton;
        private System.Windows.Forms.Button modificarClienteButton;
        private System.Windows.Forms.Panel submenuProveedores;
        private System.Windows.Forms.Button eliminarProveedorButton;
        private System.Windows.Forms.Button modificarProveedorButton;
        private System.Windows.Forms.Button agregarProveedorButton;
        private System.Windows.Forms.Panel submenuInventario;
        private System.Windows.Forms.Button eliminarProductoButton;
        private System.Windows.Forms.Button editarProductoButton;
        private System.Windows.Forms.Button nuevoProductoButton;
        private System.Windows.Forms.Button consultarProductoButton;
        private System.Windows.Forms.Button consultarProveedorButton;
        private System.Windows.Forms.Button consultarClienteButton;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel submenuFacturacion;
        private System.Windows.Forms.Button revisarFacturaButton;
        private System.Windows.Forms.Button anularFacturaButton;
        private System.Windows.Forms.Button nuevaFacturaButton;
        private System.Windows.Forms.Panel submenuEstimados;
        private System.Windows.Forms.Button revisarProformaButton;
        private System.Windows.Forms.Button anularProformaButton;
        private System.Windows.Forms.Button nuevaProformaButton;
        private System.Windows.Forms.Panel submenuUsuarios;
        private System.Windows.Forms.Button gestionarUsuarioButton;
        private System.Windows.Forms.Button eliminarUsuarioButton;
        private System.Windows.Forms.Button modificarUsuarioButton;
        private System.Windows.Forms.Button agregarUsuarioButton;
        private System.Windows.Forms.Panel submenuEstadisticas;
        private System.Windows.Forms.Button ventasPeriodoButton;
        public System.Windows.Forms.Panel submenuClientes;
        public System.Windows.Forms.Button agregarClienteButton;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button administracionButton;
        private System.Windows.Forms.Panel submenuAdministracion;
        private System.Windows.Forms.Button ayudaButton;
        private System.Windows.Forms.Panel submenuAyuda;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button manuaButton;
        private System.Windows.Forms.Button categoriaB;
        private System.Windows.Forms.Button misDatosButton;
        private System.Windows.Forms.Label bienvenidatxt;
        private System.Windows.Forms.Button salirButton;
    }
}