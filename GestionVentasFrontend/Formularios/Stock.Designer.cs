namespace GestionVentasFrontend.Formularios
{
    partial class Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvStock = new System.Windows.Forms.DataGridView();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stockmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stockk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbmarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lbrubro = new System.Windows.Forms.Label();
            this.cborubro = new System.Windows.Forms.ComboBox();
            this.rbtPorcentaje = new System.Windows.Forms.RadioButton();
            this.RbtMonto = new System.Windows.Forms.RadioButton();
            this.nupAumento = new System.Windows.Forms.NumericUpDown();
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbStock = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbAumento = new System.Windows.Forms.Label();
            this.RbtStock = new System.Windows.Forms.RadioButton();
            this.lbitem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAumento)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvStock
            // 
            this.DgvStock.AllowUserToAddRows = false;
            this.DgvStock.AllowUserToDeleteRows = false;
            this.DgvStock.AllowUserToResizeRows = false;
            this.DgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProd,
            this.Nombre,
            this.Descripcion,
            this.Rubro,
            this.Marca,
            this.precio,
            this.Stockmin,
            this.Stockk,
            this.Seleccion});
            this.DgvStock.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DgvStock.Location = new System.Drawing.Point(36, 163);
            this.DgvStock.Name = "DgvStock";
            this.DgvStock.ReadOnly = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvStock.RowHeadersVisible = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvStock.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DgvStock.Size = new System.Drawing.Size(965, 471);
            this.DgvStock.TabIndex = 6;
            this.DgvStock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvStock_CellFormatting);
            this.DgvStock.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvStock_CellMouseClick);
            // 
            // idProd
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idProd.DefaultCellStyle = dataGridViewCellStyle2;
            this.idProd.HeaderText = "Codigo Producto";
            this.idProd.Name = "idProd";
            this.idProd.ReadOnly = true;
            // 
            // Nombre
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle4;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Rubro
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Rubro.DefaultCellStyle = dataGridViewCellStyle5;
            this.Rubro.HeaderText = "Rubro";
            this.Rubro.Name = "Rubro";
            this.Rubro.ReadOnly = true;
            // 
            // Marca
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Marca.DefaultCellStyle = dataGridViewCellStyle6;
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // precio
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.precio.DefaultCellStyle = dataGridViewCellStyle7;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // Stockmin
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Stockmin.DefaultCellStyle = dataGridViewCellStyle8;
            this.Stockmin.HeaderText = "Stock Min.";
            this.Stockmin.Name = "Stockmin";
            this.Stockmin.ReadOnly = true;
            // 
            // Stockk
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Cornsilk;
            this.Stockk.DefaultCellStyle = dataGridViewCellStyle9;
            this.Stockk.HeaderText = "Stock";
            this.Stockk.Name = "Stockk";
            this.Stockk.ReadOnly = true;
            // 
            // Seleccion
            // 
            this.Seleccion.FillWeight = 70F;
            this.Seleccion.HeaderText = "Seleccion";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.ReadOnly = true;
            // 
            // lbmarca
            // 
            this.lbmarca.AutoSize = true;
            this.lbmarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbmarca.Location = new System.Drawing.Point(223, 107);
            this.lbmarca.Name = "lbmarca";
            this.lbmarca.Size = new System.Drawing.Size(60, 19);
            this.lbmarca.TabIndex = 15;
            this.lbmarca.Text = "Marca";
            // 
            // cboMarca
            // 
            this.cboMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(227, 129);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(168, 28);
            this.cboMarca.TabIndex = 1;
            this.cboMarca.SelectedValueChanged += new System.EventHandler(this.cboMarca_SelectedValueChanged);
            // 
            // lbrubro
            // 
            this.lbrubro.AutoSize = true;
            this.lbrubro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrubro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbrubro.Location = new System.Drawing.Point(32, 107);
            this.lbrubro.Name = "lbrubro";
            this.lbrubro.Size = new System.Drawing.Size(54, 19);
            this.lbrubro.TabIndex = 17;
            this.lbrubro.Text = "Rubro";
            // 
            // cborubro
            // 
            this.cborubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cborubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cborubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cborubro.FormattingEnabled = true;
            this.cborubro.Location = new System.Drawing.Point(36, 129);
            this.cborubro.Name = "cborubro";
            this.cborubro.Size = new System.Drawing.Size(168, 28);
            this.cborubro.TabIndex = 0;
            this.cborubro.SelectedValueChanged += new System.EventHandler(this.cborubro_SelectedValueChanged);
            // 
            // rbtPorcentaje
            // 
            this.rbtPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtPorcentaje.AutoSize = true;
            this.rbtPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPorcentaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtPorcentaje.Location = new System.Drawing.Point(630, 129);
            this.rbtPorcentaje.Name = "rbtPorcentaje";
            this.rbtPorcentaje.Size = new System.Drawing.Size(86, 22);
            this.rbtPorcentaje.TabIndex = 2;
            this.rbtPorcentaje.Text = "% Monto";
            this.rbtPorcentaje.UseVisualStyleBackColor = true;
            this.rbtPorcentaje.CheckedChanged += new System.EventHandler(this.rbtPorcentaje_CheckedChanged);
            // 
            // RbtMonto
            // 
            this.RbtMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RbtMonto.AutoSize = true;
            this.RbtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtMonto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RbtMonto.Location = new System.Drawing.Point(736, 129);
            this.RbtMonto.Name = "RbtMonto";
            this.RbtMonto.Size = new System.Drawing.Size(69, 22);
            this.RbtMonto.TabIndex = 3;
            this.RbtMonto.Text = "Monto";
            this.RbtMonto.UseVisualStyleBackColor = true;
            this.RbtMonto.CheckedChanged += new System.EventHandler(this.RbtMonto_CheckedChanged);
            // 
            // nupAumento
            // 
            this.nupAumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nupAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupAumento.Location = new System.Drawing.Point(811, 128);
            this.nupAumento.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nupAumento.Name = "nupAumento";
            this.nupAumento.Size = new System.Drawing.Size(93, 26);
            this.nupAumento.TabIndex = 4;
            // 
            // BtnAplicar
            // 
            this.BtnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAplicar.FlatAppearance.BorderSize = 0;
            this.BtnAplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BtnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAplicar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAplicar.Location = new System.Drawing.Point(923, 125);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(78, 29);
            this.BtnAplicar.TabIndex = 5;
            this.BtnAplicar.Text = "Aplicar";
            this.BtnAplicar.UseVisualStyleBackColor = false;
            this.BtnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.lbStock);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 54);
            this.panel4.TabIndex = 22;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.ForeColor = System.Drawing.SystemColors.Control;
            this.lbStock.Location = new System.Drawing.Point(80, 9);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(103, 38);
            this.lbStock.TabIndex = 1;
            this.lbStock.Text = "Stock";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestionVentasFrontend.Properties.Resources._51640231;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lbAumento
            // 
            this.lbAumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAumento.AutoSize = true;
            this.lbAumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAumento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAumento.Location = new System.Drawing.Point(533, 105);
            this.lbAumento.Name = "lbAumento";
            this.lbAumento.Size = new System.Drawing.Size(81, 19);
            this.lbAumento.TabIndex = 23;
            this.lbAumento.Text = "Aumento";
            // 
            // RbtStock
            // 
            this.RbtStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RbtStock.AutoSize = true;
            this.RbtStock.Checked = true;
            this.RbtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RbtStock.Location = new System.Drawing.Point(542, 129);
            this.RbtStock.Name = "RbtStock";
            this.RbtStock.Size = new System.Drawing.Size(65, 22);
            this.RbtStock.TabIndex = 24;
            this.RbtStock.TabStop = true;
            this.RbtStock.Text = "Stock";
            this.RbtStock.UseVisualStyleBackColor = true;
            this.RbtStock.CheckedChanged += new System.EventHandler(this.RbtStock_CheckedChanged);
            // 
            // lbitem
            // 
            this.lbitem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbitem.AutoSize = true;
            this.lbitem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbitem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbitem.Location = new System.Drawing.Point(903, 637);
            this.lbitem.Name = "lbitem";
            this.lbitem.Size = new System.Drawing.Size(66, 19);
            this.lbitem.TabIndex = 25;
            this.lbitem.Text = "items: 0";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(1047, 705);
            this.Controls.Add(this.lbitem);
            this.Controls.Add(this.RbtStock);
            this.Controls.Add(this.lbAumento);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.BtnAplicar);
            this.Controls.Add(this.nupAumento);
            this.Controls.Add(this.RbtMonto);
            this.Controls.Add(this.rbtPorcentaje);
            this.Controls.Add(this.lbrubro);
            this.Controls.Add(this.cborubro);
            this.Controls.Add(this.lbmarca);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.DgvStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAumento)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvStock;
        private System.Windows.Forms.Label lbmarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lbrubro;
        private System.Windows.Forms.ComboBox cborubro;
        private System.Windows.Forms.RadioButton rbtPorcentaje;
        private System.Windows.Forms.RadioButton RbtMonto;
        private System.Windows.Forms.NumericUpDown nupAumento;
        private System.Windows.Forms.Button BtnAplicar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbAumento;
        private System.Windows.Forms.RadioButton RbtStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stockmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stockk;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.Label lbitem;
    }
}