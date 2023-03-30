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
    public partial class CrudCliente : Form
    {
        Cliente c = new Cliente();
        List<Cliente> lclientes = new List<Cliente>();
        Cliente clienteSelected = new Cliente();
        In_CrudCliente lg;
        public CrudCliente()
        {
            InitializeComponent();
            lg = new Inmp_CrudCliente();

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            pnlForm.Visible = true;
            Habiltiar(false);
            BtnGuardar.Enabled = true;
            BtnCancelar.Enabled = true;
            txbDni.Enabled = true;
            PicBajar.Enabled = true;
        }

        private void CrudCliente_Load(object sender, EventArgs e)
        {
            lclientes = lg.TrarClientes();
            cargarDgv(lclientes);
        }
        private void cargarDgv(List<Cliente> lp)
        {
            DgvClientes.Rows.Clear();

            foreach (Cliente p in lp)
            {
                string tel = p.Telefono == 0 ? "" : p.Telefono.ToString();
                DgvClientes.Rows.Add(p.DNI,p.Nombre + " "+ p.Apellido, tel, p.Email,"$"+ p.Debe);

            }
        }
        private void PicBajar_Click(object sender, EventArgs e)
        {
            pnlForm.Visible = false;
            Habiltiar(false);
            BtnNuevo.Enabled = true;
            clienteSelected = new Cliente();
            Limpiar();


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            pnlForm.Visible = false;

            Habiltiar(false);
            BtnNuevo.Enabled = true;
            Limpiar();
            clienteSelected = new Cliente();
        }

        private void PicLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void Limpiar()
        {
            txbapellido.Text = string.Empty;
            txbNombre.Text = string.Empty;
            txbDni.Text = string.Empty;
            txbTelefono.Text = string.Empty;
            txbEmail.Text = string.Empty;
        }
        private void Habiltiar(bool a)
        {
            BtnCancelar.Enabled = a;
            BtnEditar.Enabled = a;
            BtnGuardar.Enabled = a;
            BtnNuevo.Enabled = a;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea guardar los datos?","Informacion",MessageBoxButtons.YesNo, MessageBoxIcon.Information)== DialogResult.Yes)
            {
                if (validacion())
                {
                    AbstraerCliente();
                    if (clienteSelected.DNI != 0)
                    {
                        if (clienteSelected.DNI != Convert.ToInt64(txbDni.Text) && lg.CheckearDNI(c.DNINuevo))
                        {
                            MessageBox.Show("El DNI ingresado ya pertenece a otro Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        c.DNI = clienteSelected.DNI;
                        if (lg.ModificacionCliente(c))
                        {
                            MessageBox.Show("Cliente modificado con Exito");
                            lclientes = lg.TrarClientes();
                            cargarDgv(lclientes);
                            pnlForm.Visible = false;
                            Habiltiar(false);
                            BtnNuevo.Enabled = true;
                            Limpiar();
                            c = new Cliente();
                        }
                    }
                    else
                    {

                        if (lg.CheckearDNI(c.DNINuevo))
                        {
                            MessageBox.Show("El DNI ingresado ya pertenece a otro Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        c.DNI = c.DNINuevo;
                        if (lg.AltaCliente(c))
                        {
                            MessageBox.Show("Cliente dado de alta con Exito");
                            lclientes = lg.TrarClientes();
                            cargarDgv(lclientes);
                            pnlForm.Visible = false;
                            Habiltiar(false);
                            BtnNuevo.Enabled = true;
                            Limpiar();
                            c = new Cliente();
                        }
                    }

                }
            }
        }

        private void AbstraerCliente()
        {
            c = new Cliente();
            c.DNINuevo = Convert.ToInt64(txbDni.Text);
            c.Apellido = txbapellido.Text;
            c.Nombre= txbNombre.Text;
            if (txbTelefono.Text == string.Empty)
            {
                c.Telefono = 0;

            }
            else
            {
                c.Telefono = Convert.ToInt64(txbTelefono.Text);

            }
            c.Email = txbEmail.Text;
        }

        private bool validacion()
        {
            if (txbNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe cargar el Nombre del Cliente","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            else if (txbapellido.Text == string.Empty)
            {
                MessageBox.Show("Debe cargar el Apellido del Cliente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            else if (txbDni.Text == string.Empty || (txbDni.Text.Length <7 || txbDni.Text.Length> 8))
            {
                MessageBox.Show("Debe cargar un DNI valido para el Cliente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            return true;
        }

        private void txbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampo(true);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
        }

        private void HabilitarCampo(bool t)
        {
            txbapellido.Enabled= t;
            txbNombre.Enabled= t;
            txbDni.Enabled= t;
            txbEmail.Enabled= t;
            txbTelefono.Enabled= t;
        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvClientes.Columns[e.ColumnIndex].Name == "Accion" && DgvClientes.Rows.Count != 0)
            {
                clienteSelected = new Cliente();
                pnlForm.Visible = true;
                clienteSelected.DNI = Convert.ToInt32(DgvClientes.CurrentRow.Cells[0].Value);
                CargarClienteSelected(clienteSelected.DNI);
                CargarPanelProducto(clienteSelected);
                HabilitarCampo(false);
                PicLimpiar.Enabled = false;
                Habiltiar(false);
                BtnEditar.Enabled = true;


            }
        }

        private void CargarPanelProducto(Cliente clienteSelected)
        {
            txbapellido.Text = clienteSelected.Apellido;
            txbNombre.Text = clienteSelected.Nombre;
            txbTelefono.Text = clienteSelected.Telefono == 0 ?  "": clienteSelected.Telefono.ToString();
            txbEmail.Text = clienteSelected.Email;
            txbDni.Text = clienteSelected.DNI.ToString();
        }

        private void CargarClienteSelected(long id)
        {
            clienteSelected = new Cliente();
            foreach (Cliente u in lclientes)
            {
                if (u.DNI == id)
                {
                    clienteSelected = u;
                    break;
                }
            }
        }

        private void TxbBuscar_TextChanged(object sender, EventArgs e)
        {
            if (RbtDNI.Checked)
            {
                List<Cliente> listaFiltrada = lclientes.Where(p => p.DNI.ToString().Contains(TxbBuscar.Text.ToLower())).ToList();
                cargarDgv(listaFiltrada);

            }
            else if (RbtNombre.Checked)
            {
                List<Cliente> listaFiltrada = lclientes.Where(p => (p.Nombre.ToString().ToLower() + " " + p.Apellido.ToString().ToLower()).Contains(TxbBuscar.Text.ToLower())).ToList();
                cargarDgv(listaFiltrada);
            }

        
        }
    }
}
