namespace GestionVentasFrontend.Formularios
{
    partial class CrudUsuario
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
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lbLocalidad = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.nupPrecio = new System.Windows.Forms.NumericUpDown();
            this.nupAltura = new System.Windows.Forms.NumericUpDown();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.lbDepartament = new System.Windows.Forms.Label();
            this.txbDepartament = new System.Windows.Forms.TextBox();
            this.lbDni = new System.Windows.Forms.Label();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.lbcalle = new System.Windows.Forms.Label();
            this.txbCalle = new System.Windows.Forms.TextBox();
            this.lbAlias = new System.Windows.Forms.Label();
            this.txbAlias = new System.Windows.Forms.TextBox();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.lbAltura = new System.Windows.Forms.Label();
            this.lbPiso = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dpto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PicLimpiar = new System.Windows.Forms.PictureBox();
            this.PicBajar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBajar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 54);
            this.panel4.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios";
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nombre,
            this.Alias,
            this.Localidad,
            this.Calle,
            this.altura,
            this.Piso,
            this.Dpto,
            this.Telefono,
            this.Activo,
            this.Accion});
            this.DgvUsuarios.Location = new System.Drawing.Point(16, 133);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowHeadersVisible = false;
            this.DgvUsuarios.Size = new System.Drawing.Size(993, 440);
            this.DgvUsuarios.TabIndex = 11;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGuardar.Location = new System.Drawing.Point(809, 601);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(134, 52);
            this.BtnGuardar.TabIndex = 17;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelar.Location = new System.Drawing.Point(586, 601);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 52);
            this.BtnCancelar.TabIndex = 16;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEditar.Location = new System.Drawing.Point(353, 601);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(134, 52);
            this.BtnEditar.TabIndex = 15;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
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
            this.BtnNuevo.Location = new System.Drawing.Point(105, 601);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(134, 52);
            this.BtnNuevo.TabIndex = 14;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForm.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlForm.Controls.Add(this.label10);
            this.pnlForm.Controls.Add(this.label9);
            this.pnlForm.Controls.Add(this.label8);
            this.pnlForm.Controls.Add(this.label7);
            this.pnlForm.Controls.Add(this.label6);
            this.pnlForm.Controls.Add(this.label5);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.lbEmail);
            this.pnlForm.Controls.Add(this.txbEmail);
            this.pnlForm.Controls.Add(this.lbPiso);
            this.pnlForm.Controls.Add(this.lbAltura);
            this.pnlForm.Controls.Add(this.lbContraseña);
            this.pnlForm.Controls.Add(this.txbContraseña);
            this.pnlForm.Controls.Add(this.lbAlias);
            this.pnlForm.Controls.Add(this.txbAlias);
            this.pnlForm.Controls.Add(this.lbcalle);
            this.pnlForm.Controls.Add(this.txbCalle);
            this.pnlForm.Controls.Add(this.lbDni);
            this.pnlForm.Controls.Add(this.txbDni);
            this.pnlForm.Controls.Add(this.lbDepartament);
            this.pnlForm.Controls.Add(this.txbDepartament);
            this.pnlForm.Controls.Add(this.lbTelefono);
            this.pnlForm.Controls.Add(this.txbTelefono);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.textBox1);
            this.pnlForm.Controls.Add(this.PicLimpiar);
            this.pnlForm.Controls.Add(this.PicBajar);
            this.pnlForm.Controls.Add(this.lbLocalidad);
            this.pnlForm.Controls.Add(this.lbnombre);
            this.pnlForm.Controls.Add(this.chkActivo);
            this.pnlForm.Controls.Add(this.nupAltura);
            this.pnlForm.Controls.Add(this.nupPrecio);
            this.pnlForm.Controls.Add(this.cboLocalidad);
            this.pnlForm.Controls.Add(this.txbNombre);
            this.pnlForm.Location = new System.Drawing.Point(16, 60);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1007, 513);
            this.pnlForm.TabIndex = 18;
            this.pnlForm.Visible = false;
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbLocalidad.Location = new System.Drawing.Point(58, 184);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(88, 19);
            this.lbLocalidad.TabIndex = 13;
            this.lbLocalidad.Text = "Localidad";
            // 
            // lbnombre
            // 
            this.lbnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbnombre.Location = new System.Drawing.Point(58, 88);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(73, 19);
            this.lbnombre.TabIndex = 11;
            this.lbnombre.Text = "Nombre";
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(62, 206);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(168, 28);
            this.cboLocalidad.TabIndex = 3;
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(62, 110);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(174, 26);
            this.txbNombre.TabIndex = 0;
            // 
            // nupPrecio
            // 
            this.nupPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nupPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPrecio.Location = new System.Drawing.Point(609, 206);
            this.nupPrecio.Name = "nupPrecio";
            this.nupPrecio.Size = new System.Drawing.Size(71, 26);
            this.nupPrecio.TabIndex = 5;
            // 
            // nupAltura
            // 
            this.nupAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nupAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupAltura.Location = new System.Drawing.Point(510, 206);
            this.nupAltura.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nupAltura.Name = "nupAltura";
            this.nupAltura.Size = new System.Drawing.Size(65, 26);
            this.nupAltura.TabIndex = 7;
            // 
            // chkActivo
            // 
            this.chkActivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.ForeColor = System.Drawing.Color.AliceBlue;
            this.chkActivo.Location = new System.Drawing.Point(531, 408);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(77, 24);
            this.chkActivo.TabIndex = 9;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(293, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Apellido";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(297, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 26);
            this.textBox1.TabIndex = 22;
            // 
            // lbTelefono
            // 
            this.lbTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTelefono.Location = new System.Drawing.Point(58, 285);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(74, 19);
            this.lbTelefono.TabIndex = 25;
            this.lbTelefono.Text = "Telefono";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefono.Location = new System.Drawing.Point(62, 307);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(174, 26);
            this.txbTelefono.TabIndex = 24;
            // 
            // lbDepartament
            // 
            this.lbDepartament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDepartament.AutoSize = true;
            this.lbDepartament.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDepartament.Location = new System.Drawing.Point(713, 183);
            this.lbDepartament.Name = "lbDepartament";
            this.lbDepartament.Size = new System.Drawing.Size(122, 19);
            this.lbDepartament.TabIndex = 27;
            this.lbDepartament.Text = "Departamento";
            // 
            // txbDepartament
            // 
            this.txbDepartament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbDepartament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDepartament.Location = new System.Drawing.Point(717, 205);
            this.txbDepartament.Name = "txbDepartament";
            this.txbDepartament.Size = new System.Drawing.Size(118, 26);
            this.txbDepartament.TabIndex = 26;
            // 
            // lbDni
            // 
            this.lbDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDni.Location = new System.Drawing.Point(539, 88);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(36, 19);
            this.lbDni.TabIndex = 29;
            this.lbDni.Text = "DNI";
            // 
            // txbDni
            // 
            this.txbDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDni.Location = new System.Drawing.Point(543, 110);
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(174, 26);
            this.txbDni.TabIndex = 28;
            // 
            // lbcalle
            // 
            this.lbcalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcalle.AutoSize = true;
            this.lbcalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbcalle.Location = new System.Drawing.Point(293, 186);
            this.lbcalle.Name = "lbcalle";
            this.lbcalle.Size = new System.Drawing.Size(50, 19);
            this.lbcalle.TabIndex = 31;
            this.lbcalle.Text = "Calle";
            // 
            // txbCalle
            // 
            this.txbCalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCalle.Location = new System.Drawing.Point(297, 208);
            this.txbCalle.Name = "txbCalle";
            this.txbCalle.Size = new System.Drawing.Size(174, 26);
            this.txbCalle.TabIndex = 30;
            // 
            // lbAlias
            // 
            this.lbAlias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAlias.AutoSize = true;
            this.lbAlias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAlias.Location = new System.Drawing.Point(61, 386);
            this.lbAlias.Name = "lbAlias";
            this.lbAlias.Size = new System.Drawing.Size(46, 19);
            this.lbAlias.TabIndex = 33;
            this.lbAlias.Text = "Alias";
            // 
            // txbAlias
            // 
            this.txbAlias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAlias.Location = new System.Drawing.Point(62, 408);
            this.txbAlias.Name = "txbAlias";
            this.txbAlias.Size = new System.Drawing.Size(174, 26);
            this.txbAlias.TabIndex = 32;
            // 
            // lbContraseña
            // 
            this.lbContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbContraseña.Location = new System.Drawing.Point(293, 386);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(73, 19);
            this.lbContraseña.TabIndex = 35;
            this.lbContraseña.Text = "Nombre";
            // 
            // txbContraseña
            // 
            this.txbContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContraseña.Location = new System.Drawing.Point(297, 408);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(174, 26);
            this.txbContraseña.TabIndex = 34;
            // 
            // lbAltura
            // 
            this.lbAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAltura.AutoSize = true;
            this.lbAltura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAltura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAltura.Location = new System.Drawing.Point(506, 184);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(55, 19);
            this.lbAltura.TabIndex = 36;
            this.lbAltura.Text = "Altura";
            // 
            // lbPiso
            // 
            this.lbPiso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPiso.AutoSize = true;
            this.lbPiso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPiso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPiso.Location = new System.Drawing.Point(605, 184);
            this.lbPiso.Name = "lbPiso";
            this.lbPiso.Size = new System.Drawing.Size(38, 19);
            this.lbPiso.TabIndex = 37;
            this.lbPiso.Text = "Piso";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEmail.Location = new System.Drawing.Point(293, 285);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 19);
            this.lbEmail.TabIndex = 39;
            this.lbEmail.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(297, 307);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(174, 26);
            this.txbEmail.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(137, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(374, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(579, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(152, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 19);
            this.label6.TabIndex = 43;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(346, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(559, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 19);
            this.label8.TabIndex = 45;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(106, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(362, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 19);
            this.label10.TabIndex = 47;
            this.label10.Text = "*";
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
            this.button1.Location = new System.Drawing.Point(913, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Localidad";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Completo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Alias
            // 
            this.Alias.HeaderText = "Alias";
            this.Alias.Name = "Alias";
            this.Alias.ReadOnly = true;
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            // 
            // Calle
            // 
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            // 
            // altura
            // 
            this.altura.HeaderText = "Altura";
            this.altura.Name = "altura";
            this.altura.ReadOnly = true;
            // 
            // Piso
            // 
            this.Piso.HeaderText = "Piso";
            this.Piso.Name = "Piso";
            this.Piso.ReadOnly = true;
            // 
            // Dpto
            // 
            this.Dpto.HeaderText = "Dpto.";
            this.Dpto.Name = "Dpto";
            this.Dpto.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
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
            // CrudUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1047, 705);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrudUsuario";
            this.Text = "CrudUsuario";
            this.Load += new System.EventHandler(this.CrudUsuario_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBajar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.PictureBox PicLimpiar;
        private System.Windows.Forms.PictureBox PicBajar;
        private System.Windows.Forms.Label lbLocalidad;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.ComboBox cboLocalidad;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Label lbAlias;
        private System.Windows.Forms.TextBox txbAlias;
        private System.Windows.Forms.Label lbcalle;
        private System.Windows.Forms.TextBox txbCalle;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.Label lbDepartament;
        private System.Windows.Forms.TextBox txbDepartament;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.NumericUpDown nupAltura;
        private System.Windows.Forms.NumericUpDown nupPrecio;
        private System.Windows.Forms.Label lbPiso;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dpto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
    }
}