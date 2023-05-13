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
    public partial class GeneradoxMesxeMPLEADO : Form
    {
        public GeneradoxMesxeMPLEADO()
        {
            InitializeComponent();
        }

        private void GeneradoxMesxeMPLEADO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataReport.SP_GeneradoxEmpleado' table. You can move, or remove it, as needed.
            this.sP_GeneradoxEmpleadoTableAdapter.Fill(this.dataReport.SP_GeneradoxEmpleado);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
