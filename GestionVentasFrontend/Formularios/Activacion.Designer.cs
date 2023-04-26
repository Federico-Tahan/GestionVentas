namespace GestionVentasFrontend.Formularios
{
    partial class Activacion
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
            this.label8 = new System.Windows.Forms.Label();
            this.BtnActivar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnkey = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(216, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Clave de Activacion";
            // 
            // BtnActivar
            // 
            this.BtnActivar.Location = new System.Drawing.Point(260, 148);
            this.BtnActivar.Name = "BtnActivar";
            this.BtnActivar.Size = new System.Drawing.Size(76, 35);
            this.BtnActivar.TabIndex = 14;
            this.BtnActivar.Text = "Activar";
            this.BtnActivar.UseVisualStyleBackColor = true;
            this.BtnActivar.Click += new System.EventHandler(this.BtnActivar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(127, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 26);
            this.textBox1.TabIndex = 13;
            // 
            // btnkey
            // 
            this.btnkey.Location = new System.Drawing.Point(511, 5);
            this.btnkey.Name = "btnkey";
            this.btnkey.Size = new System.Drawing.Size(76, 35);
            this.btnkey.TabIndex = 16;
            this.btnkey.Text = "Generar Key";
            this.btnkey.UseVisualStyleBackColor = true;
            this.btnkey.Click += new System.EventHandler(this.btnkey_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionVentasFrontend.Properties.Resources.image1;
            this.pictureBox1.Location = new System.Drawing.Point(386, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Activacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(592, 252);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnkey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnActivar);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Activacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activacion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnActivar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnkey;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}