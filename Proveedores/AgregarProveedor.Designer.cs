namespace sistema_de_facturacion.Proveedores
{
    partial class AgregarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProveedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelIngreso = new System.Windows.Forms.Label();
            this.minimizarButton = new System.Windows.Forms.PictureBox();
            this.maximizarButton = new System.Windows.Forms.PictureBox();
            this.cerrarButton = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTelefonoContacto = new System.Windows.Forms.Label();
            this.labelContacto = new System.Windows.Forms.Label();
            this.ciudadField = new System.Windows.Forms.TextBox();
            this.direccionField = new System.Windows.Forms.TextBox();
            this.telefonoField = new System.Windows.Forms.TextBox();
            this.nombreField = new System.Windows.Forms.TextBox();
            this.labelRUC = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.RUCField = new System.Windows.Forms.TextBox();
            this.correoField = new System.Windows.Forms.TextBox();
            this.contactoField = new System.Windows.Forms.TextBox();
            this.telefonoCField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inactivo = new System.Windows.Forms.RadioButton();
            this.activo = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.registrarButton = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarButton)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(196)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.labelIngreso);
            this.panel1.Controls.Add(this.minimizarButton);
            this.panel1.Controls.Add(this.maximizarButton);
            this.panel1.Controls.Add(this.cerrarButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 50);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // labelIngreso
            // 
            this.labelIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIngreso.AutoSize = true;
            this.labelIngreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngreso.Location = new System.Drawing.Point(291, 16);
            this.labelIngreso.Name = "labelIngreso";
            this.labelIngreso.Size = new System.Drawing.Size(186, 18);
            this.labelIngreso.TabIndex = 8;
            this.labelIngreso.Text = "Registro de Proveedores";
            // 
            // minimizarButton
            // 
            this.minimizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizarButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizarButton.Image")));
            this.minimizarButton.Location = new System.Drawing.Point(635, 12);
            this.minimizarButton.Name = "minimizarButton";
            this.minimizarButton.Size = new System.Drawing.Size(24, 24);
            this.minimizarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizarButton.TabIndex = 5;
            this.minimizarButton.TabStop = false;
            this.minimizarButton.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // maximizarButton
            // 
            this.maximizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizarButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizarButton.Image")));
            this.maximizarButton.Location = new System.Drawing.Point(665, 12);
            this.maximizarButton.Name = "maximizarButton";
            this.maximizarButton.Size = new System.Drawing.Size(24, 24);
            this.maximizarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizarButton.TabIndex = 4;
            this.maximizarButton.TabStop = false;
            this.maximizarButton.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // cerrarButton
            // 
            this.cerrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarButton.Image = ((System.Drawing.Image)(resources.GetObject("cerrarButton.Image")));
            this.cerrarButton.Location = new System.Drawing.Point(695, 12);
            this.cerrarButton.Name = "cerrarButton";
            this.cerrarButton.Size = new System.Drawing.Size(24, 24);
            this.cerrarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarButton.TabIndex = 3;
            this.cerrarButton.TabStop = false;
            this.cerrarButton.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.125F));
            this.tableLayoutPanel1.Controls.Add(this.labelTelefonoContacto, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelContacto, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ciudadField, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.direccionField, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.telefonoField, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nombreField, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRUC, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTelefono, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelDireccion, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelCorreo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelCiudad, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.RUCField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.correoField, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.contactoField, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.telefonoCField, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 479);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labelTelefonoContacto
            // 
            this.labelTelefonoContacto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTelefonoContacto.AutoSize = true;
            this.labelTelefonoContacto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefonoContacto.Location = new System.Drawing.Point(14, 371);
            this.labelTelefonoContacto.Name = "labelTelefonoContacto";
            this.labelTelefonoContacto.Size = new System.Drawing.Size(154, 53);
            this.labelTelefonoContacto.TabIndex = 14;
            this.labelTelefonoContacto.Text = "Número telefónico de persona contacto:";
            this.labelTelefonoContacto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelContacto
            // 
            this.labelContacto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContacto.AutoSize = true;
            this.labelContacto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContacto.Location = new System.Drawing.Point(41, 323);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(100, 42);
            this.labelContacto.TabIndex = 12;
            this.labelContacto.Text = "Persona de contacto:";
            // 
            // ciudadField
            // 
            this.ciudadField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ciudadField.Location = new System.Drawing.Point(185, 228);
            this.ciudadField.MaxLength = 20;
            this.ciudadField.Name = "ciudadField";
            this.ciudadField.ShortcutsEnabled = false;
            this.ciudadField.Size = new System.Drawing.Size(544, 20);
            this.ciudadField.TabIndex = 10;
            this.ciudadField.Enter += new System.EventHandler(this.CiudadField_Enter);
            this.ciudadField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CiudadField_KeyPress);
            this.ciudadField.Leave += new System.EventHandler(this.CiudadField_Leave);
            // 
            // direccionField
            // 
            this.direccionField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.direccionField.Location = new System.Drawing.Point(185, 175);
            this.direccionField.MaxLength = 60;
            this.direccionField.Name = "direccionField";
            this.direccionField.ShortcutsEnabled = false;
            this.direccionField.Size = new System.Drawing.Size(544, 20);
            this.direccionField.TabIndex = 9;
            this.direccionField.Enter += new System.EventHandler(this.DireccionField_Enter);
            this.direccionField.Leave += new System.EventHandler(this.DireccionField_Leave);
            // 
            // telefonoField
            // 
            this.telefonoField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.telefonoField.Location = new System.Drawing.Point(185, 122);
            this.telefonoField.MaxLength = 15;
            this.telefonoField.Name = "telefonoField";
            this.telefonoField.ShortcutsEnabled = false;
            this.telefonoField.Size = new System.Drawing.Size(544, 20);
            this.telefonoField.TabIndex = 8;
            this.telefonoField.Enter += new System.EventHandler(this.TelefonoField_Enter);
            this.telefonoField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoField_KeyPress);
            this.telefonoField.Leave += new System.EventHandler(this.TelefonoField_Leave);
            // 
            // nombreField
            // 
            this.nombreField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreField.Location = new System.Drawing.Point(185, 69);
            this.nombreField.MaxLength = 40;
            this.nombreField.Name = "nombreField";
            this.nombreField.ShortcutsEnabled = false;
            this.nombreField.Size = new System.Drawing.Size(544, 20);
            this.nombreField.TabIndex = 7;
            this.nombreField.Enter += new System.EventHandler(this.NombreField_Enter);
            this.nombreField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreField_KeyPress);
            this.nombreField.Leave += new System.EventHandler(this.NombreField_Leave);
            // 
            // labelRUC
            // 
            this.labelRUC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRUC.AutoSize = true;
            this.labelRUC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRUC.Location = new System.Drawing.Point(67, 16);
            this.labelRUC.Name = "labelRUC";
            this.labelRUC.Size = new System.Drawing.Size(48, 21);
            this.labelRUC.TabIndex = 0;
            this.labelRUC.Text = "RUC:";
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(52, 69);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(77, 21);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(4, 122);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(174, 21);
            this.labelTelefono.TabIndex = 2;
            this.labelTelefono.Text = "Número de teléfono: ";
            // 
            // labelDireccion
            // 
            this.labelDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(34, 164);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(114, 42);
            this.labelDireccion.TabIndex = 3;
            this.labelDireccion.Text = "Dirección de instalaciones:";
            // 
            // labelCorreo
            // 
            this.labelCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(54, 228);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(73, 21);
            this.labelCorreo.TabIndex = 4;
            this.labelCorreo.Text = "Ciudad:";
            // 
            // labelCiudad
            // 
            this.labelCiudad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCiudad.Location = new System.Drawing.Point(12, 281);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(158, 21);
            this.labelCiudad.TabIndex = 5;
            this.labelCiudad.Text = "Correo Electrónico:";
            // 
            // RUCField
            // 
            this.RUCField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RUCField.Location = new System.Drawing.Point(185, 16);
            this.RUCField.MaxLength = 13;
            this.RUCField.Name = "RUCField";
            this.RUCField.ShortcutsEnabled = false;
            this.RUCField.Size = new System.Drawing.Size(544, 20);
            this.RUCField.TabIndex = 6;
            this.RUCField.Enter += new System.EventHandler(this.RUCField_Enter);
            this.RUCField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RUCField_KeyPress);
            this.RUCField.Leave += new System.EventHandler(this.RUCField_Leave);
            // 
            // correoField
            // 
            this.correoField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.correoField.Location = new System.Drawing.Point(185, 281);
            this.correoField.MaxLength = 50;
            this.correoField.Name = "correoField";
            this.correoField.ShortcutsEnabled = false;
            this.correoField.Size = new System.Drawing.Size(544, 20);
            this.correoField.TabIndex = 11;
            this.correoField.FontChanged += new System.EventHandler(this.CorreoField_FontChanged);
            this.correoField.Enter += new System.EventHandler(this.CorreoField_Enter);
            this.correoField.Leave += new System.EventHandler(this.CorreoField_Leave);
            // 
            // contactoField
            // 
            this.contactoField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.contactoField.Location = new System.Drawing.Point(185, 334);
            this.contactoField.MaxLength = 80;
            this.contactoField.Name = "contactoField";
            this.contactoField.ShortcutsEnabled = false;
            this.contactoField.Size = new System.Drawing.Size(544, 20);
            this.contactoField.TabIndex = 13;
            this.contactoField.Enter += new System.EventHandler(this.ContactoField_Enter);
            this.contactoField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactoField_KeyPress);
            this.contactoField.Leave += new System.EventHandler(this.ContactoField_Leave);
            // 
            // telefonoCField
            // 
            this.telefonoCField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.telefonoCField.Location = new System.Drawing.Point(185, 387);
            this.telefonoCField.MaxLength = 15;
            this.telefonoCField.Name = "telefonoCField";
            this.telefonoCField.ShortcutsEnabled = false;
            this.telefonoCField.Size = new System.Drawing.Size(544, 20);
            this.telefonoCField.TabIndex = 15;
            this.telefonoCField.Enter += new System.EventHandler(this.TelefonoCField_Enter);
            this.telefonoCField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoCField_KeyPress);
            this.telefonoCField.Leave += new System.EventHandler(this.TelefonoCField_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Estado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inactivo);
            this.groupBox1.Controls.Add(this.activo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(185, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 49);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // inactivo
            // 
            this.inactivo.AutoSize = true;
            this.inactivo.Location = new System.Drawing.Point(352, 18);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(63, 17);
            this.inactivo.TabIndex = 1;
            this.inactivo.TabStop = true;
            this.inactivo.Text = "Inactivo";
            this.inactivo.UseVisualStyleBackColor = true;
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Location = new System.Drawing.Point(87, 18);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(55, 17);
            this.activo.TabIndex = 0;
            this.activo.TabStop = true;
            this.activo.Text = "Activo";
            this.activo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.registrarButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.limpiarButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelarButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 529);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(732, 75);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // registrarButton
            // 
            this.registrarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarButton.Location = new System.Drawing.Point(42, 12);
            this.registrarButton.Name = "registrarButton";
            this.registrarButton.Size = new System.Drawing.Size(160, 50);
            this.registrarButton.TabIndex = 0;
            this.registrarButton.Text = "Registrar";
            this.registrarButton.UseVisualStyleBackColor = true;
            this.registrarButton.Click += new System.EventHandler(this.RegistrarButton_Click);
            // 
            // limpiarButton
            // 
            this.limpiarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.limpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarButton.Location = new System.Drawing.Point(286, 12);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(160, 50);
            this.limpiarButton.TabIndex = 1;
            this.limpiarButton.Text = "Limpiar Campos";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.Location = new System.Drawing.Point(530, 12);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(160, 50);
            this.cancelarButton.TabIndex = 2;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 604);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProveedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarButton)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimizarButton;
        private System.Windows.Forms.PictureBox maximizarButton;
        private System.Windows.Forms.PictureBox cerrarButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTelefonoContacto;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.TextBox ciudadField;
        private System.Windows.Forms.TextBox direccionField;
        private System.Windows.Forms.TextBox telefonoField;
        private System.Windows.Forms.TextBox nombreField;
        private System.Windows.Forms.Label labelRUC;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.TextBox RUCField;
        private System.Windows.Forms.TextBox correoField;
        private System.Windows.Forms.TextBox contactoField;
        private System.Windows.Forms.TextBox telefonoCField;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button registrarButton;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Label labelIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton inactivo;
        private System.Windows.Forms.RadioButton activo;
    }
}