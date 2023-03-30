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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DgvDetalle = new System.Windows.Forms.DataGridView();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuneto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbmarca = new System.Windows.Forms.Label();
            this.lbrubro = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cborubro = new System.Windows.Forms.ComboBox();
            this.cboprod = new System.Windows.Forms.ComboBox();
            this.lbProd = new System.Windows.Forms.Label();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.lbstock = new System.Windows.Forms.Label();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.nupCantidad = new System.Windows.Forms.Label();
            this.nupCant = new System.Windows.Forms.NumericUpDown();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCant)).BeginInit();
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
            // DgvDetalle
            // 
            this.DgvDetalle.AllowUserToAddRows = false;
            this.DgvDetalle.AllowUserToDeleteRows = false;
            this.DgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DgvDetalle.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DgvDetalle.Location = new System.Drawing.Point(30, 145);
            this.DgvDetalle.Name = "DgvDetalle";
            this.DgvDetalle.ReadOnly = true;
            this.DgvDetalle.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDetalle.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvDetalle.Size = new System.Drawing.Size(965, 408);
            this.DgvDetalle.TabIndex = 11;
            this.DgvDetalle.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDetalle_CellMouseClick);
            // 
            // idProd
            // 
            this.idProd.FillWeight = 65.98985F;
            this.idProd.HeaderText = "Codigo Producto";
            this.idProd.Name = "idProd";
            this.idProd.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 140F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 65.98985F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Rubro
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Rubro.DefaultCellStyle = dataGridViewCellStyle2;
            this.Rubro.FillWeight = 65.98985F;
            this.Rubro.HeaderText = "Rubro";
            this.Rubro.Name = "Rubro";
            this.Rubro.ReadOnly = true;
            // 
            // Marca
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Marca.DefaultCellStyle = dataGridViewCellStyle3;
            this.Marca.FillWeight = 65.98985F;
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Precio
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle4;
            this.Precio.FillWeight = 65.98985F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // cantidad
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle5;
            this.cantidad.FillWeight = 65.98985F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // Descuneto
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Descuneto.DefaultCellStyle = dataGridViewCellStyle6;
            this.Descuneto.FillWeight = 60F;
            this.Descuneto.HeaderText = "Descuento";
            this.Descuneto.Name = "Descuneto";
            this.Descuneto.ReadOnly = true;
            // 
            // Total
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Total.DefaultCellStyle = dataGridViewCellStyle7;
            this.Total.FillWeight = 65.98985F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Accion
            // 
            this.Accion.FillWeight = 55.98985F;
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Text = "Quitar";
            this.Accion.UseColumnTextForButtonValue = true;
            // 
            // lbmarca
            // 
            this.lbmarca.AutoSize = true;
            this.lbmarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbmarca.Location = new System.Drawing.Point(199, 81);
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
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(201, 102);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(151, 28);
            this.cboMarca.TabIndex = 46;
            this.cboMarca.SelectionChangeCommitted += new System.EventHandler(this.cboMarca_SelectionChangeCommitted);
            // 
            // cborubro
            // 
            this.cborubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cborubro.FormattingEnabled = true;
            this.cborubro.Location = new System.Drawing.Point(30, 102);
            this.cborubro.Name = "cborubro";
            this.cborubro.Size = new System.Drawing.Size(151, 28);
            this.cborubro.TabIndex = 45;
            this.cborubro.SelectionChangeCommitted += new System.EventHandler(this.cborubro_SelectionChangeCommitted);
            // 
            // cboprod
            // 
            this.cboprod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboprod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboprod.FormattingEnabled = true;
            this.cboprod.Location = new System.Drawing.Point(371, 102);
            this.cboprod.Name = "cboprod";
            this.cboprod.Size = new System.Drawing.Size(154, 28);
            this.cboprod.TabIndex = 49;
            this.cboprod.SelectionChangeCommitted += new System.EventHandler(this.cboprod_SelectionChangeCommitted);
            this.cboprod.SelectedValueChanged += new System.EventHandler(this.cboprod_SelectedValueChanged);
            // 
            // lbProd
            // 
            this.lbProd.AutoSize = true;
            this.lbProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProd.Location = new System.Drawing.Point(367, 80);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(78, 19);
            this.lbProd.TabIndex = 50;
            this.lbProd.Text = "Producto";
            // 
            // txbStock
            // 
            this.txbStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbStock.Enabled = false;
            this.txbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStock.Location = new System.Drawing.Point(882, 103);
            this.txbStock.Name = "txbStock";
            this.txbStock.Size = new System.Drawing.Size(113, 26);
            this.txbStock.TabIndex = 51;
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
            this.BtnSiguiente.Location = new System.Drawing.Point(861, 604);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(134, 40);
            this.BtnSiguiente.TabIndex = 53;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = false;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // nupCantidad
            // 
            this.nupCantidad.AutoSize = true;
            this.nupCantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nupCantidad.Location = new System.Drawing.Point(548, 82);
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(83, 19);
            this.nupCantidad.TabIndex = 69;
            this.nupCantidad.Text = "Cantidad";
            // 
            // nupCant
            // 
            this.nupCant.DecimalPlaces = 2;
            this.nupCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCant.Location = new System.Drawing.Point(552, 104);
            this.nupCant.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nupCant.Name = "nupCant";
            this.nupCant.Size = new System.Drawing.Size(88, 26);
            this.nupCant.TabIndex = 68;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAgregar.Location = new System.Drawing.Point(673, 100);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(74, 31);
            this.BtnAgregar.TabIndex = 70;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotal.Location = new System.Drawing.Point(826, 563);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(45, 19);
            this.lbTotal.TabIndex = 72;
            this.lbTotal.Text = "Total";
            // 
            // txbTotal
            // 
            this.txbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTotal.Enabled = false;
            this.txbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotal.Location = new System.Drawing.Point(882, 559);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(113, 26);
            this.txbTotal.TabIndex = 71;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(1031, 666);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.nupCantidad);
            this.Controls.Add(this.nupCant);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.lbstock);
            this.Controls.Add(this.txbStock);
            this.Controls.Add(this.lbProd);
            this.Controls.Add(this.cboprod);
            this.Controls.Add(this.lbmarca);
            this.Controls.Add(this.lbrubro);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.cborubro);
            this.Controls.Add(this.DgvDetalle);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView DgvDetalle;
        private System.Windows.Forms.Label lbmarca;
        private System.Windows.Forms.Label lbrubro;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cborubro;
        private System.Windows.Forms.ComboBox cboprod;
        private System.Windows.Forms.Label lbProd;
        private System.Windows.Forms.TextBox txbStock;
        private System.Windows.Forms.Label lbstock;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Label nupCantidad;
        private System.Windows.Forms.NumericUpDown nupCant;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txbTotal;
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
    }
}