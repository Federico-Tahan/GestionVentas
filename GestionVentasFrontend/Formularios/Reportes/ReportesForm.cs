using GestionVentasBackend.Dominio;
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
    public partial class ReportesForm : Form
    {
        Form FormActual;

        public ReportesForm()
        {
            InitializeComponent();
            SeleccionarColor();
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
            AbrirFormEnPanel(new GeneradoxMesxeMPLEADO());

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
            panel2.Visible = false;
            Formhijo.BringToFront();
            Formhijo.Show();
        }

        ing_Configuracion lv = new ng_Configuracion();

        private void SeleccionarColor()
        {
            Config c = new Config();
            c = lv.TraerConfig();
            int tema = c.t.id_tema;
            string color = "#513b56";
            string color2 = "#45364b";

            if (tema == 1)
            {
                color = "#513b56";
                color2 = "#45364b";

            }
            else if (tema == 2)
            {
                color = "#469d89";

            }
            else if (tema == 3)
            {
                color = "#adb5bd";

            }
            else if (tema == 4)
            {
                color = "#212529";

            }

            this.BackColor = ColorTranslator.FromHtml(color);

        }
        private void label1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormGananciaXMarca());

        }

        private void label4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormReporteTopProductos());

        }

        private void label2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormRecaudacionFP());

        }

        private void label5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new GeneradoxMesxeMPLEADO());

        }

        private void label3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ReporteGananciasXRubro());

        }

        private void lbnombre_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormDuedadeClientes());

        }
    }
}
