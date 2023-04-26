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
    public partial class ReporteGananciasXRubro : Form
    {
        In_Reporte lg = new Inmp_Reporte();

        public ReporteGananciasXRubro()
        {
            InitializeComponent();
        }

        private void ReporteGananciasXRubro_Load(object sender, EventArgs e)
        {
            this.sPGeneradoXRubroBindingSource.DataSource = lg.GetGeneradoxRubro();
            this.reportViewer1.RefreshReport();
        }
    }
}
