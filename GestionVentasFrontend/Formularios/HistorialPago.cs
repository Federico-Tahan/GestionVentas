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
    public partial class HistorialPago : Form
    {
        In_CrudCliente lg;
        In_HistorialPago lh;
        Cliente Clienteselected = new Cliente();
        HistoriaPagoCliente HistSelected = new HistoriaPagoCliente();
        HistoriaPagoCliente HP = new HistoriaPagoCliente();
        List<HistoriaPagoCliente> lHist = new List<HistoriaPagoCliente>();
        public HistorialPago()
        {
            InitializeComponent();
            lg = new Inmp_CrudCliente();
            lh = new Inmp_HistorialPago();
        }

        private void HistorialPago_Load(object sender, EventArgs e)
        {
            lHist = lh.TraerPagos(2);
            CargarDGV();
            cargar_cbo(cboDNI,"DNI", "DNI",lg.TrarClientes());
            txbApellido.Text = string.Empty;
            txbNombre.Text = string.Empty;
        }

        private void CargarDGV()
        {
            DgvHistPago.Rows.Clear();

            foreach (var item in lHist)
            {
                DgvHistPago.Rows.Add(item.Id_pago,item.client.Nombre + " " + item.client.Apellido, item.Fecha, "$"+item.Monto, item.Baja_Logica == 0? "":"Cancelada");
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            pnlForm.Visible = true;
            Habiltiar(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            nupDebe.Visible = true;
            lbdeuda.Visible = true;
            nupPrecio.Enabled = true;
            cboDNI.Enabled = true;
            Limpiar();
        }

        private void Limpiar()
        {
            cboDNI.SelectedIndex = -1;
            txbApellido.Text = string.Empty;
            txbNombre.Text = string.Empty;
            nupPrecio.Value = 0;
            nupDebe.Value = 0;

        }

        private void cargar_cbo<T>(ComboBox cbo, string display, string value, List<T> lista)
        {
            cbo.DataSource = lista;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void cboDNI_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboDNI.SelectedIndex != -1)
            {
                Clienteselected = (Cliente)cboDNI.SelectedItem;
                txbNombre.Text = Clienteselected.Nombre;
                txbApellido.Text = Clienteselected.Apellido;
                nupDebe.Value = Clienteselected.Debe;
            }
        }

        private void cboDNI_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboDNI.SelectedIndex != -1)
            {
                Clienteselected = (Cliente)cboDNI.SelectedItem;
                txbNombre.Text = Clienteselected.Nombre;
                txbApellido.Text = Clienteselected.Apellido;
                nupDebe.Value = Clienteselected.Debe;
            }
        }
        private void Habiltiar(bool a)
        {
            BtnCancelar.Enabled = a;
            BtnCancelarPago.Enabled = a;
            BtnGuardar.Enabled = a;
            BtnNuevo.Enabled = a;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea bajar el pago del cliente?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (cboDNI.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la cuenta de un cliente para continuar.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (lh.BajaPago(HistSelected))
            {
                pnlForm.Visible = false;
                Habiltiar(false);
                BtnNuevo.Enabled = true;
                lHist = lh.TraerPagos(2);
                CargarDGV();
                cargar_cbo(cboDNI, "DNI", "DNI", lg.TrarClientes());
                MessageBox.Show("Pago dado de baja con Exito.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Habiltiar(false);
            Limpiar();
            pnlForm.Visible = false;
            BtnNuevo.Enabled = true;
        }

        private void PicBajar_Click(object sender, EventArgs e)
        {
            Habiltiar(false);
            Limpiar();
            pnlForm.Visible = false;
            BtnNuevo.Enabled = true;
        }

        private void PicLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void DgvHistPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvHistPago.Columns[e.ColumnIndex].Name == "Accion" && DgvHistPago.Rows.Count != 0)
            {
                HistSelected = new HistoriaPagoCliente();
                pnlForm.Visible = true;
                HistSelected.Id_pago = Convert.ToInt32(DgvHistPago.CurrentRow.Cells[0].Value);
                CargarHistorialSelected(HistSelected.Id_pago);
                CargarPanelProducto(HistSelected);
                Habiltiar(false);
                nupDebe.Visible = false;
                cboDNI.Enabled = false;
                lbdeuda.Visible = false;
                txbApellido.Enabled = false;
                txbNombre.Enabled = false;
                nupDebe.Enabled = false;
                nupPrecio.Enabled = false;
                BtnCancelarPago.Enabled = HistSelected.Baja_Logica == 0 ? true:false;


            }
        }

        private void CargarPanelProducto(HistoriaPagoCliente HistSelected)
        {
            cboDNI.SelectedValue = HistSelected.client.DNI;
            nupPrecio.Value = HistSelected.Monto;
        }

        private void CargarHistorialSelected(long id)
        {
            HistSelected = new HistoriaPagoCliente();
            foreach (HistoriaPagoCliente u in lHist)
            {
                if (u.Id_pago == id)
                {
                    HistSelected = u;
                    break;
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (!Validacion())
            {
                return;
            }
            AbstraerPago();
                if (lh.AltaPago(HP))
                {
                    MessageBox.Show("Pago cargado con Exito.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlForm.Visible = false;
                    cargar_cbo(cboDNI, "DNI", "DNI", lg.TrarClientes());
                    Habiltiar(false);
                    BtnNuevo.Enabled = true;
                    lHist = lh.TraerPagos(2);
                    CargarDGV();
            }
        }


        private bool Validacion()
        {
            if (nupPrecio.Value > nupDebe.Value)
            {
                MessageBox.Show("El monto que está entregando es mayor a la deuda del cliente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (cboDNI.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la cuenta de un cliente para continuar.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (nupPrecio.Value == 0)
            {
                MessageBox.Show("Debe cargar un monto de pago.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;

        }

        private void AbstraerPago()
        {
            HP = new HistoriaPagoCliente();

            HP.client = (Cliente)cboDNI.SelectedItem;
            HP.Monto = nupPrecio.Value;

        }

        private void DgvHistPago_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
    }
}
