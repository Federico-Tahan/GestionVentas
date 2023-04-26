namespace GestionVentasFrontend.Formularios.Reportes
{
    partial class FormReporteTopProductos
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
            this.sPReporteTOPproductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataReport = new GestionVentasFrontend.Formularios.Reportes.DataReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_ReporteTOPproductosTableAdapter = new GestionVentasFrontend.Formularios.Reportes.DataReportTableAdapters.SP_ReporteTOPproductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteTOPproductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).BeginInit();
            this.SuspendLayout();
            // 
            // sPReporteTOPproductosBindingSource
            // 
            this.sPReporteTOPproductosBindingSource.DataMember = "SP_ReporteTOPproductos";
            this.sPReporteTOPproductosBindingSource.DataSource = this.dataReportBindingSource;
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
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPReporteTOPproductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionVentasFrontend.Formularios.Reportes.ReportTopProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(1009, 643);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // sP_ReporteTOPproductosTableAdapter
            // 
            this.sP_ReporteTOPproductosTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteTopProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 643);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteTopProductos";
            this.Text = "FormReporteTopProductos";
            this.Load += new System.EventHandler(this.FormReporteTopProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteTOPproductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataReport dataReport;
        private System.Windows.Forms.BindingSource dataReportBindingSource;
        private System.Windows.Forms.BindingSource sPReporteTOPproductosBindingSource;
        private DataReportTableAdapters.SP_ReporteTOPproductosTableAdapter sP_ReporteTOPproductosTableAdapter;
    }
}