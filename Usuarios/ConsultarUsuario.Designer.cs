namespace sistema_de_facturacion.Usuarios
{
    partial class ConsultarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelIngreso = new System.Windows.Forms.Label();
            this.minimizarButton = new System.Windows.Forms.PictureBox();
            this.maximizarButton = new System.Windows.Forms.PictureBox();
            this.cerrarButton = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelParametro = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelElegir = new System.Windows.Forms.Label();
            this.parametroBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.parametroField = new System.Windows.Forms.TextBox();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.accionButton = new System.Windows.Forms.Button();
            this.regresarButton = new System.Windows.Forms.Button();
            this.usuarioGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarButton)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioGrid)).BeginInit();
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
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // labelIngreso
            // 
            this.labelIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIngreso.AutoSize = true;
            this.labelIngreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngreso.Location = new System.Drawing.Point(325, 16);
            this.labelIngreso.Name = "labelIngreso";
            this.labelIngreso.Size = new System.Drawing.Size(152, 18);
            this.labelIngreso.TabIndex = 8;
            this.labelIngreso.Text = "Gestión de Usuarios";
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
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75F));
            this.tableLayoutPanel1.Controls.Add(this.labelParametro, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 62);
            this.tableLayoutPanel1.TabIndex = 13;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // labelParametro
            // 
            this.labelParametro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParametro.AutoSize = true;
            this.labelParametro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParametro.Location = new System.Drawing.Point(3, 41);
            this.labelParametro.Name = "labelParametro";
            this.labelParametro.Size = new System.Drawing.Size(183, 21);
            this.labelParametro.TabIndex = 1;
            this.labelParametro.Text = "Ingrese el parámetro:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelElegir, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.parametroBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(589, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(208, 56);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // labelElegir
            // 
            this.labelElegir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelElegir.AutoSize = true;
            this.labelElegir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElegir.Location = new System.Drawing.Point(23, 0);
            this.labelElegir.Name = "labelElegir";
            this.labelElegir.Size = new System.Drawing.Size(161, 28);
            this.labelElegir.TabIndex = 0;
            this.labelElegir.Text = "Elegir el parámetro:";
            // 
            // parametroBox
            // 
            this.parametroBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.parametroBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parametroBox.FormattingEnabled = true;
            this.parametroBox.Items.AddRange(new object[] {
            "Nombre de usuario",
            "Rol",
            "Correo Electrónico"});
            this.parametroBox.Location = new System.Drawing.Point(3, 31);
            this.parametroBox.Name = "parametroBox";
            this.parametroBox.Size = new System.Drawing.Size(202, 21);
            this.parametroBox.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.parametroField, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelAdvertencia, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(192, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(391, 56);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // parametroField
            // 
            this.parametroField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parametroField.Location = new System.Drawing.Point(3, 33);
            this.parametroField.Name = "parametroField";
            this.parametroField.ShortcutsEnabled = false;
            this.parametroField.Size = new System.Drawing.Size(385, 20);
            this.parametroField.TabIndex = 1;
            this.parametroField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ParametroField_KeyDown);
            this.parametroField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParametroField_KeyPress_1);
            this.parametroField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ParametroField_KeyUp);
            // 
            // labelAdvertencia
            // 
            this.labelAdvertencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAdvertencia.AutoSize = true;
            this.labelAdvertencia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.labelAdvertencia.Location = new System.Drawing.Point(56, 3);
            this.labelAdvertencia.Name = "labelAdvertencia";
            this.labelAdvertencia.Size = new System.Drawing.Size(279, 21);
            this.labelAdvertencia.TabIndex = 2;
            this.labelAdvertencia.Text = "Debe elegir un parámetro primero!";
            this.labelAdvertencia.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.accionButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.regresarButton, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 521);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(800, 58);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // accionButton
            // 
            this.accionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accionButton.Location = new System.Drawing.Point(132, 3);
            this.accionButton.Name = "accionButton";
            this.accionButton.Size = new System.Drawing.Size(135, 52);
            this.accionButton.TabIndex = 2;
            this.accionButton.Text = "Modificar datos del usuario";
            this.accionButton.UseVisualStyleBackColor = true;
            this.accionButton.Click += new System.EventHandler(this.AccionV_Click);
            // 
            // regresarButton
            // 
            this.regresarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regresarButton.Location = new System.Drawing.Point(532, 3);
            this.regresarButton.Name = "regresarButton";
            this.regresarButton.Size = new System.Drawing.Size(135, 52);
            this.regresarButton.TabIndex = 1;
            this.regresarButton.Text = "Regresar";
            this.regresarButton.UseVisualStyleBackColor = true;
            this.regresarButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // usuarioGrid
            // 
            this.usuarioGrid.AllowUserToAddRows = false;
            this.usuarioGrid.AllowUserToDeleteRows = false;
            this.usuarioGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usuarioGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuarioGrid.Location = new System.Drawing.Point(0, 112);
            this.usuarioGrid.Name = "usuarioGrid";
            this.usuarioGrid.ReadOnly = true;
            this.usuarioGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuarioGrid.Size = new System.Drawing.Size(800, 409);
            this.usuarioGrid.TabIndex = 16;
            // 
            // ConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.usuarioGrid);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarButton)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimizarButton;
        private System.Windows.Forms.PictureBox maximizarButton;
        private System.Windows.Forms.PictureBox cerrarButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelParametro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelElegir;
        private System.Windows.Forms.ComboBox parametroBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button accionButton;
        private System.Windows.Forms.Button regresarButton;
        private System.Windows.Forms.Label labelIngreso;
        private System.Windows.Forms.DataGridView usuarioGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox parametroField;
        private System.Windows.Forms.Label labelAdvertencia;
    }
}