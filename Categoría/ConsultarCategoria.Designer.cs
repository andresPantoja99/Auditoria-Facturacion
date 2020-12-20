namespace sistema_de_facturacion.Categoría
{
    partial class ConsultarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCategoria));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelIngreso = new System.Windows.Forms.Label();
            this.minimizarButton = new System.Windows.Forms.PictureBox();
            this.maximizarButton = new System.Windows.Forms.PictureBox();
            this.cerrarButton = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.parametroField = new System.Windows.Forms.TextBox();
            this.labelParametro = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.agregarB = new System.Windows.Forms.Button();
            this.modificarB = new System.Windows.Forms.Button();
            this.cancelarB = new System.Windows.Forms.Button();
            this.categoriasGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarButton)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasGrid)).BeginInit();
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
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // labelIngreso
            // 
            this.labelIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIngreso.AutoSize = true;
            this.labelIngreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngreso.Location = new System.Drawing.Point(311, 18);
            this.labelIngreso.Name = "labelIngreso";
            this.labelIngreso.Size = new System.Drawing.Size(173, 18);
            this.labelIngreso.TabIndex = 7;
            this.labelIngreso.Text = "Gestión de Categorías";
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
            this.cerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.625F));
            this.tableLayoutPanel1.Controls.Add(this.parametroField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelParametro, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 62);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // parametroField
            // 
            this.parametroField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parametroField.Location = new System.Drawing.Point(261, 39);
            this.parametroField.Name = "parametroField";
            this.parametroField.ShortcutsEnabled = false;
            this.parametroField.Size = new System.Drawing.Size(536, 20);
            this.parametroField.TabIndex = 0;
            this.parametroField.SizeChanged += new System.EventHandler(this.ParametroField_SizeChanged);
            this.parametroField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ParametroField_KeyDown);
            this.parametroField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParametroField_KeyPress);
            this.parametroField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ParametroField_KeyUp);
            this.parametroField.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ParametroField_PreviewKeyDown);
            // 
            // labelParametro
            // 
            this.labelParametro.AutoSize = true;
            this.labelParametro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelParametro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParametro.Location = new System.Drawing.Point(3, 20);
            this.labelParametro.Name = "labelParametro";
            this.labelParametro.Size = new System.Drawing.Size(252, 42);
            this.labelParametro.TabIndex = 1;
            this.labelParametro.Text = "Ingrese el nombre de la cateogoría a buscar:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.agregarB, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.modificarB, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelarB, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 255);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // agregarB
            // 
            this.agregarB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.agregarB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarB.Location = new System.Drawing.Point(62, 25);
            this.agregarB.Name = "agregarB";
            this.agregarB.Size = new System.Drawing.Size(141, 50);
            this.agregarB.TabIndex = 0;
            this.agregarB.Text = "Agregar Nueva Categoría";
            this.agregarB.UseVisualStyleBackColor = true;
            this.agregarB.Click += new System.EventHandler(this.AgregarB_Click);
            // 
            // modificarB
            // 
            this.modificarB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modificarB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarB.Location = new System.Drawing.Point(346, 25);
            this.modificarB.Name = "modificarB";
            this.modificarB.Size = new System.Drawing.Size(106, 50);
            this.modificarB.TabIndex = 1;
            this.modificarB.Text = "Modificar Categoría";
            this.modificarB.UseVisualStyleBackColor = true;
            this.modificarB.Click += new System.EventHandler(this.ModificarB_Click);
            // 
            // cancelarB
            // 
            this.cancelarB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelarB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarB.Location = new System.Drawing.Point(613, 25);
            this.cancelarB.Name = "cancelarB";
            this.cancelarB.Size = new System.Drawing.Size(106, 50);
            this.cancelarB.TabIndex = 2;
            this.cancelarB.Text = "Regresar";
            this.cancelarB.UseVisualStyleBackColor = true;
            this.cancelarB.Click += new System.EventHandler(this.CancelarB_Click);
            // 
            // categoriasGrid
            // 
            this.categoriasGrid.AllowUserToAddRows = false;
            this.categoriasGrid.AllowUserToDeleteRows = false;
            this.categoriasGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoriasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriasGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriasGrid.Location = new System.Drawing.Point(0, 112);
            this.categoriasGrid.Name = "categoriasGrid";
            this.categoriasGrid.ReadOnly = true;
            this.categoriasGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoriasGrid.Size = new System.Drawing.Size(800, 143);
            this.categoriasGrid.TabIndex = 15;
            // 
            // ConsultarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.categoriasGrid);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ConsultarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarCategoria";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConsultarCategoria_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarButton)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriasGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelIngreso;
        private System.Windows.Forms.PictureBox minimizarButton;
        private System.Windows.Forms.PictureBox maximizarButton;
        private System.Windows.Forms.PictureBox cerrarButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox parametroField;
        private System.Windows.Forms.Label labelParametro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button agregarB;
        private System.Windows.Forms.Button modificarB;
        private System.Windows.Forms.Button cancelarB;
        private System.Windows.Forms.DataGridView categoriasGrid;
    }
}