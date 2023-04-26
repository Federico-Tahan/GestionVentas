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
    public partial class FormDuedadeClientes : Form
    {
        In_Reporte lg = new Inmp_Reporte();

        public FormDuedadeClientes()
        {
            InitializeComponent();
        }

        private void FormDuedadeClientes_Load(object sender, EventArgs e)
        {
            this.sPDeudasClientesBindingSource.DataSource = lg.DeudaCliente();
            this.reportViewer1.RefreshReport();
        }
    }
}
