namespace GestionVentasFrontend.Formularios.Venta
{
    partial class Venta
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DgvStock = new System.Windows.Forms.DataGridView();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuneto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbmarca = new System.Windows.Forms.Label();
            this.lbrubro = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cborubro = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbProd = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lbstock = new System.Windows.Forms.Label();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 54);
            this.panel4.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vender";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestionVentasFrontend.Properties.Resources.biblioteca_en_linea;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // DgvStock
            // 
            this.DgvStock.AllowUserToAddRows = false;
            this.DgvStock.AllowUserToDeleteRows = false;
            this.DgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProd,
            this.Nombre,
            this.Descripcion,
            this.Rubro,
            this.Marca,
            this.Precio,
            this.cantidad,
            this.Descuneto,
            this.Total,
            this.Accion});
            this.DgvStock.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DgvStock.Location = new System.Drawing.Point(30, 137);
            this.DgvStock.Name = "DgvStock";
            this.DgvStock.ReadOnly = true;
            this.DgvStock.RowHeadersVisible = false;
            this.DgvStock.Size = new System.Drawing.Size(965, 408);
            this.DgvStock.TabIndex = 11;
            // 
            // Accion
            // 
            this.Accion.FillWeight = 65.98985F;
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.FillWeight = 65.98985F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Descuneto
            // 
            this.Descuneto.HeaderText = "Descuento";
            this.Descuneto.Name = "Descuneto";
            this.Descuneto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.FillWeight = 65.98985F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.FillWeight = 65.98985F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.FillWeight = 65.98985F;
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Rubro
            // 
            this.Rubro.FillWeight = 65.98985F;
            this.Rubro.HeaderText = "Rubro";
            this.Rubro.Name = "Rubro";
            this.Rubro.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 65.98985F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 65.98985F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // idProd
            // 
            this.idProd.FillWeight = 65.98985F;
            this.idProd.HeaderText = "Codigo Producto";
            this.idProd.Name = "idProd";
            this.idProd.ReadOnly = true;
            // 
            // lbmarca
            // 
            this.lbmarca.AutoSize = true;
            this.lbmarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbmarca.Location = new System.Drawing.Point(196, 81);
            this.lbmarca.Name = "lbmarca";
            this.lbmarca.Size = new System.Drawing.Size(60, 19);
            this.lbmarca.TabIndex = 48;
            this.lbmarca.Text = "Marca";
            // 
            // lbrubro
            // 
            this.lbrubro.AutoSize = true;
            this.lbrubro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrubro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbrubro.Location = new System.Drawing.Point(26, 81);
            this.lbrubro.Name = "lbrubro";
            this.lbrubro.Size = new System.Drawing.Size(54, 19);
            this.lbrubro.TabIndex = 47;
            this.lbrubro.Text = "Rubro";
            // 
            // cboMarca
            // 
            this.cboMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(200, 103);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(132, 28);
            this.cboMarca.TabIndex = 46;
            // 
            // cborubro
            // 
            this.cborubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cborubro.FormattingEnabled = true;
            this.cborubro.Location = new System.Drawing.Point(30, 103);
            this.cborubro.Name = "cborubro";
            this.cborubro.Size = new System.Drawing.Size(133, 28);
            this.cborubro.TabIndex = 45;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(365, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 28);
            this.comboBox1.TabIndex = 49;
            // 
            // lbProd
            // 
            this.lbProd.AutoSize = true;
            this.lbProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProd.Location = new System.Drawing.Point(361, 81);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(78, 19);
            this.lbProd.TabIndex = 50;
            this.lbProd.Text = "Producto";
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNombre.Enabled = false;
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(882, 103);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(113, 26);
            this.txbNombre.TabIndex = 51;
            // 
            // lbstock
            // 
            this.lbstock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbstock.AutoSize = true;
            this.lbstock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbstock.Location = new System.Drawing.Point(878, 81);
            this.lbstock.Name = "lbstock";
            this.lbstock.Size = new System.Drawing.Size(50, 19);
            this.lbstock.TabIndex = 52;
            this.lbstock.Text = "Stock";
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSiguiente.FlatAppearance.BorderSize = 0;
            this.BtnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguiente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSiguiente.Location = new System.Drawing.Point(861, 571);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(134, 52);
            this.BtnSiguiente.TabIndex = 53;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = false;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1031, 666);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.lbstock);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lbProd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbmarca);
            this.Controls.Add(this.lbrubro);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.cborubro);
            this.Controls.Add(this.DgvStock);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.Text = "Venta";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView DgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuneto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
        private System.Windows.Forms.Label lbmarca;
        private System.Windows.Forms.Label lbrubro;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cborubro;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbProd;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lbstock;
        private System.Windows.Forms.Button BtnSiguiente;
    }
}