namespace sistema_de_facturacion.Usuarios
{
    partial class AgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelIngreso = new System.Windows.Forms.Label();
            this.minimizarButton = new System.Windows.Forms.PictureBox();
            this.maximizarButton = new System.Windows.Forms.PictureBox();
            this.cerrarButton = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.apellidoField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.nombreField = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.labelNombres = new System.Windows.Forms.Label();
            this.nombresField = new System.Windows.Forms.TextBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelHuella = new System.Windows.Forms.Label();
            this.usuarioBox = new System.Windows.Forms.ComboBox();
            this.huellaButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.registrarButton = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarButton)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // labelIngreso
            // 
            this.labelIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIngreso.AutoSize = true;
            this.labelIngreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngreso.Location = new System.Drawing.Point(325, 16);
            this.labelIngreso.Name = "labelIngreso";
            this.labelIngreso.Size = new System.Drawing.Size(154, 18);
            this.labelIngreso.TabIndex = 8;
            this.labelIngreso.Text = "Registro de Usuarios";
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.125F));
            this.tableLayoutPanel1.Controls.Add(this.apellidoField, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelNombre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nombreField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordField, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNombres, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nombresField, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelTipo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelHuella, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.usuarioBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.huellaButton, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 613);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // apellidoField
            // 
            this.apellidoField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.apellidoField.Location = new System.Drawing.Point(210, 347);
            this.apellidoField.MaxLength = 50;
            this.apellidoField.Name = "apellidoField";
            this.apellidoField.ShortcutsEnabled = false;
            this.apellidoField.Size = new System.Drawing.Size(587, 20);
            this.apellidoField.TabIndex = 3;
            this.apellidoField.Enter += new System.EventHandler(this.ApellidoField_Enter);
            this.apellidoField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidoField_KeyPress);
            this.apellidoField.Leave += new System.EventHandler(this.ApellidoField_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Apellido(s)*:";
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(67, 40);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(73, 21);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "User ID*:";
            // 
            // nombreField
            // 
            this.nombreField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreField.Location = new System.Drawing.Point(210, 41);
            this.nombreField.MaxLength = 12;
            this.nombreField.Name = "nombreField";
            this.nombreField.ShortcutsEnabled = false;
            this.nombreField.Size = new System.Drawing.Size(587, 20);
            this.nombreField.TabIndex = 0;
            this.nombreField.Enter += new System.EventHandler(this.NombreField_Enter);
            this.nombreField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreField_KeyPress);
            this.nombreField.Leave += new System.EventHandler(this.NombreField_Leave);
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelPassword.Location = new System.Drawing.Point(47, 142);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(113, 21);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Contraseña*:";
            // 
            // passwordField
            // 
            this.passwordField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordField.Location = new System.Drawing.Point(210, 143);
            this.passwordField.MaxLength = 15;
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.ShortcutsEnabled = false;
            this.passwordField.Size = new System.Drawing.Size(587, 20);
            this.passwordField.TabIndex = 1;
            this.passwordField.Enter += new System.EventHandler(this.PasswordField_Enter);
            this.passwordField.Leave += new System.EventHandler(this.PasswordField_Leave);
            // 
            // labelNombres
            // 
            this.labelNombres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNombres.AutoSize = true;
            this.labelNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombres.Location = new System.Drawing.Point(53, 244);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(101, 21);
            this.labelNombres.TabIndex = 4;
            this.labelNombres.Text = "Nombre(s)*:";
            // 
            // nombresField
            // 
            this.nombresField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nombresField.Location = new System.Drawing.Point(210, 245);
            this.nombresField.MaxLength = 50;
            this.nombresField.Name = "nombresField";
            this.nombresField.ShortcutsEnabled = false;
            this.nombresField.Size = new System.Drawing.Size(587, 20);
            this.nombresField.TabIndex = 2;
            this.nombresField.Enter += new System.EventHandler(this.NombresField_Enter);
            this.nombresField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombresField_KeyPress);
            this.nombresField.Leave += new System.EventHandler(this.NombresField_Leave);
            // 
            // labelTipo
            // 
            this.labelTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelTipo.Location = new System.Drawing.Point(35, 448);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(137, 21);
            this.labelTipo.TabIndex = 14;
            this.labelTipo.Text = "Tipo de Usuario*:";
            // 
            // labelHuella
            // 
            this.labelHuella.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHuella.AutoSize = true;
            this.labelHuella.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHuella.Location = new System.Drawing.Point(39, 551);
            this.labelHuella.Name = "labelHuella";
            this.labelHuella.Size = new System.Drawing.Size(128, 21);
            this.labelHuella.TabIndex = 5;
            this.labelHuella.Text = "Huella Dactilar:";
            // 
            // usuarioBox
            // 
            this.usuarioBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usuarioBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usuarioBox.FormattingEnabled = true;
            this.usuarioBox.Items.AddRange(new object[] {
            "Gerente",
            "Vendedor",
            "Bodeguero"});
            this.usuarioBox.Location = new System.Drawing.Point(210, 448);
            this.usuarioBox.Name = "usuarioBox";
            this.usuarioBox.Size = new System.Drawing.Size(587, 21);
            this.usuarioBox.TabIndex = 4;
            // 
            // huellaButton
            // 
            this.huellaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.huellaButton.Location = new System.Drawing.Point(427, 531);
            this.huellaButton.Name = "huellaButton";
            this.huellaButton.Size = new System.Drawing.Size(153, 61);
            this.huellaButton.TabIndex = 5;
            this.huellaButton.Text = "Tomar Huella";
            this.huellaButton.UseVisualStyleBackColor = true;
            this.huellaButton.Click += new System.EventHandler(this.HuellaButton_Click);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 663);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 68);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // registrarButton
            // 
            this.registrarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarButton.Location = new System.Drawing.Point(53, 9);
            this.registrarButton.Name = "registrarButton";
            this.registrarButton.Size = new System.Drawing.Size(160, 50);
            this.registrarButton.TabIndex = 6;
            this.registrarButton.Text = "Registrar";
            this.registrarButton.UseVisualStyleBackColor = true;
            this.registrarButton.Click += new System.EventHandler(this.RegistrarButton_Click);
            // 
            // limpiarButton
            // 
            this.limpiarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.limpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarButton.Location = new System.Drawing.Point(319, 9);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(160, 50);
            this.limpiarButton.TabIndex = 7;
            this.limpiarButton.Text = "Limpiar Campos";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.Location = new System.Drawing.Point(586, 9);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(160, 50);
            this.cancelarButton.TabIndex = 8;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 731);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarButton)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimizarButton;
        private System.Windows.Forms.PictureBox maximizarButton;
        private System.Windows.Forms.PictureBox cerrarButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox nombresField;
        private System.Windows.Forms.TextBox nombreField;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Label labelHuella;
        private System.Windows.Forms.Button huellaButton;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button registrarButton;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.ComboBox usuarioBox;
        private System.Windows.Forms.Label labelIngreso;
        private System.Windows.Forms.TextBox apellidoField;
        private System.Windows.Forms.Label label1;
    }
}