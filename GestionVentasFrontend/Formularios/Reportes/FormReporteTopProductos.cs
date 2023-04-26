using GestionVentasBackend.Dominio.ClasesReportes;
using GestionVentasNegocio.Implementacion;
using GestionVentasNegocio.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVentasFrontend.Formularios.Reportes
{
    public partial class FormReporteTopProductos : Form
    {
        In_Reporte lg  = new Inmp_Reporte();
        public FormReporteTopProductos()
        {
            InitializeComponent();
        }

        private void FormReporteTopProductos_Load(object sender, EventArgs e)
        {
            List<TOP10PRODUCTOS> a = new List<TOP10PRODUCTOS>();
            a = lg.GetProductos();
            this.sPReporteTOPproductosBindingSource.DataSource = a;
            this.reportViewer1.RefreshReport();
        }
    }
}
