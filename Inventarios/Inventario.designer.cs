namespace sistema_de_facturacion.Inventarios
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelIngreso = new System.Windows.Forms.Label();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.codigoField = new System.Windows.Forms.TextBox();
            this.nombreField = new System.Windows.Forms.TextBox();
            this.disponiblesField = new System.Windows.Forms.TextBox();
            this.unitarioField = new System.Windows.Forms.TextBox();
            this.descuentoField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.minimoField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.categoriaBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.proveedorBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gananciaField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adquisicionField = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.unidadField = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.guardarButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(196)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.labelIngreso);
            this.panel1.Controls.Add(this.minimizar);
            this.panel1.Controls.Add(this.maximizar);
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // labelIngreso
            // 
            this.labelIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIngreso.AutoSize = true;
            this.labelIngreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngreso.Location = new System.Drawing.Point(322, 16);
            this.labelIngreso.Name = "labelIngreso";
            this.labelIngreso.Size = new System.Drawing.Size(166, 18);
            this.labelIngreso.TabIndex = 7;
            this.labelIngreso.Text = "Registro de Productos";
            this.labelIngreso.Click += new System.EventHandler(this.LabelIngreso_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(687, 12);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(24, 24);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 5;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(717, 12);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(24, 24);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar.TabIndex = 4;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(747, 12);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(24, 24);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 3;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.65879F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.34121F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.codigoField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nombreField, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.disponiblesField, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.unitarioField, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.descuentoField, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.minimoField, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.categoriaBox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.proveedorBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.gananciaField, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.adquisicionField, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.unidadField, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 451);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidades Disponibles:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio Unitario(USD):";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descuento (%):";
            // 
            // codigoField
            // 
            this.codigoField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoField.Location = new System.Drawing.Point(235, 10);
            this.codigoField.MaxLength = 25;
            this.codigoField.Name = "codigoField";
            this.codigoField.ShortcutsEnabled = false;
            this.codigoField.Size = new System.Drawing.Size(546, 20);
            this.codigoField.TabIndex = 0;
            this.codigoField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoField_KeyPress);
            // 
            // nombreField
            // 
            this.nombreField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreField.Location = new System.Drawing.Point(235, 50);
            this.nombreField.MaxLength = 100;
            this.nombreField.Name = "nombreField";
            this.nombreField.ShortcutsEnabled = false;
            this.nombreField.Size = new System.Drawing.Size(546, 20);
            this.nombreField.TabIndex = 1;
            this.nombreField.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.nombreField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreField_KeyPress);
            // 
            // disponiblesField
            // 
            this.disponiblesField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.disponiblesField.Location = new System.Drawing.Point(235, 90);
            this.disponiblesField.MaxLength = 7;
            this.disponiblesField.Name = "disponiblesField";
            this.disponiblesField.ShortcutsEnabled = false;
            this.disponiblesField.Size = new System.Drawing.Size(546, 20);
            this.disponiblesField.TabIndex = 2;
            this.disponiblesField.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            this.disponiblesField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisponiblesField_KeyPress);
            // 
            // unitarioField
            // 
            this.unitarioField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.unitarioField.Location = new System.Drawing.Point(235, 130);
            this.unitarioField.MaxLength = 9;
            this.unitarioField.Name = "unitarioField";
            this.unitarioField.ShortcutsEnabled = false;
            this.unitarioField.Size = new System.Drawing.Size(546, 20);
            this.unitarioField.TabIndex = 3;
            this.unitarioField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitarioField_KeyPress);
            this.unitarioField.Leave += new System.EventHandler(this.UnitarioField_Leave);
            // 
            // descuentoField
            // 
            this.descuentoField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.descuentoField.Location = new System.Drawing.Point(235, 170);
            this.descuentoField.MaxLength = 6;
            this.descuentoField.Name = "descuentoField";
            this.descuentoField.ShortcutsEnabled = false;
            this.descuentoField.Size = new System.Drawing.Size(546, 20);
            this.descuentoField.TabIndex = 4;
            this.descuentoField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescuentoField_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(57, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Stock Mínimo:";
            // 
            // minimoField
            // 
            this.minimoField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.minimoField.Location = new System.Drawing.Point(235, 415);
            this.minimoField.MaxLength = 7;
            this.minimoField.Name = "minimoField";
            this.minimoField.Size = new System.Drawing.Size(546, 20);
            this.minimoField.TabIndex = 10;
            this.minimoField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinimoField_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Categoría:";
            // 
            // categoriaBox
            // 
            this.categoriaBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaBox.FormattingEnabled = true;
            this.categoriaBox.Location = new System.Drawing.Point(235, 369);
            this.categoriaBox.Name = "categoriaBox";
            this.categoriaBox.Size = new System.Drawing.Size(546, 21);
            this.categoriaBox.TabIndex = 9;
            this.categoriaBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Proveedor:";
            // 
            // proveedorBox
            // 
            this.proveedorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.proveedorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proveedorBox.FormattingEnabled = true;
            this.proveedorBox.Location = new System.Drawing.Point(235, 329);
            this.proveedorBox.Name = "proveedorBox";
            this.proveedorBox.Size = new System.Drawing.Size(546, 21);
            this.proveedorBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ganancia Mínima(USD):";
            // 
            // gananciaField
            // 
            this.gananciaField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gananciaField.Location = new System.Drawing.Point(235, 290);
            this.gananciaField.MaxLength = 9;
            this.gananciaField.Name = "gananciaField";
            this.gananciaField.Size = new System.Drawing.Size(546, 20);
            this.gananciaField.TabIndex = 7;
            this.gananciaField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GananciaField_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio de adquisición(USD):";
            // 
            // adquisicionField
            // 
            this.adquisicionField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.adquisicionField.Location = new System.Drawing.Point(235, 250);
            this.adquisicionField.MaxLength = 9;
            this.adquisicionField.Name = "adquisicionField";
            this.adquisicionField.ShortcutsEnabled = false;
            this.adquisicionField.Size = new System.Drawing.Size(546, 20);
            this.adquisicionField.TabIndex = 6;
            this.adquisicionField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdquisicionField_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Unidad de Venta:";
            // 
            // unidadField
            // 
            this.unidadField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.unidadField.Location = new System.Drawing.Point(235, 210);
            this.unidadField.MaxLength = 20;
            this.unidadField.Name = "unidadField";
            this.unidadField.Size = new System.Drawing.Size(546, 20);
            this.unidadField.TabIndex = 5;
            this.unidadField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnidadField_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.guardarButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 501);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 108);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // guardarButton
            // 
            this.guardarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guardarButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarButton.Location = new System.Drawing.Point(50, 29);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(160, 50);
            this.guardarButton.TabIndex = 11;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(311, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 50);
            this.button2.TabIndex = 12;
            this.button2.Text = "Limpiar campos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(573, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 609);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox categoriaBox;
        private System.Windows.Forms.TextBox codigoField;
        private System.Windows.Forms.TextBox nombreField;
        private System.Windows.Forms.TextBox disponiblesField;
        private System.Windows.Forms.TextBox unitarioField;
        private System.Windows.Forms.TextBox descuentoField;
        private System.Windows.Forms.TextBox adquisicionField;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelIngreso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox gananciaField;
        private System.Windows.Forms.ComboBox proveedorBox;
        private System.Windows.Forms.TextBox minimoField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox unidadField;
    }
}