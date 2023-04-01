using GestionVentasFrontend.Formularios;
using GestionVentasFrontend.Formularios.Venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVentasFrontend
{
    public partial class Principal : Form
    {
                Form FormActual;

        public Principal()
        {
            InitializeComponent();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            submenu1.Visible = !submenu1.Visible;
            submenu2.Visible = false;
            pnlSubmenu3.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToLongTimeString();
            lbfecha.Text = DateTime.Now.ToString("dddd MMMM  yyyy");
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.lg.Close();
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
            pnlMain.Controls.Add(Formhijo);
            pnlMain.Tag = Formhijo;
            Formhijo.BringToFront();
            Formhijo.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            submenu1.Visible = false;
            submenu2.Visible = !submenu2.Visible;
            pnlSubmenu3.Visible = false;
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CrudCliente());

        }

        private void BtnHistorialPago_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new HistorialPago());

        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Stock());

        }

        private void BtnGestion_Click(object sender, EventArgs e)
        {
            submenu1.Visible = false;
            submenu2.Visible = false;
            pnlSubmenu3.Visible = !pnlSubmenu3.Visible;
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CrudProductos());

        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CrudUsuario());
        }

        private void PicLogoMAIN_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Remove(FormActual);
            submenu1.Visible = false;
            submenu2.Visible = false;
            pnlSubmenu3.Visible = false;
        }

        private void Principal_Resize(object sender, EventArgs e)
        {

        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Venta());
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ConsultarVentas());

        }
    }
}
