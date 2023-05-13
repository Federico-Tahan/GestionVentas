namespace GestionVentasFrontend.Formularios.Reportes
{
    partial class GeneradoxMesxeMPLEADO
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sPGeneradoxEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataReport = new GestionVentasFrontend.Formularios.Reportes.DataReport();
            this.dataReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GeneradoxEmpleadoTableAdapter = new GestionVentasFrontend.Formularios.Reportes.DataReportTableAdapters.SP_GeneradoxEmpleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPGeneradoxEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPGeneradoxEmpleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionVentasFrontend.Formularios.Reportes.GeneradoxEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(902, 577);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // sPGeneradoxEmpleadoBindingSource
            // 
            this.sPGeneradoxEmpleadoBindingSource.DataMember = "SP_GeneradoxEmpleado";
            this.sPGeneradoxEmpleadoBindingSource.DataSource = this.dataReportBindingSource;
            // 
            // dataReport
            // 
            this.dataReport.DataSetName = "DataReport";
            this.dataReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataReportBindingSource
            // 
            this.dataReportBindingSource.DataSource = this.dataReport;
            this.dataReportBindingSource.Position = 0;
            // 
            // sP_GeneradoxEmpleadoTableAdapter
            // 
            this.sP_GeneradoxEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // GeneradoxMesxeMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 577);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneradoxMesxeMPLEADO";
            this.Text = "GeneradoxMesxeMPLEADO";
            this.Load += new System.EventHandler(this.GeneradoxMesxeMPLEADO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPGeneradoxEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataReport dataReport;
        private System.Windows.Forms.BindingSource dataReportBindingSource;
        private System.Windows.Forms.BindingSource sPGeneradoxEmpleadoBindingSource;
        private DataReportTableAdapters.SP_GeneradoxEmpleadoTableAdapter sP_GeneradoxEmpleadoTableAdapter;
    }
}