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
            this.DgvStock = new System.Windows.Forms.DataGridView();
            this.lbmarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lbrubro = new System.Windows.Forms.Label();
            this.cborubro = new System.Windows.Forms.ComboBox();
            this.rbtPorcentaje = new System.Windows.Forms.RadioButton();
            this.RbtMonto = new System.Windows.Forms.RadioButton();
            this.nupAumento = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbAumento = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stockmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stockk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.precio,
            this.Stockmin,
            this.Stockk,
            this.Seleccion});
            this.DgvStock.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DgvStock.Location = new System.Drawing.Point(36, 163);
            this.DgvStock.Name = "DgvStock";
            this.DgvStock.ReadOnly = true;
            this.DgvStock.RowHeadersVisible = false;
            this.DgvStock.Size = new System.Drawing.Size(965, 471);
            this.DgvStock.TabIndex = 6;
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
            this.cboMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(227, 129);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(168, 28);
            this.cboMarca.TabIndex = 1;
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
            this.cborubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cborubro.FormattingEnabled = true;
            this.cborubro.Location = new System.Drawing.Point(36, 129);
            this.cborubro.Name = "cborubro";
            this.cborubro.Size = new System.Drawing.Size(168, 28);
            this.cborubro.TabIndex = 0;
            // 
            // rbtPorcentaje
            // 
            this.rbtPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtPorcentaje.AutoSize = true;
            this.rbtPorcentaje.Checked = true;
            this.rbtPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPorcentaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtPorcentaje.Location = new System.Drawing.Point(609, 131);
            this.rbtPorcentaje.Name = "rbtPorcentaje";
            this.rbtPorcentaje.Size = new System.Drawing.Size(107, 22);
            this.rbtPorcentaje.TabIndex = 2;
            this.rbtPorcentaje.TabStop = true;
            this.rbtPorcentaje.Text = "Porcentaje";
            this.rbtPorcentaje.UseVisualStyleBackColor = true;
            // 
            // RbtMonto
            // 
            this.RbtMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RbtMonto.AutoSize = true;
            this.RbtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtMonto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RbtMonto.Location = new System.Drawing.Point(731, 131);
            this.RbtMonto.Name = "RbtMonto";
            this.RbtMonto.Size = new System.Drawing.Size(74, 22);
            this.RbtMonto.TabIndex = 3;
            this.RbtMonto.TabStop = true;
            this.RbtMonto.Text = "Monto";
            this.RbtMonto.UseVisualStyleBackColor = true;
            // 
            // nupAumento
            // 
            this.nupAumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nupAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupAumento.Location = new System.Drawing.Point(811, 131);
            this.nupAumento.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nupAumento.Name = "nupAumento";
            this.nupAumento.Size = new System.Drawing.Size(93, 26);
            this.nupAumento.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(923, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = false;
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
            // lbAumento
            // 
            this.lbAumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAumento.AutoSize = true;
            this.lbAumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAumento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAumento.Location = new System.Drawing.Point(605, 103);
            this.lbAumento.Name = "lbAumento";
            this.lbAumento.Size = new System.Drawing.Size(85, 21);
            this.lbAumento.TabIndex = 23;
            this.lbAumento.Text = "Aumento";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestionVentasFrontend.Properties.Resources.inventario_disponible;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // idProd
            // 
            this.idProd.HeaderText = "Codigo Producto";
            this.idProd.Name = "idProd";
            this.idProd.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Rubro
            // 
            this.Rubro.HeaderText = "Rubro";
            this.Rubro.Name = "Rubro";
            this.Rubro.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // Stockmin
            // 
            this.Stockmin.HeaderText = "Stock Min.";
            this.Stockmin.Name = "Stockmin";
            this.Stockmin.ReadOnly = true;
            // 
            // Stockk
            // 
            this.Stockk.HeaderText = "Stock";
            this.Stockk.Name = "Stockk";
            this.Stockk.ReadOnly = true;
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "Seleccion";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.ReadOnly = true;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1047, 705);
            this.Controls.Add(this.lbAumento);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbAumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stockmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stockk;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
    }
}