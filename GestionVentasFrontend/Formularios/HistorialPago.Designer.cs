namespace GestionVentasFrontend.Formularios
{
    partial class HistorialPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvHistPago = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCancelarPago = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.PicBajar = new System.Windows.Forms.PictureBox();
            this.cboDNI = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lbdeuda = new System.Windows.Forms.Label();
            this.nupDebe = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbprecio = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.nupPrecio = new System.Windows.Forms.NumericUpDown();
            this.id_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistPago)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBajar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDebe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvHistPago
            // 
            this.DgvHistPago.AllowUserToAddRows = false;
            this.DgvHistPago.AllowUserToDeleteRows = false;
            this.DgvHistPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvHistPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvHistPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHistPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.DgvHistPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pago,
            this.Cliente,
            this.FechaPago,
            this.Monto,
            this.Estado,
            this.Accion});
            this.DgvHistPago.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DgvHistPago.Location = new System.Drawing.Point(44, 145);
            this.DgvHistPago.Name = "DgvHistPago";
            this.DgvHistPago.ReadOnly = true;
            this.DgvHistPago.RowHeadersVisible = false;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvHistPago.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.DgvHistPago.Size = new System.Drawing.Size(965, 419);
            this.DgvHistPago.TabIndex = 7;
            this.DgvHistPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHistPago_CellContentClick);
            this.DgvHistPago.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvHistPago_CellFormatting);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 54);
            this.panel4.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuentas de Fiado";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::GestionVentasFrontend.Properties.Resources.Usuarios;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGuardar.Location = new System.Drawing.Point(815, 595);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(134, 52);
            this.BtnGuardar.TabIndex = 21;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelar.Location = new System.Drawing.Point(592, 595);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 52);
            this.BtnCancelar.TabIndex = 20;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCancelarPago
            // 
            this.BtnCancelarPago.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCancelarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnCancelarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelarPago.Enabled = false;
            this.BtnCancelarPago.FlatAppearance.BorderSize = 0;
            this.BtnCancelarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BtnCancelarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarPago.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelarPago.Location = new System.Drawing.Point(359, 595);
            this.BtnCancelarPago.Name = "BtnCancelarPago";
            this.BtnCancelarPago.Size = new System.Drawing.Size(134, 52);
            this.BtnCancelarPago.TabIndex = 19;
            this.BtnCancelarPago.Text = "Bajar Pago";
            this.BtnCancelarPago.UseVisualStyleBackColor = false;
            this.BtnCancelarPago.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNuevo.Location = new System.Drawing.Point(111, 595);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(134, 52);
            this.BtnNuevo.TabIndex = 18;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.pnlForm.Controls.Add(this.PicBajar);
            this.pnlForm.Controls.Add(this.cboDNI);
            this.pnlForm.Controls.Add(this.label8);
            this.pnlForm.Controls.Add(this.txbApellido);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.txbNombre);
            this.pnlForm.Controls.Add(this.lbdeuda);
            this.pnlForm.Controls.Add(this.nupDebe);
            this.pnlForm.Controls.Add(this.label6);
            this.pnlForm.Controls.Add(this.label5);
            this.pnlForm.Controls.Add(this.lbprecio);
            this.pnlForm.Controls.Add(this.lbnombre);
            this.pnlForm.Controls.Add(this.nupPrecio);
            this.pnlForm.Location = new System.Drawing.Point(44, 93);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(965, 471);
            this.pnlForm.TabIndex = 22;
            this.pnlForm.Visible = false;
            // 
            // PicBajar
            // 
            this.PicBajar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBajar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBajar.Image = global::GestionVentasFrontend.Properties.Resources.abajo;
            this.PicBajar.Location = new System.Drawing.Point(906, 3);
            this.PicBajar.Name = "PicBajar";
            this.PicBajar.Size = new System.Drawing.Size(56, 48);
            this.PicBajar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBajar.TabIndex = 62;
            this.PicBajar.TabStop = false;
            this.PicBajar.Click += new System.EventHandler(this.PicBajar_Click);
            // 
            // cboDNI
            // 
            this.cboDNI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDNI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDNI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDNI.FormattingEnabled = true;
            this.cboDNI.Location = new System.Drawing.Point(69, 223);
            this.cboDNI.Name = "cboDNI";
            this.cboDNI.Size = new System.Drawing.Size(168, 28);
            this.cboDNI.TabIndex = 61;
            this.cboDNI.SelectionChangeCommitted += new System.EventHandler(this.cboDNI_SelectionChangeCommitted);
            this.cboDNI.SelectedValueChanged += new System.EventHandler(this.cboDNI_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(213, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 60;
            this.label8.Text = "Apellido";
            // 
            // txbApellido
            // 
            this.txbApellido.Enabled = false;
            this.txbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellido.Location = new System.Drawing.Point(217, 31);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(174, 26);
            this.txbApellido.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(14, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "Nombre";
            // 
            // txbNombre
            // 
            this.txbNombre.Enabled = false;
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(18, 31);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(174, 26);
            this.txbNombre.TabIndex = 56;
            // 
            // lbdeuda
            // 
            this.lbdeuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbdeuda.AutoSize = true;
            this.lbdeuda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdeuda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbdeuda.Location = new System.Drawing.Point(655, 194);
            this.lbdeuda.Name = "lbdeuda";
            this.lbdeuda.Size = new System.Drawing.Size(62, 19);
            this.lbdeuda.TabIndex = 55;
            this.lbdeuda.Text = "Deuda";
            // 
            // nupDebe
            // 
            this.nupDebe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nupDebe.DecimalPlaces = 2;
            this.nupDebe.Enabled = false;
            this.nupDebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupDebe.Location = new System.Drawing.Point(659, 222);
            this.nupDebe.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nupDebe.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.nupDebe.Name = "nupDebe";
            this.nupDebe.Size = new System.Drawing.Size(112, 26);
            this.nupDebe.TabIndex = 54;
            this.nupDebe.ThousandsSeparator = true;
            this.nupDebe.Value = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(438, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 19);
            this.label6.TabIndex = 53;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(101, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 19);
            this.label5.TabIndex = 52;
            this.label5.Text = "*";
            // 
            // lbprecio
            // 
            this.lbprecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbprecio.AutoSize = true;
            this.lbprecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbprecio.Location = new System.Drawing.Point(382, 195);
            this.lbprecio.Name = "lbprecio";
            this.lbprecio.Size = new System.Drawing.Size(57, 19);
            this.lbprecio.TabIndex = 51;
            this.lbprecio.Text = "Monto";
            // 
            // lbnombre
            // 
            this.lbnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbnombre.Location = new System.Drawing.Point(65, 200);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(36, 19);
            this.lbnombre.TabIndex = 50;
            this.lbnombre.Text = "DNI";
            // 
            // nupPrecio
            // 
            this.nupPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nupPrecio.DecimalPlaces = 2;
            this.nupPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPrecio.Location = new System.Drawing.Point(386, 223);
            this.nupPrecio.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nupPrecio.Name = "nupPrecio";
            this.nupPrecio.Size = new System.Drawing.Size(112, 26);
            this.nupPrecio.TabIndex = 49;
            this.nupPrecio.ThousandsSeparator = true;
            // 
            // id_pago
            // 
            this.id_pago.HeaderText = "Codigo Pago";
            this.id_pago.Name = "id_pago";
            this.id_pago.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Nombre Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // FechaPago
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaPago.DefaultCellStyle = dataGridViewCellStyle17;
            this.FechaPago.HeaderText = "Fecha Pago";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.ReadOnly = true;
            // 
            // Monto
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Monto.DefaultCellStyle = dataGridViewCellStyle18;
            this.Monto.HeaderText = "Monto de pago";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Estado
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle19;
            this.Estado.FillWeight = 80F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Accion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Accion.Text = "Detalle";
            this.Accion.UseColumnTextForButtonValue = true;
            // 
            // HistorialPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(1064, 702);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCancelarPago);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.DgvHistPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistorialPago";
            this.Text = "HistorialPago";
            this.Load += new System.EventHandler(this.HistorialPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistPago)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBajar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDebe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvHistPago;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCancelarPago;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lbdeuda;
        private System.Windows.Forms.NumericUpDown nupDebe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbprecio;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.NumericUpDown nupPrecio;
        private System.Windows.Forms.ComboBox cboDNI;
        private System.Windows.Forms.PictureBox PicBajar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
    }
}