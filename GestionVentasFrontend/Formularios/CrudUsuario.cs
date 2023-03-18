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
        In_Cbos lc;


        Usuario usuario = new Usuario();
        Usuario usuarioSeleccionado = new Usuario();
        Empleado emp = new Empleado();
        List<Usuario> lusuarios = new List<Usuario>();

        public CrudUsuario()
        {
            InitializeComponent();
            lg = new Inmp_CrudUsuario();
            lc = new Inmp_Cbo();
            usuarioSeleccionado.Emp = emp;

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            pnlForm.Visible = true;
            HabilitarBtn(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            Limpiar();
            PicLimpiar.Enabled = true;
        }

        private void CrudUsuario_Load(object sender, EventArgs e)
        {
            lusuarios = lg.ObtenerUsuarios(0);
            CargarDgv(lusuarios);
            HabilitarBtn(false);
            BtnNuevo.Enabled = true;
            cargar_cbo(cboLocalidad, "Nombre", "id_localidad", lc.ObtenerLocalidad(0));
            cargar_cbo(cboRoles, "Nombre", "id_rol", lc.ObtenerRol());

        }

        private void cargar_cbo<T>(ComboBox cbo, string display, string value, List<T> lista)
        {
            cbo.DataSource = lista;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void PicBajar_Click(object sender, EventArgs e)
        {
            pnlForm.Visible = !pnlForm.Visible;
            HabilitarBtn(false);
            Limpiar();
            pnlForm.Visible = false;
            BtnNuevo.Enabled = true;

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (!Validacion())
            {
                return;
            }

            AbstraerUsuario();
            if (usuarioSeleccionado.Id_Usuario != 0)
            {
                if (!chkActivo.Checked)
                {
                    if (MessageBox.Show("Desea Editar los datos de un usuario no Activo?", "Informacion", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
                


                if (usuarioSeleccionado.Alias != usuario.Alias && lg.CheckarAlias(usuario.Alias))
                {
                    MessageBox.Show("El Alias ingresado ya pertenece a otro Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                if (usuarioSeleccionado.Emp.DNI != usuario.Emp.DNI && lg.CheckearDNI(usuario.Emp.DNI))
                {
                    MessageBox.Show("El DNI ingresado ya pertenece a otro Usuario","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                usuario.Id_Usuario = usuarioSeleccionado.Id_Usuario;
                if (lg.ModificacionUsuario(usuario))
                {
                    MessageBox.Show("Usuario se ha Modificado con Exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usuario = new Usuario();
                    pnlForm.Visible = false;
                    lusuarios = lg.ObtenerUsuarios(0);
                    CargarDgv(lusuarios);
                    HabilitarBtn(false);
                    BtnNuevo.Enabled = true;
                    rbtactivo.Checked = true;
                }

            }
            else
            {
                if (usuarioSeleccionado.Alias != usuario.Alias && lg.CheckarAlias(usuario.Alias))
                {
                    MessageBox.Show("El Alias ingresado ya pertenece a otro Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                if (usuarioSeleccionado.Emp.DNI != usuario.Emp.DNI && lg.CheckearDNI(usuario.Emp.DNI))
                {
                    MessageBox.Show("El DNI ingresado ya pertenece a otro Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (lg.AltaUsuario(usuario))
                {
                    MessageBox.Show("Usuario dado de Alta con Exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usuario = new Usuario();
                    pnlForm.Visible = false;
                    lusuarios = lg.ObtenerUsuarios(0);
                    CargarDgv(lusuarios);
                    HabilitarBtn(false);
                    BtnNuevo.Enabled = true;
                    rbtactivo.Checked = true;
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
            Rol r = new Rol();
            usuario.rol = r;
            r.id_rol = (int)cboRoles.SelectedValue;
            usuario.Emp.loc = LOC;
            usuario.Alias = txbAlias.Text;
            usuario.Contraseña = txbContraseña.Text;
            usuario.Emp.Nombre = txbNombre.Text;
            usuario.Emp.Apellido = txbapellido.Text;
            usuario.Emp.Calle = txbCalle.Text;
            usuario.Emp.DNI = Convert.ToInt64(txbDni.Text);
            usuario.Emp.loc.id_Localidad = (int)cboLocalidad.SelectedValue;
            usuario.Emp.Altura = (int)nupAltura.Value;
            usuario.Emp.Piso = (int)nupPiso.Value;
            usuario.Emp.Email = txbEmail.Text;
            if (txbTelefono.Text == string.Empty)
            {
                usuario.Emp.Telefono = 0;
            }
            else
            {
                usuario.Emp.Telefono = Convert.ToInt64(txbTelefono.Text);
            }

            usuario.Emp.Departamento = txbDepartament.Text;

            usuario.Baja_Logica = chkActivo.Checked ? 0 : 1;
        }

        private void DgvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvUsuarios.Columns[e.ColumnIndex].Name == "Accion" && DgvUsuarios.Rows.Count != 0)
            {
                usuarioSeleccionado = new Usuario();
                emp = new Empleado();
                Localidad loc = new Localidad();
                emp.loc = loc;
                usuarioSeleccionado.Emp = emp;


                chkActivo.Visible = true;

                pnlForm.Visible = true;

                usuarioSeleccionado.Emp.DNI = Convert.ToInt64(DgvUsuarios.CurrentRow.Cells[0].Value);
                CargarUsuarioSeleccionado(usuarioSeleccionado.Emp.DNI);
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
            chkActivo.Checked = usuarioSeleccionado.Baja_Logica == 0 ? true : false;
            txbDni.Text = usuarioSeleccionado.Emp.DNI.ToString();
            cboLocalidad.SelectedValue = usuarioSeleccionado.Emp.loc.id_Localidad;
            txbNombre.Text = usuarioSeleccionado.Emp.Nombre;
            cboRoles.SelectedValue = usuarioSeleccionado.rol.id_rol;
        }

        private void CargarUsuarioSeleccionado(long id_Usuario)
        {
            foreach (Usuario u in lusuarios)
            {
                if (u.Emp.DNI == id_Usuario)
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
            txbDni.Enabled = v;
            cboLocalidad.Enabled = v;
            txbNombre.Enabled = v;
            cboRoles.Enabled = v;
        }


        private void CargarDgv(List<Usuario> luser)
        {
            DgvUsuarios.Rows.Clear();

            foreach (Usuario item in luser)
            {
                DgvUsuarios.Rows.Add(item.Emp.DNI, item.Emp.Nombre + " " + item.Emp.Apellido, item.Alias, item.Emp.loc.Nombre, item.Emp.Calle, item.Emp.Altura, item.Emp.Piso, item.Emp.Departamento, item.Emp.Telefono, item.Baja_Logica == 0 ? "Sí" : "No");
            }


        }

        private void DgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                // Establecer el color de fondo en LightGray para filas pares
                e.CellStyle.BackColor = ColorTranslator.FromHtml("#d2eaf1");
            }
            else
            {
                // Establecer el color de fondo en White para filas impares
                e.CellStyle.BackColor = ColorTranslator.FromHtml("#e2f0fb");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            HabilitarBtn(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            HabilitarCampos(true);
            PicLimpiar.Enabled = true;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarBtn(false);
            Limpiar();
            pnlForm.Visible = false;
            BtnNuevo.Enabled = true;



        }
        private void Limpiar()
        {
            txbAlias.Text = string.Empty;
            txbapellido.Text = string.Empty;
            txbCalle.Text = string.Empty;
            txbContraseña.Text = string.Empty;
            txbDni.Text = string.Empty;
            txbDepartament.Text = string.Empty;
            txbTelefono.Text = string.Empty;
            txbEmail.Text = string.Empty;
            txbNombre.Text = string.Empty;
            nupAltura.Value = 0;
            nupPiso.Value = 0;
            cboLocalidad.SelectedIndex = -1;
            cboRoles.SelectedIndex = -1;


        }

        private void PicLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar < 0 || e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }

        private void txbapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar < 0 || e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }

        private void rbtactivo_CheckedChanged(object sender, EventArgs e)
        {
            lusuarios = lg.ObtenerUsuarios(0);
            CargarDgv(lusuarios);
            txbFiltro.Text = string.Empty;
        }

        private void rbtnoactivo_CheckedChanged(object sender, EventArgs e)
        {
            lusuarios = lg.ObtenerUsuarios(1);
            CargarDgv(lusuarios);
            txbFiltro.Text = string.Empty;

        }

        private void rbttodos_CheckedChanged(object sender, EventArgs e)
        {
            lusuarios = lg.ObtenerUsuarios(2);
            CargarDgv(lusuarios);
            txbFiltro.Text = string.Empty;

        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            if (rbtDNI.Checked)
            {
                List<Usuario> listaFiltrada = lusuarios.Where(p => p.Emp.DNI.ToString().Contains(txbFiltro.Text.ToLower())).ToList();
                CargarDgv(listaFiltrada);

            }
            else if (rbtNombre.Checked)
            {
                List<Usuario> listaFiltrada = lusuarios.Where(p => (p.Emp.Nombre.ToString().ToLower() + " " + p.Emp.Apellido.ToString().ToLower()).Contains(txbFiltro.Text.ToLower())).ToList();
                CargarDgv(listaFiltrada);
            }

        }
    }
}
