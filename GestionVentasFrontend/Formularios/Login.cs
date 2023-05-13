using GestionVentasBackend.Datos.Implementacion;
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

namespace GestionVentasFrontend
{
    public partial class Login : Form
    {
        Ing_Login lg = new Inmp_Login();
        ing_Configuracion lc = new ng_Configuracion();

        public static Usuario usuario = new Usuario();
         
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!lg.CheckLogin(txbalias.Text, txbcontraseña.Text))
            {
                MessageBox.Show("Usuario o contraseña incorrecto.", "Error de logeo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (lg.Logeado(usuario, txbalias.Text, txbcontraseña.Text))
            {
                txbalias.Text = "";
                txbcontraseña.Text = "";
                Principal principal = new Principal();
                principal.Show();
                this.Hide();
            }

        }

        private void piccontra_Click(object sender, EventArgs e)
        {
            if (piccontra.Tag == "cerrado")
            {
                txbcontraseña.UseSystemPasswordChar = false;
                piccontra.Tag = "abierto";
                piccontra.Image = Properties.Resources.lock__2_;
            }
            else
            {
                txbcontraseña.UseSystemPasswordChar = true;
                piccontra.Tag = "cerrado";
                piccontra.Image = Properties.Resources.lock__1_;
            }
        }

        private void SeleccionarColor()
        {
            Config c = new Config();
            c = lc.TraerConfig();
            int tema = c.t.id_tema;
            if (tema == 1)
            {
                pnlFondo.BackColor = Color.FromArgb(31,31,31);
                BtnLogin.BackColor = Color.FromArgb(31,31,31);
                BtnLogin.FlatAppearance.MouseOverBackColor = Color.Thistle;
                BtnLogin.FlatAppearance.BorderColor = Color.Thistle;
            }
            else if (tema == 1)
            {
            }
            else
            {
                pnlFondo.BackColor = Color.FromArgb(31, 31, 31);
                BtnLogin.BackColor = Color.FromArgb(31, 31, 31);
                BtnLogin.FlatAppearance.MouseOverBackColor = Color.Thistle;
                BtnLogin.FlatAppearance.BorderColor = Color.Violet;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SeleccionarColor();

        }
    }
}
