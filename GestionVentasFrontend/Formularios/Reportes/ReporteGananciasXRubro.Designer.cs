namespace GestionVentasFrontend.Formularios.Reportes
{
    partial class ReporteGananciasXRubro
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
            this.sPGeneradoXRubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataReport = new GestionVentasFrontend.Formularios.Reportes.DataReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_GeneradoXRubroTableAdapter = new GestionVentasFrontend.Formularios.Reportes.DataReportTableAdapters.SP_GeneradoXRubroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPGeneradoXRubroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).BeginInit();
            this.SuspendLayout();
            // 
            // sPGeneradoXRubroBindingSource
            // 
            this.sPGeneradoXRubroBindingSource.DataMember = "SP_GeneradoXRubro";
            this.sPGeneradoXRubroBindingSource.DataSource = this.dataReportBindingSource;
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
            this.reportViewer1.DocumentMapWidth = 29;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPGeneradoXRubroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionVentasFrontend.Formularios.Reportes.ReportGananciaXRubro.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(892, 560);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // sP_GeneradoXRubroTableAdapter
            // 
            this.sP_GeneradoXRubroTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteGananciasXRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 560);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteGananciasXRubro";
            this.Text = "ReporteGananciasXRubro";
            this.Load += new System.EventHandler(this.ReporteGananciasXRubro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPGeneradoXRubroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataReport dataReport;
        private System.Windows.Forms.BindingSource dataReportBindingSource;
        private System.Windows.Forms.BindingSource sPGeneradoXRubroBindingSource;
        private DataReportTableAdapters.SP_GeneradoXRubroTableAdapter sP_GeneradoXRubroTableAdapter;
    }
}