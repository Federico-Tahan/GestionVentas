namespace GestionVentasFrontend.Formularios.Reportes
{
    partial class FormRecaudacionFP
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sPReporteRecaudacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataReport = new GestionVentasFrontend.Formularios.Reportes.DataReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_Reporte_RecaudacionTableAdapter = new GestionVentasFrontend.Formularios.Reportes.DataReportTableAdapters.SP_Reporte_RecaudacionTableAdapter();
            this.cboFp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RbtDiario = new System.Windows.Forms.RadioButton();
            this.RbtMensual = new System.Windows.Forms.RadioButton();
            this.RbtAnual = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteRecaudacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sPReporteRecaudacionBindingSource
            // 
            this.sPReporteRecaudacionBindingSource.DataMember = "SP_Reporte_Recaudacion";
            this.sPReporteRecaudacionBindingSource.DataSource = this.dataReportBindingSource;
            // 
            // dataReportBindingSource
            // 
            this.dataReportBindingSource.DataSource = this.dataReport;
            this.dataReportBindingSource.Position = 0;
            // 
            // dataReport
            // 
            this.dataReport.DataSetName = "DataReport";
            this.dataReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 35;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.sPReporteRecaudacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionVentasFrontend.Formularios.Reportes.ReportRecaudacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowPrintButton = false;
            this.reportViewer1.ShowProgress = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(992, 585);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // sP_Reporte_RecaudacionTableAdapter
            // 
            this.sP_Reporte_RecaudacionTableAdapter.ClearBeforeFill = true;
            // 
            // cboFp
            // 
            this.cboFp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFp.FormattingEnabled = true;
            this.cboFp.Items.AddRange(new object[] {
            "<<Todas las Formas de Pago>>"});
            this.cboFp.Location = new System.Drawing.Point(12, 51);
            this.cboFp.Name = "cboFp";
            this.cboFp.Size = new System.Drawing.Size(167, 24);
            this.cboFp.TabIndex = 1;
            this.cboFp.SelectionChangeCommitted += new System.EventHandler(this.cboFp_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Forma de Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(205, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de Fecha";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RbtDiario);
            this.panel1.Controls.Add(this.RbtMensual);
            this.panel1.Controls.Add(this.RbtAnual);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboFp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 91);
            this.panel1.TabIndex = 5;
            // 
            // RbtDiario
            // 
            this.RbtDiario.AutoSize = true;
            this.RbtDiario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtDiario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtDiario.Location = new System.Drawing.Point(357, 54);
            this.RbtDiario.Name = "RbtDiario";
            this.RbtDiario.Size = new System.Drawing.Size(64, 21);
            this.RbtDiario.TabIndex = 7;
            this.RbtDiario.Text = "Diario";
            this.RbtDiario.UseVisualStyleBackColor = true;
            this.RbtDiario.CheckedChanged += new System.EventHandler(this.RbtDiario_CheckedChanged);
            // 
            // RbtMensual
            // 
            this.RbtMensual.AutoSize = true;
            this.RbtMensual.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtMensual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtMensual.Location = new System.Drawing.Point(273, 54);
            this.RbtMensual.Name = "RbtMensual";
            this.RbtMensual.Size = new System.Drawing.Size(78, 21);
            this.RbtMensual.TabIndex = 6;
            this.RbtMensual.Text = "Mensual";
            this.RbtMensual.UseVisualStyleBackColor = true;
            this.RbtMensual.CheckedChanged += new System.EventHandler(this.RbtMensual_CheckedChanged);
            // 
            // RbtAnual
            // 
            this.RbtAnual.AutoSize = true;
            this.RbtAnual.Checked = true;
            this.RbtAnual.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtAnual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtAnual.Location = new System.Drawing.Point(204, 54);
            this.RbtAnual.Name = "RbtAnual";
            this.RbtAnual.Size = new System.Drawing.Size(63, 21);
            this.RbtAnual.TabIndex = 5;
            this.RbtAnual.TabStop = true;
            this.RbtAnual.Text = "Anual";
            this.RbtAnual.UseVisualStyleBackColor = true;
            this.RbtAnual.CheckedChanged += new System.EventHandler(this.RbtAnual_CheckedChanged);
            // 
            // FormRecaudacionFP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(67)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(992, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRecaudacionFP";
            this.Text = "FormRecaudacionFP";
            this.Load += new System.EventHandler(this.FormRecaudacionFP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteRecaudacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPReporteRecaudacionBindingSource;
        private System.Windows.Forms.BindingSource dataReportBindingSource;
        private DataReport dataReport;
        private DataReportTableAdapters.SP_Reporte_RecaudacionTableAdapter sP_Reporte_RecaudacionTableAdapter;
        private System.Windows.Forms.ComboBox cboFp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RbtDiario;
        private System.Windows.Forms.RadioButton RbtMensual;
        private System.Windows.Forms.RadioButton RbtAnual;
    }
}