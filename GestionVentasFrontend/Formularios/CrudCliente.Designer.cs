namespace GestionVentasFrontend.Formularios
{
    partial class CrudCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lbDni = new System.Windows.Forms.Label();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbapellido = new System.Windows.Forms.TextBox();
            this.PicLimpiar = new System.Windows.Forms.PictureBox();
            this.PicBajar = new System.Windows.Forms.PictureBox();
            this.lbnombre = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.RbtDNI = new System.Windows.Forms.RadioButton();
            this.TxbBuscar = new System.Windows.Forms.TextBox();
            this.RbtNombre = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBajar)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            this.DgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.NombreCompleto,
            this.TELEFONO,
            this.Email,
            this.Deuda,
            this.Accion});
            this.DgvClientes.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DgvClientes.Location = new System.Drawing.Point(41, 128);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvClientes.Size = new System.Drawing.Size(965, 471);
            this.DgvClientes.TabIndex = 7;
            this.DgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellContentClick);
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "DNI";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "Telefono";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Deuda
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Deuda.DefaultCellStyle = dataGridViewCellStyle2;
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            this.Deuda.ReadOnly = true;
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
            this.BtnGuardar.Location = new System.Drawing.Point(803, 624);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(134, 52);
            this.BtnGuardar.TabIndex = 17;
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
            this.BtnCancelar.Location = new System.Drawing.Point(580, 624);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 52);
            this.BtnCancelar.TabIndex = 16;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.Enabled = false;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEditar.Location = new System.Drawing.Point(347, 624);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(134, 52);
            this.BtnEditar.TabIndex = 15;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
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
            this.BtnNuevo.Location = new System.Drawing.Point(105, 624);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(134, 52);
            this.BtnNuevo.TabIndex = 14;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 54);
            this.panel4.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
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
            // pnlForm
            // 
            this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.pnlForm.Controls.Add(this.label5);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.lbEmail);
            this.pnlForm.Controls.Add(this.txbEmail);
            this.pnlForm.Controls.Add(this.lbDni);
            this.pnlForm.Controls.Add(this.txbDni);
            this.pnlForm.Controls.Add(this.lbTelefono);
            this.pnlForm.Controls.Add(this.txbTelefono);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.txbapellido);
            this.pnlForm.Controls.Add(this.PicLimpiar);
            this.pnlForm.Controls.Add(this.PicBajar);
            this.pnlForm.Controls.Add(this.lbnombre);
            this.pnlForm.Controls.Add(this.txbNombre);
            this.pnlForm.Location = new System.Drawing.Point(20, 77);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1007, 522);
            this.pnlForm.TabIndex = 19;
            this.pnlForm.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(546, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(374, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(137, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "*";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEmail.Location = new System.Drawing.Point(293, 263);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 19);
            this.lbEmail.TabIndex = 39;
            this.lbEmail.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(297, 285);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(174, 26);
            this.txbEmail.TabIndex = 9;
            // 
            // lbDni
            // 
            this.lbDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDni.Location = new System.Drawing.Point(506, 133);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(36, 19);
            this.lbDni.TabIndex = 29;
            this.lbDni.Text = "DNI";
            // 
            // txbDni
            // 
            this.txbDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDni.Location = new System.Drawing.Point(510, 155);
            this.txbDni.MaxLength = 8;
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(174, 26);
            this.txbDni.TabIndex = 2;
            this.txbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDni_KeyPress);
            // 
            // lbTelefono
            // 
            this.lbTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTelefono.Location = new System.Drawing.Point(58, 263);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(74, 19);
            this.lbTelefono.TabIndex = 25;
            this.lbTelefono.Text = "Telefono";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefono.Location = new System.Drawing.Point(62, 285);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(174, 26);
            this.txbTelefono.TabIndex = 8;
            this.txbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTelefono_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(293, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Apellido";
            // 
            // txbapellido
            // 
            this.txbapellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbapellido.Location = new System.Drawing.Point(297, 155);
            this.txbapellido.Name = "txbapellido";
            this.txbapellido.Size = new System.Drawing.Size(174, 26);
            this.txbapellido.TabIndex = 1;
            // 
            // PicLimpiar
            // 
            this.PicLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicLimpiar.Image = global::GestionVentasFrontend.Properties.Resources.limpieza_de_datos;
            this.PicLimpiar.Location = new System.Drawing.Point(878, 3);
            this.PicLimpiar.Name = "PicLimpiar";
            this.PicLimpiar.Size = new System.Drawing.Size(56, 48);
            this.PicLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLimpiar.TabIndex = 21;
            this.PicLimpiar.TabStop = false;
            this.PicLimpiar.Click += new System.EventHandler(this.PicLimpiar_Click);
            // 
            // PicBajar
            // 
            this.PicBajar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBajar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBajar.Image = global::GestionVentasFrontend.Properties.Resources.abajo;
            this.PicBajar.Location = new System.Drawing.Point(948, 3);
            this.PicBajar.Name = "PicBajar";
            this.PicBajar.Size = new System.Drawing.Size(56, 48);
            this.PicBajar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBajar.TabIndex = 20;
            this.PicBajar.TabStop = false;
            this.PicBajar.Click += new System.EventHandler(this.PicBajar_Click);
            // 
            // lbnombre
            // 
            this.lbnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbnombre.Location = new System.Drawing.Point(58, 133);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(73, 19);
            this.lbnombre.TabIndex = 11;
            this.lbnombre.Text = "Nombre";
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(62, 155);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(174, 26);
            this.txbNombre.TabIndex = 0;
            // 
            // RbtDNI
            // 
            this.RbtDNI.AutoSize = true;
            this.RbtDNI.Checked = true;
            this.RbtDNI.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtDNI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RbtDNI.Location = new System.Drawing.Point(41, 101);
            this.RbtDNI.Name = "RbtDNI";
            this.RbtDNI.Size = new System.Drawing.Size(60, 22);
            this.RbtDNI.TabIndex = 20;
            this.RbtDNI.TabStop = true;
            this.RbtDNI.Text = "DNI";
            this.RbtDNI.UseVisualStyleBackColor = true;
            // 
            // TxbBuscar
            // 
            this.TxbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbBuscar.Location = new System.Drawing.Point(207, 99);
            this.TxbBuscar.Name = "TxbBuscar";
            this.TxbBuscar.Size = new System.Drawing.Size(158, 26);
            this.TxbBuscar.TabIndex = 21;
            this.TxbBuscar.TextChanged += new System.EventHandler(this.TxbBuscar_TextChanged);
            // 
            // RbtNombre
            // 
            this.RbtNombre.AutoSize = true;
            this.RbtNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RbtNombre.Location = new System.Drawing.Point(105, 101);
            this.RbtNombre.Name = "RbtNombre";
            this.RbtNombre.Size = new System.Drawing.Size(96, 22);
            this.RbtNombre.TabIndex = 22;
            this.RbtNombre.Text = "Nombre";
            this.RbtNombre.UseVisualStyleBackColor = true;
            // 
            // CrudCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(59)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1047, 705);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.RbtNombre);
            this.Controls.Add(this.TxbBuscar);
            this.Controls.Add(this.RbtDNI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrudCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.CrudCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBajar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbapellido;
        private System.Windows.Forms.PictureBox PicLimpiar;
        private System.Windows.Forms.PictureBox PicBajar;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
        private System.Windows.Forms.RadioButton RbtDNI;
        private System.Windows.Forms.TextBox TxbBuscar;
        private System.Windows.Forms.RadioButton RbtNombre;
    }
}