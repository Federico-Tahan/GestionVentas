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
    public partial class FormGananciaXMarca : Form
    {
        In_Reporte lg = new Inmp_Reporte();

        public FormGananciaXMarca()
        {
            InitializeComponent();
        }

        private void FormGananciaXMarca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataReport.SP_GeneradoXMarca' table. You can move, or remove it, as needed.
            this.sPGeneradoXMarcaBindingSource.DataSource = lg.GetGeneradoxMarca();

            this.reportViewer1.RefreshReport();
        }
    }
}
