namespace sistema_de_facturacion.Estadísticas
{
    partial class VentasPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasPeriodo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelIngreso = new System.Windows.Forms.Label();
            this.minimizarButton = new System.Windows.Forms.PictureBox();
            this.maximizarButton = new System.Windows.Forms.PictureBox();
            this.cerrarButton = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.parametroBox = new System.Windows.Forms.ComboBox();
            this.labelParametro = new System.Windows.Forms.Label();
            this.labelVentas = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelFin = new System.Windows.Forms.Label();
            this.fechaFinPicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelInicio = new System.Windows.Forms.Label();
            this.fechaInicioPicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.regresarButton = new System.Windows.Forms.Button();
            this.accionButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarButton)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.labelIngreso.Location = new System.Drawing.Point(330, 16);
            this.labelIngreso.Name = "labelIngreso";
            this.labelIngreso.Size = new System.Drawing.Size(190, 18);
            this.labelIngreso.TabIndex = 7;
            this.labelIngreso.Text = "Generación de Reportes";
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.parametroBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelParametro, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(128, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(332, 56);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // parametroBox
            // 
            this.parametroBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.parametroBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parametroBox.FormattingEnabled = true;
            this.parametroBox.Items.AddRange(new object[] {
            "Fecha",
            "Categoría de producto"});
            this.parametroBox.Location = new System.Drawing.Point(3, 31);
            this.parametroBox.Name = "parametroBox";
            this.parametroBox.Size = new System.Drawing.Size(326, 21);
            this.parametroBox.TabIndex = 1;
            // 
            // labelParametro
            // 
            this.labelParametro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelParametro.AutoSize = true;
            this.labelParametro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParametro.Location = new System.Drawing.Point(85, 0);
            this.labelParametro.Name = "labelParametro";
            this.labelParametro.Size = new System.Drawing.Size(161, 28);
            this.labelParametro.TabIndex = 0;
            this.labelParametro.Text = "Elegir el parámetro:";
            // 
            // labelVentas
            // 
            this.labelVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVentas.AutoSize = true;
            this.labelVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVentas.Location = new System.Drawing.Point(10, 10);
            this.labelVentas.Name = "labelVentas";
            this.labelVentas.Size = new System.Drawing.Size(99, 42);
            this.labelVentas.TabIndex = 1;
            this.labelVentas.Text = "Ventas por parámetro:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.74713F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.363636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.10345F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.Controls.Add(this.labelVentas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 62);
            this.tableLayoutPanel1.TabIndex = 13;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.labelFin, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.fechaFinPicker, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(627, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(161, 56);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // labelFin
            // 
            this.labelFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelFin.AutoSize = true;
            this.labelFin.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelFin.Location = new System.Drawing.Point(40, 0);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(80, 28);
            this.labelFin.TabIndex = 1;
            this.labelFin.Text = "Fecha Fin:";
            // 
            // fechaFinPicker
            // 
            this.fechaFinPicker.Location = new System.Drawing.Point(3, 31);
            this.fechaFinPicker.Name = "fechaFinPicker";
            this.fechaFinPicker.Size = new System.Drawing.Size(155, 20);
            this.fechaFinPicker.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.labelInicio, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.fechaInicioPicker, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(466, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(155, 56);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // labelInicio
            // 
            this.labelInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelInicio.AutoSize = true;
            this.labelInicio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelInicio.Location = new System.Drawing.Point(17, 0);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(120, 28);
            this.labelInicio.TabIndex = 1;
            this.labelInicio.Text = "Fecha de Inicio:";
            // 
            // fechaInicioPicker
            // 
            this.fechaInicioPicker.Location = new System.Drawing.Point(3, 31);
            this.fechaInicioPicker.Name = "fechaInicioPicker";
            this.fechaInicioPicker.Size = new System.Drawing.Size(149, 20);
            this.fechaInicioPicker.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.regresarButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.accionButton, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 112);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(800, 85);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // regresarButton
            // 
            this.regresarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regresarButton.Location = new System.Drawing.Point(532, 16);
            this.regresarButton.Name = "regresarButton";
            this.regresarButton.Size = new System.Drawing.Size(135, 52);
            this.regresarButton.TabIndex = 3;
            this.regresarButton.Text = "Regresar";
            this.regresarButton.UseVisualStyleBackColor = true;
            this.regresarButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // accionButton
            // 
            this.accionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accionButton.Location = new System.Drawing.Point(132, 16);
            this.accionButton.Name = "accionButton";
            this.accionButton.Size = new System.Drawing.Size(135, 52);
            this.accionButton.TabIndex = 2;
            this.accionButton.Text = "Generar Reporte";
            this.accionButton.UseVisualStyleBackColor = true;
            // 
            // VentasPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 197);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentasPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentasPeriodo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarButton)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimizarButton;
        private System.Windows.Forms.PictureBox maximizarButton;
        private System.Windows.Forms.PictureBox cerrarButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox parametroBox;
        private System.Windows.Forms.Label labelParametro;
        private System.Windows.Forms.Label labelVentas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button accionButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelFin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.DateTimePicker fechaFinPicker;
        private System.Windows.Forms.DateTimePicker fechaInicioPicker;
        private System.Windows.Forms.Button regresarButton;
        private System.Windows.Forms.Label labelIngreso;
    }
}