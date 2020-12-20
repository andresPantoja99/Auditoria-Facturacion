namespace sistema_de_facturacion.Clientes
{
    partial class AgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelIngreso = new System.Windows.Forms.Label();
            this.minimizarButton = new System.Windows.Forms.PictureBox();
            this.maximizarButton = new System.Windows.Forms.PictureBox();
            this.cerrarButton = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.nombreField = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.juridica = new System.Windows.Forms.RadioButton();
            this.natural = new System.Windows.Forms.RadioButton();
            this.razonField = new System.Windows.Forms.TextBox();
            this.apellidoField = new System.Windows.Forms.TextBox();
            this.labelCRP = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.correoField = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.direccionField = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.telefonoField = new System.Windows.Forms.TextBox();
            this.labelRazon = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.ciudadField = new System.Windows.Forms.TextBox();
            this.labelHuella = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inactivo = new System.Windows.Forms.RadioButton();
            this.activo = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.siRadio = new System.Windows.Forms.RadioButton();
            this.noRadio = new System.Windows.Forms.RadioButton();
            this.huellaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cedulaR = new System.Windows.Forms.RadioButton();
            this.rucR = new System.Windows.Forms.RadioButton();
            this.pasaporteR = new System.Windows.Forms.RadioButton();
            this.cedulaField = new System.Windows.Forms.TextBox();
            this.rucField = new System.Windows.Forms.TextBox();
            this.pasaporteField = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.registrarButton = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarButton)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // labelIngreso
            // 
            this.labelIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIngreso.AutoSize = true;
            this.labelIngreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngreso.Location = new System.Drawing.Point(330, 16);
            this.labelIngreso.Name = "labelIngreso";
            this.labelIngreso.Size = new System.Drawing.Size(153, 18);
            this.labelIngreso.TabIndex = 7;
            this.labelIngreso.Text = "Registro de Clientes";
            this.labelIngreso.Click += new System.EventHandler(this.LabelIngreso_Click);
            // 
            // minimizarButton
            // 
            this.minimizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizarButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizarButton.Image")));
            this.minimizarButton.Location = new System.Drawing.Point(703, 12);
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
            this.maximizarButton.Location = new System.Drawing.Point(733, 12);
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
            this.cerrarButton.Location = new System.Drawing.Point(763, 12);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel1.Controls.Add(this.labelNombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCRP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCorreo, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.correoField, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelDireccion, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.direccionField, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelNumero, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.telefonoField, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelRazon, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelApellido, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ciudadField, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelHuella, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.1341F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.662835F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.088122F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 522);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(45, 88);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(101, 21);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre(s)*:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.32027F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.67973F));
            this.tableLayoutPanel3.Controls.Add(this.nombreField, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.razonField, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.apellidoField, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(195, 82);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(602, 123);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel3_Paint);
            // 
            // nombreField
            // 
            this.nombreField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreField.Location = new System.Drawing.Point(3, 10);
            this.nombreField.MaxLength = 50;
            this.nombreField.Name = "nombreField";
            this.nombreField.ShortcutsEnabled = false;
            this.nombreField.Size = new System.Drawing.Size(453, 20);
            this.nombreField.TabIndex = 0;
            this.nombreField.Enter += new System.EventHandler(this.NombreField_Enter);
            this.nombreField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreField_KeyPress);
            this.nombreField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NombreField_KeyUp);
            this.nombreField.Leave += new System.EventHandler(this.NombreField_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.juridica);
            this.groupBox1.Controls.Add(this.natural);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox1.Location = new System.Drawing.Point(462, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel3.SetRowSpan(this.groupBox1, 3);
            this.groupBox1.Size = new System.Drawing.Size(137, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo:";
            // 
            // juridica
            // 
            this.juridica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.juridica.AutoSize = true;
            this.juridica.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.juridica.Location = new System.Drawing.Point(6, 80);
            this.juridica.Name = "juridica";
            this.juridica.Size = new System.Drawing.Size(123, 21);
            this.juridica.TabIndex = 1;
            this.juridica.TabStop = true;
            this.juridica.Text = "Persona Jurídica";
            this.juridica.UseVisualStyleBackColor = true;
            this.juridica.CheckedChanged += new System.EventHandler(this.Juridica_CheckedChanged);
            // 
            // natural
            // 
            this.natural.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.natural.AutoSize = true;
            this.natural.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.natural.Location = new System.Drawing.Point(6, 17);
            this.natural.Name = "natural";
            this.natural.Size = new System.Drawing.Size(120, 21);
            this.natural.TabIndex = 0;
            this.natural.TabStop = true;
            this.natural.Text = "Persona Natural";
            this.natural.UseVisualStyleBackColor = true;
            this.natural.CheckedChanged += new System.EventHandler(this.Natural_CheckedChanged);
            // 
            // razonField
            // 
            this.razonField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.razonField.Location = new System.Drawing.Point(3, 92);
            this.razonField.MaxLength = 50;
            this.razonField.Name = "razonField";
            this.razonField.ShortcutsEnabled = false;
            this.razonField.Size = new System.Drawing.Size(453, 20);
            this.razonField.TabIndex = 1;
            this.razonField.Enter += new System.EventHandler(this.RazonField_Enter);
            this.razonField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RazonField_KeyPress);
            this.razonField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RazonField_KeyUp);
            this.razonField.Leave += new System.EventHandler(this.RazonField_Leave);
            // 
            // apellidoField
            // 
            this.apellidoField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.apellidoField.Location = new System.Drawing.Point(3, 51);
            this.apellidoField.MaxLength = 50;
            this.apellidoField.Name = "apellidoField";
            this.apellidoField.ShortcutsEnabled = false;
            this.apellidoField.Size = new System.Drawing.Size(453, 20);
            this.apellidoField.TabIndex = 3;
            this.apellidoField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidoField_KeyPress);
            this.apellidoField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ApellidoField_KeyUp);
            this.apellidoField.Leave += new System.EventHandler(this.ApellidoField_Leave);
            // 
            // labelCRP
            // 
            this.labelCRP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCRP.AutoSize = true;
            this.labelCRP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCRP.Location = new System.Drawing.Point(35, 29);
            this.labelCRP.Name = "labelCRP";
            this.labelCRP.Size = new System.Drawing.Size(121, 20);
            this.labelCRP.TabIndex = 0;
            this.labelCRP.Text = "Identificación*:";
            this.labelCRP.Click += new System.EventHandler(this.LabelCRP_Click);
            // 
            // labelCorreo
            // 
            this.labelCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(14, 327);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(164, 21);
            this.labelCorreo.TabIndex = 4;
            this.labelCorreo.Text = "Correo Electrónico*:";
            this.labelCorreo.Click += new System.EventHandler(this.Label5_Click);
            // 
            // correoField
            // 
            this.correoField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.correoField.Location = new System.Drawing.Point(195, 328);
            this.correoField.MaxLength = 50;
            this.correoField.Name = "correoField";
            this.correoField.ShortcutsEnabled = false;
            this.correoField.Size = new System.Drawing.Size(602, 20);
            this.correoField.TabIndex = 10;
            this.correoField.Enter += new System.EventHandler(this.CorreoField_Enter);
            this.correoField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CorreoField_KeyUp);
            this.correoField.Leave += new System.EventHandler(this.CorreoField_Leave);
            // 
            // labelDireccion
            // 
            this.labelDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(3, 275);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(186, 21);
            this.labelDireccion.TabIndex = 3;
            this.labelDireccion.Text = "Dirección Domiciliaria*:";
            // 
            // direccionField
            // 
            this.direccionField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.direccionField.Location = new System.Drawing.Point(195, 276);
            this.direccionField.MaxLength = 60;
            this.direccionField.Name = "direccionField";
            this.direccionField.ShortcutsEnabled = false;
            this.direccionField.Size = new System.Drawing.Size(602, 20);
            this.direccionField.TabIndex = 9;
            this.direccionField.Enter += new System.EventHandler(this.DireccionField_Enter);
            this.direccionField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DireccionField_KeyUp);
            this.direccionField.Leave += new System.EventHandler(this.DireccionField_Leave);
            // 
            // labelNumero
            // 
            this.labelNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.Location = new System.Drawing.Point(6, 223);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(180, 21);
            this.labelNumero.TabIndex = 2;
            this.labelNumero.Text = "Número de teléfono*: ";
            // 
            // telefonoField
            // 
            this.telefonoField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.telefonoField.Location = new System.Drawing.Point(195, 224);
            this.telefonoField.MaxLength = 15;
            this.telefonoField.Name = "telefonoField";
            this.telefonoField.ShortcutsEnabled = false;
            this.telefonoField.Size = new System.Drawing.Size(602, 20);
            this.telefonoField.TabIndex = 8;
            this.telefonoField.Enter += new System.EventHandler(this.TelefonoField_Enter);
            this.telefonoField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoField_KeyPress);
            this.telefonoField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TelefonoField_KeyUp);
            this.telefonoField.Leave += new System.EventHandler(this.TelefonoField_Leave);
            // 
            // labelRazon
            // 
            this.labelRazon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRazon.AutoSize = true;
            this.labelRazon.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelRazon.Location = new System.Drawing.Point(37, 171);
            this.labelRazon.Name = "labelRazon";
            this.labelRazon.Size = new System.Drawing.Size(117, 21);
            this.labelRazon.TabIndex = 12;
            this.labelRazon.Text = "Razón Social*:";
            // 
            // labelApellido
            // 
            this.labelApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelApellido.Location = new System.Drawing.Point(48, 127);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(96, 21);
            this.labelApellido.TabIndex = 14;
            this.labelApellido.Text = "Apellido(s):";
            // 
            // ciudadField
            // 
            this.ciudadField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ciudadField.Location = new System.Drawing.Point(195, 380);
            this.ciudadField.MaxLength = 20;
            this.ciudadField.Name = "ciudadField";
            this.ciudadField.Size = new System.Drawing.Size(602, 20);
            this.ciudadField.TabIndex = 16;
            this.ciudadField.Enter += new System.EventHandler(this.CiudadField_Enter);
            this.ciudadField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CiudadField_KeyPress);
            this.ciudadField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CiudadField_KeyUp);
            this.ciudadField.Leave += new System.EventHandler(this.CiudadField_Leave);
            // 
            // labelHuella
            // 
            this.labelHuella.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHuella.AutoSize = true;
            this.labelHuella.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHuella.Location = new System.Drawing.Point(32, 484);
            this.labelHuella.Name = "labelHuella";
            this.labelHuella.Size = new System.Drawing.Size(128, 21);
            this.labelHuella.TabIndex = 5;
            this.labelHuella.Text = "Huella Dactilar:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Estado:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inactivo);
            this.groupBox2.Controls.Add(this.activo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(195, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 46);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // inactivo
            // 
            this.inactivo.AutoSize = true;
            this.inactivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactivo.Location = new System.Drawing.Point(376, 14);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(89, 24);
            this.inactivo.TabIndex = 1;
            this.inactivo.TabStop = true;
            this.inactivo.Text = "Inactivo";
            this.inactivo.UseVisualStyleBackColor = true;
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activo.Location = new System.Drawing.Point(86, 16);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(76, 24);
            this.activo.TabIndex = 0;
            this.activo.TabStop = true;
            this.activo.Text = "Activo";
            this.activo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.75809F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.24191F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.huellaButton, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(195, 471);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(602, 48);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 42);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel5.Controls.Add(this.siRadio, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.noRadio, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(383, 23);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // siRadio
            // 
            this.siRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siRadio.AutoSize = true;
            this.siRadio.Location = new System.Drawing.Point(88, 5);
            this.siRadio.Name = "siRadio";
            this.siRadio.Size = new System.Drawing.Size(36, 15);
            this.siRadio.TabIndex = 0;
            this.siRadio.TabStop = true;
            this.siRadio.Text = "Sí";
            this.siRadio.UseVisualStyleBackColor = true;
            this.siRadio.CheckedChanged += new System.EventHandler(this.SiRadio_CheckedChanged);
            // 
            // noRadio
            // 
            this.noRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noRadio.AutoSize = true;
            this.noRadio.Location = new System.Drawing.Point(278, 5);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(39, 15);
            this.noRadio.TabIndex = 1;
            this.noRadio.TabStop = true;
            this.noRadio.Text = "No";
            this.noRadio.UseVisualStyleBackColor = true;
            this.noRadio.CheckedChanged += new System.EventHandler(this.NoRadio_CheckedChanged);
            // 
            // huellaButton
            // 
            this.huellaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.huellaButton.Location = new System.Drawing.Point(430, 4);
            this.huellaButton.Name = "huellaButton";
            this.huellaButton.Size = new System.Drawing.Size(137, 39);
            this.huellaButton.TabIndex = 11;
            this.huellaButton.Text = "Tomar Huella";
            this.huellaButton.UseVisualStyleBackColor = true;
            this.huellaButton.Click += new System.EventHandler(this.HuellaButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ciudad*:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel6);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(195, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(602, 73);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.cedulaR, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.rucR, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.pasaporteR, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.cedulaField, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.rucField, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.pasaporteField, 2, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.34146F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.65854F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(596, 54);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // cedulaR
            // 
            this.cedulaR.AutoSize = true;
            this.cedulaR.Location = new System.Drawing.Point(3, 3);
            this.cedulaR.Name = "cedulaR";
            this.cedulaR.Size = new System.Drawing.Size(113, 17);
            this.cedulaR.TabIndex = 0;
            this.cedulaR.TabStop = true;
            this.cedulaR.Text = "Número de Cédula";
            this.cedulaR.UseVisualStyleBackColor = true;
            this.cedulaR.CheckedChanged += new System.EventHandler(this.CedulaR_CheckedChanged_1);
            // 
            // rucR
            // 
            this.rucR.AutoSize = true;
            this.rucR.Location = new System.Drawing.Point(201, 3);
            this.rucR.Name = "rucR";
            this.rucR.Size = new System.Drawing.Size(103, 17);
            this.rucR.TabIndex = 1;
            this.rucR.TabStop = true;
            this.rucR.Text = "Número de RUC";
            this.rucR.UseVisualStyleBackColor = true;
            // 
            // pasaporteR
            // 
            this.pasaporteR.AutoSize = true;
            this.pasaporteR.Location = new System.Drawing.Point(399, 3);
            this.pasaporteR.Name = "pasaporteR";
            this.pasaporteR.Size = new System.Drawing.Size(128, 17);
            this.pasaporteR.TabIndex = 2;
            this.pasaporteR.TabStop = true;
            this.pasaporteR.Text = "Número de Pasaporte";
            this.pasaporteR.UseVisualStyleBackColor = true;
            this.pasaporteR.CheckedChanged += new System.EventHandler(this.PasaporteR_CheckedChanged_1);
            // 
            // cedulaField
            // 
            this.cedulaField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cedulaField.Location = new System.Drawing.Point(3, 28);
            this.cedulaField.MaxLength = 10;
            this.cedulaField.Name = "cedulaField";
            this.cedulaField.Size = new System.Drawing.Size(192, 20);
            this.cedulaField.TabIndex = 3;
            this.cedulaField.TextChanged += new System.EventHandler(this.CedulaField_TextChanged);
            this.cedulaField.Enter += new System.EventHandler(this.CedulaField_Enter);
            this.cedulaField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CedulaField_KeyPress);
            this.cedulaField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CedulaField_KeyUp_1);
            this.cedulaField.Leave += new System.EventHandler(this.CedulaField_Leave_1);
            // 
            // rucField
            // 
            this.rucField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rucField.Location = new System.Drawing.Point(201, 28);
            this.rucField.MaxLength = 13;
            this.rucField.Name = "rucField";
            this.rucField.Size = new System.Drawing.Size(192, 20);
            this.rucField.TabIndex = 4;
            this.rucField.Enter += new System.EventHandler(this.RucField_Enter);
            this.rucField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RucField_KeyPress);
            this.rucField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RucField_KeyUp_1);
            this.rucField.Leave += new System.EventHandler(this.RucField_Leave_1);
            // 
            // pasaporteField
            // 
            this.pasaporteField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pasaporteField.Location = new System.Drawing.Point(399, 28);
            this.pasaporteField.MaxLength = 13;
            this.pasaporteField.Name = "pasaporteField";
            this.pasaporteField.Size = new System.Drawing.Size(194, 20);
            this.pasaporteField.TabIndex = 5;
            this.pasaporteField.Enter += new System.EventHandler(this.PasaporteField_Enter);
            this.pasaporteField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasaporteField_KeyPress);
            this.pasaporteField.Leave += new System.EventHandler(this.PasaporteField_Leave_1);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 572);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 123);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel2_Paint);
            // 
            // registrarButton
            // 
            this.registrarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarButton.Location = new System.Drawing.Point(53, 40);
            this.registrarButton.Name = "registrarButton";
            this.registrarButton.Size = new System.Drawing.Size(160, 43);
            this.registrarButton.TabIndex = 0;
            this.registrarButton.Text = "Registrar";
            this.registrarButton.UseVisualStyleBackColor = true;
            this.registrarButton.Click += new System.EventHandler(this.RegistrarButton_Click);
            // 
            // limpiarButton
            // 
            this.limpiarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.limpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarButton.Location = new System.Drawing.Point(319, 40);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(160, 43);
            this.limpiarButton.TabIndex = 1;
            this.limpiarButton.Text = "Limpiar Campos";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.Location = new System.Drawing.Point(586, 40);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(160, 43);
            this.cancelarButton.TabIndex = 2;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 695);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarButton)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimizarButton;
        private System.Windows.Forms.PictureBox maximizarButton;
        private System.Windows.Forms.PictureBox cerrarButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCRP;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelHuella;
        private System.Windows.Forms.TextBox correoField;
        private System.Windows.Forms.TextBox direccionField;
        private System.Windows.Forms.TextBox telefonoField;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button registrarButton;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button huellaButton;
        private System.Windows.Forms.Label labelRazon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox nombreField;
        private System.Windows.Forms.TextBox razonField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton juridica;
        private System.Windows.Forms.RadioButton natural;
        private System.Windows.Forms.TextBox apellidoField;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ciudadField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton inactivo;
        private System.Windows.Forms.RadioButton activo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RadioButton siRadio;
        private System.Windows.Forms.RadioButton noRadio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RadioButton cedulaR;
        private System.Windows.Forms.RadioButton rucR;
        private System.Windows.Forms.RadioButton pasaporteR;
        private System.Windows.Forms.TextBox cedulaField;
        private System.Windows.Forms.TextBox rucField;
        private System.Windows.Forms.TextBox pasaporteField;
    }
}