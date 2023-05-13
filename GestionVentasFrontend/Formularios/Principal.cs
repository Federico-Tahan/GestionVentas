using GestionVentasBackend.Dominio;
using GestionVentasBackend.Dominio.ClasesReportes;
using GestionVentasFrontend.Formularios;
using GestionVentasFrontend.Formularios.Reportes;
using GestionVentasFrontend.Formularios.Venta;
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

namespace GestionVentasFrontend
{
    public partial class Principal : Form
    {
        Form FormActual;
        int count = 0;
        Ing_Inforprincipal lg = new ing_InfoPrincipal();
        ing_Configuracion lc = new ng_Configuracion();
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
            count++;

            lbhora.Text = DateTime.Now.ToLongTimeString();
            lbfecha.Text = DateTime.Now.ToString("dddd MMMM  yyyy");
            lbRecaudadoHoy.Text = lg.RecaudadoHoy().ToString();
            VentasdelDia.Text = lg.VentasDelDia().ToString();
            lbVentasdelMes.Text = lg.VentasDelMES().ToString();
            if (count == 250)
            {
                count = 0;
                if (lg.FaltaStock())
                {
                    BtnStock.Image = Properties.Resources.sss;
                }
                else
                {
                    BtnStock.Image = Properties.Resources.inventario_disponible;
                }
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Program.lg.Close();
            }
            else
            {
                // El formulario se está cerrando por otra razón (por ejemplo, mediante código)
                // No hagas nada aquí
            }
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

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ReportesForm());

        }

        private void picConfiguracion_Click(object sender, EventArgs e)
        {
            Configuracion c = new Configuracion();
            c.ShowDialog();
            SeleccionarColor();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            SeleccionarColor();
            lbUsuario.Text = Login.usuario.Emp.Nombre + " " + Login.usuario.Emp.Apellido;
            if (lg.FaltaStock())
            {
                BtnStock.Image = Properties.Resources.sss;
            }
            else
            {
                BtnStock.Image = Properties.Resources.inventario_disponible;
            }

            VerificarRoles();
        }

        private void lbCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Program.lg.Show();
            Login.usuario = new GestionVentasBackend.Dominio.Usuario();
        }




        public  void SeleccionarColor()
        {
            Config c = new Config();
            c = lc.TraerConfig();
            int tema = c.t.id_tema;
            string color = "#513b56";
            string color2 = "#45364b";

            if (tema == 1)
            {
                color = "#513b56";
                color2 = "#45364b";

            } else if (tema == 2) 
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






            pnlMain.BackColor = ColorTranslator.FromHtml(color);
            pnltopRecaudadoH.BackColor = Color.FromArgb(31, 31, 31);
            pnlBottomRecaudadoH.BackColor = Color.FromArgb(31, 31, 31);
            pnltopVentasDia.BackColor = Color.FromArgb(31, 31, 31);
            pnlBottomVentasDia.BackColor = Color.FromArgb(31, 31, 31);
            pnltopVentaMes.BackColor = Color.FromArgb(31, 31, 31);
            pnlBottomVentasMes.BackColor = Color.FromArgb(31, 31, 31);
            pnlMenu.BackColor = Color.FromArgb(31, 31, 31);
            panelInfolog.BackColor = Color.FromArgb(31, 31, 31);
            submenu1.BackColor = Color.FromArgb(31, 31, 31);
            submenu2.BackColor = Color.FromArgb(31, 31, 31);
            pnlSubmenu3.BackColor = Color.FromArgb(31, 31, 31);

            //Botones
            BtnVentas.BackColor = Color.FromArgb(31, 31, 31);
            BtnVentas.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(color2);

            BtnVender.BackColor = Color.FromArgb(31, 31, 31);
            BtnVender.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(color2);

            BtnConsultar.BackColor = Color.FromArgb(31, 31, 31);
            BtnConsultar.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(color2);

            BtnClientes.BackColor = Color.FromArgb(31, 31, 31);
            BtnClientes.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(color2);

            BtnCliente.BackColor = Color.FromArgb(31, 31, 31);
            BtnCliente.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(color2);

            BtnStock.BackColor = Color.FromArgb(31, 31, 31);
            BtnStock.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(color2);

            BtnGestion.BackColor = Color.FromArgb(31, 31, 31);
            BtnGestion.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(color2);

            BtnProducto.BackColor = Color.FromArgb(31, 31, 31);
            BtnProducto.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(color2);

            BtnUsuario.BackColor = Color.FromArgb(31, 31, 31);
            BtnUsuario.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(color2);

            BtnReportes.BackColor = Color.FromArgb(31, 31, 31);
            BtnReportes.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(color2);

            BtnHistorialPago.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(color2);

        }




        private void VerificarRoles() 
        {

            if (Login.usuario.rol.id_rol == 2) 
            {
                BtnGestion.Visible = false;
                lbRecaudadoHoy.Visible = false;
                VentasdelDia.Visible = false;
                lbVentasdelMes.Visible = false;
                picConfiguracion.Visible = false;
                BtnStock.Visible = false;
            }
        
        
        }
    }
}
