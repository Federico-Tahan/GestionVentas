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
    public partial class ReportesForm : Form
    {
        Form FormActual;

        public ReportesForm()
        {
            InitializeComponent();
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnResumendeudasclientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormDuedadeClientes());
        }

        private void btngananciaxmarca_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormGananciaXMarca());

        }

        private void recaudacionfp_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormRecaudacionFP());

        }

        private void resumengananciaxrubro_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ReporteGananciasXRubro());

        }

        private void top10prod_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormReporteTopProductos());

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        public void AbrirFormEnPanel(Form Formhijo)
        {
            if (FormActual != null)
            {
                FormActual.Close();
            }
            FormActual = Formhijo;
            Formhijo.TopLevel = false;
            Formhijo.Dock = DockStyle.Fill;
            panel1.Visible = true;
            panel1.Controls.Add(Formhijo);
            panel1.Tag = Formhijo;
            Formhijo.BringToFront();
            Formhijo.Show();
        }
    }
}
