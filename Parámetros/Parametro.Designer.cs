namespace sistema_de_facturacion.Parámetros
{
    partial class Parametro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parametro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelIngreso = new System.Windows.Forms.Label();
            this.minimizarButton = new System.Windows.Forms.PictureBox();
            this.maximizarButton = new System.Windows.Forms.PictureBox();
            this.cerrarButton = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.guardarB = new System.Windows.Forms.Button();
            this.pagoButton = new System.Windows.Forms.Button();
            this.labelIVA = new System.Windows.Forms.Label();
            this.ivaField = new System.Windows.Forms.TextBox();
            this.regresarButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pagoBox = new System.Windows.Forms.ComboBox();
            this.agregarField = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarButton)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // labelIngreso
            // 
            this.labelIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIngreso.AutoSize = true;
            this.labelIngreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngreso.Location = new System.Drawing.Point(325, 16);
            this.labelIngreso.Name = "labelIngreso";
            this.labelIngreso.Size = new System.Drawing.Size(178, 18);
            this.labelIngreso.TabIndex = 8;
            this.labelIngreso.Text = "Parámetros del Sistema";
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.875F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelIVA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ivaField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.regresarButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 208);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Formas de Pago:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.guardarB, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pagoButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(204, 141);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(593, 64);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // guardarB
            // 
            this.guardarB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guardarB.Location = new System.Drawing.Point(83, 10);
            this.guardarB.Name = "guardarB";
            this.guardarB.Size = new System.Drawing.Size(130, 44);
            this.guardarB.TabIndex = 3;
            this.guardarB.Text = "Guardar Cambios";
            this.guardarB.UseVisualStyleBackColor = true;
            this.guardarB.Click += new System.EventHandler(this.GuardarB_Click_1);
            // 
            // pagoButton
            // 
            this.pagoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pagoButton.Location = new System.Drawing.Point(366, 8);
            this.pagoButton.Name = "pagoButton";
            this.pagoButton.Size = new System.Drawing.Size(157, 47);
            this.pagoButton.TabIndex = 4;
            this.pagoButton.Text = "Agregar Forma de Pago";
            this.pagoButton.UseVisualStyleBackColor = true;
            this.pagoButton.Click += new System.EventHandler(this.PagoButton_Click);
            // 
            // labelIVA
            // 
            this.labelIVA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIVA.AutoSize = true;
            this.labelIVA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIVA.Location = new System.Drawing.Point(67, 24);
            this.labelIVA.Name = "labelIVA";
            this.labelIVA.Size = new System.Drawing.Size(67, 21);
            this.labelIVA.TabIndex = 0;
            this.labelIVA.Text = "IVA(%):";
            // 
            // ivaField
            // 
            this.ivaField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ivaField.Location = new System.Drawing.Point(204, 24);
            this.ivaField.Name = "ivaField";
            this.ivaField.ShortcutsEnabled = false;
            this.ivaField.Size = new System.Drawing.Size(593, 20);
            this.ivaField.TabIndex = 1;
            this.ivaField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IvaField_KeyPress);
            // 
            // regresarButton
            // 
            this.regresarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regresarButton.Location = new System.Drawing.Point(48, 150);
            this.regresarButton.Name = "regresarButton";
            this.regresarButton.Size = new System.Drawing.Size(104, 45);
            this.regresarButton.TabIndex = 2;
            this.regresarButton.Text = "Regresar";
            this.regresarButton.UseVisualStyleBackColor = true;
            this.regresarButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pagoBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.agregarField, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(204, 72);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(593, 63);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // pagoBox
            // 
            this.pagoBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pagoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pagoBox.FormattingEnabled = true;
            this.pagoBox.Location = new System.Drawing.Point(3, 21);
            this.pagoBox.Name = "pagoBox";
            this.pagoBox.Size = new System.Drawing.Size(290, 21);
            this.pagoBox.TabIndex = 9;
            // 
            // agregarField
            // 
            this.agregarField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.agregarField.Location = new System.Drawing.Point(299, 21);
            this.agregarField.Name = "agregarField";
            this.agregarField.Size = new System.Drawing.Size(291, 20);
            this.agregarField.TabIndex = 10;
            this.agregarField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgregarField_KeyPress);
            // 
            // Parametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 258);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Parametro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametro";
            this.Load += new System.EventHandler(this.Parametro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarButton)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimizarButton;
        private System.Windows.Forms.PictureBox maximizarButton;
        private System.Windows.Forms.PictureBox cerrarButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelIVA;
        private System.Windows.Forms.TextBox ivaField;
        private System.Windows.Forms.Button regresarButton;
        private System.Windows.Forms.Label labelIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button guardarB;
        private System.Windows.Forms.Button pagoButton;
        private System.Windows.Forms.ComboBox pagoBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox agregarField;
    }
}