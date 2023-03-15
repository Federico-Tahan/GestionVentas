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

namespace GestionVentasFrontend.Formularios
{
    public partial class CrudUsuario : Form
    {
        int modo = 0;
        In_CrudUsuario lg;

        Usuario usuario = new Usuario();
        Usuario usuarioSeleccionado = new Usuario();
        List<Usuario> lusuarios = new List<Usuario>();

        public CrudUsuario(int tipo)
        {
            InitializeComponent();
            modo = tipo;
            lg = new Inmp_CrudUsuario();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            pnlForm.Visible = true;
        }

        private void CrudUsuario_Load(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                this.FormBorderStyle= FormBorderStyle.None;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;

            }
        }

        private void PicBajar_Click(object sender, EventArgs e)
        {
            pnlForm.Visible = !pnlForm.Visible;
            BtnNuevo.Enabled = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                AbstraerUsuario();

                if (usuarioSeleccionado.Id_Usuario != 0)
                {
                    if (lg.ModificacionUsuario(usuario))
                    {
                        MessageBox.Show("Usuario se ha Modificado con Exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        usuario = new Usuario();
                        pnlForm.Visible = false;
                    }
                }
                else
                {
                    if (lg.AltaUsuario(usuario))
                    {
                        MessageBox.Show("Usuario dado de Alta con Exito","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        usuario = new Usuario();
                        pnlForm.Visible = false;

                    }
                }
            }

        }

        private bool Validacion()
        {
            if (txbNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe Cargar el Nombre del Usuario ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbapellido.Text == string.Empty)
            {
                MessageBox.Show("Debe Cargar el Apellido del Usuario ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbDni.Text == string.Empty)
            {
                MessageBox.Show("Debe Cargar el DNI del Usuario ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbCalle.Text == string.Empty)
            {
                MessageBox.Show("Debe Cargar la Calle del Usuario ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nupAltura.Value == 0)
            {
                MessageBox.Show("Debe Cargar la Altura de la calle del Usuario ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbAlias.Text == string.Empty)
            {
                MessageBox.Show("Debe Cargar el Alias del Usuario ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbContraseña.Text == string.Empty)
            {
                MessageBox.Show("Debe Cargar la Contraseña del Usuario ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void AbstraerUsuario()
        {
            usuario = new Usuario();
            Empleado Emp = new Empleado();
            usuario.Emp = Emp;
            Localidad LOC = new Localidad();
            usuario.Emp.loc = LOC;
            usuario.Alias = txbAlias.Text;
            usuario.Contraseña = txbContraseña.Text;
            usuario.Emp.Nombre = txbNombre.Text;
            usuario.Emp.Apellido = txbapellido.Text;
            usuario.Emp.Calle = txbCalle.Text;
            usuario.Emp.DNI = Convert.ToInt64(txbDni.Text);
            //usuario.Emp.loc.id_Localidad = (int)cboLocalidad.SelectedValue;
            usuario.Emp.Altura = (int)nupAltura.Value;
            usuario.Emp.Piso = (int)nupPiso.Value;
            usuario.Emp.Email = txbEmail.Text;
            if (Convert.ToInt32(txbTelefono.Text) == 0)
            {
                usuario.Emp.Telefono = 0;
            }
            else
            {
                usuario.Emp.Telefono = Convert.ToInt64(txbTelefono.Text);
            }
            
            usuario.Emp.Departamento = txbDepartament.Text;


        }

        private void DgvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvUsuarios.Columns[e.ColumnIndex].Name == "Accion" && DgvUsuarios.Rows.Count != 0)
            {
                usuarioSeleccionado = new Usuario();
               
                chkActivo.Visible = true;
                
                pnlForm.Visible = true;
                usuarioSeleccionado.Id_Usuario = Convert.ToInt32(DgvUsuarios.CurrentRow.Cells[0].Value);
                CargarUsuarioSeleccionado(usuarioSeleccionado.Id_Usuario);
                CargarPanelUsuario(usuarioSeleccionado);
                HabilitarCampos(false);
                PicLimpiar.Enabled = false;
                HabilitarBtn(false);
                BtnEditar.Enabled = true;


            }
        }

        private void CargarPanelUsuario(Usuario usuarioSeleccionado)
        {
            txbAlias.Text = usuarioSeleccionado.Alias;
            txbapellido.Text = usuarioSeleccionado.Emp.Apellido;
            txbCalle.Text = usuarioSeleccionado.Emp.Calle;
            txbContraseña.Text = usuarioSeleccionado.Contraseña;
            txbDepartament.Text = usuarioSeleccionado.Emp.Departamento;
            txbTelefono.Text = usuarioSeleccionado.Emp.Telefono.ToString();
            txbEmail.Text = usuarioSeleccionado.Emp.Email;
            nupAltura.Value = usuarioSeleccionado.Emp.Altura;
            nupPiso.Value = usuarioSeleccionado.Emp.Piso;
            if (usuarioSeleccionado.Baja_Logica == 0)
            {
                chkActivo.Checked = true;
            }
            else
            {
                chkActivo.Checked = false;
            }
            txbDni.Text = usuarioSeleccionado.Emp.DNI.ToString();
            cboLocalidad.SelectedValue = usuarioSeleccionado.Emp.loc.id_Localidad;
            txbNombre.Text = usuarioSeleccionado.Emp.Nombre;
        }

        private void CargarUsuarioSeleccionado(int id_Usuario)
        {
            foreach (Usuario u in lusuarios)
            {
                if (u.Id_Usuario == id_Usuario)
                {
                    usuarioSeleccionado = u;
                    break;
                }
            }
        }

        private void HabilitarBtn(bool v)
        {
            BtnNuevo.Enabled = v;
            BtnEditar.Enabled = v;
            BtnCancelar.Enabled = v;
            BtnGuardar.Enabled = v;
        }

        private void HabilitarCampos(bool v)
        {
            txbAlias.Enabled = v;
            txbapellido.Enabled = v;
            txbCalle.Enabled = v;
            txbContraseña.Enabled = v;
            txbDepartament.Enabled = v;
            txbTelefono.Enabled = v;
            txbEmail.Enabled = v;
            nupAltura.Enabled = v;
            nupPiso.Enabled = v;
            chkActivo.Enabled = v;
            txbDni.Enabled= v;
            cboLocalidad.Enabled = v;
            txbNombre.Enabled = v;
        }
    }
}
