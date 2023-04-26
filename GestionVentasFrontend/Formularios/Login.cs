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
    }
}
