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

namespace GestionVentasFrontend.Formularios.Extra
{
    public partial class FormFormaPago : Form
    {
        In_Cbos lg = new Inmp_Cbo();

        FormaPago fSelected = new FormaPago();
        FormaPago f = new FormaPago();
        List<FormaPago> fList = new List<FormaPago>();
        public FormFormaPago()
        {
            InitializeComponent();
            SeleccionarColor();

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            f = new FormaPago();
            Habilitar(false);
            txbNombre.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            pnl.Visible = true;
            chkActivo.Visible = false;
            Limpiar();
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
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            txbNombre.Enabled = true;
            chkActivo.Enabled = true;
            BtnEditar.Enabled = false;
            BtnGuardar.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            Limpiar();
            pnl.Visible = false;
            BtnNuevo.Enabled = true;
        }

        private void Limpiar()
        {
            txbNombre.Text = String.Empty;
        }

        private void Habilitar(bool a)
        {
            BtnCancelar.Enabled = a;
            BtnEditar.Enabled = a;
            BtnGuardar.Enabled = a;
            BtnNuevo.Enabled = a;
            txbNombre.Enabled = a;
            chkActivo.Enabled = a;
        }
        private void cargarDgv(List<FormaPago> lp)
        {
            DgvUnidadMed.Rows.Clear();

            foreach (FormaPago p in lp)
            {

                DgvUnidadMed.Rows.Add(p.id_formapago, p.Formapago, p.Baja_logica == 0 ? "Sí" : "No");

            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                AbstraerLocalidad();
                if (fSelected.id_formapago != 0)
                {
                    f.id_formapago = fSelected.id_formapago;

                    if (lg.UpdateFp(f))
                    {
                        MessageBox.Show("Forma de pago modificada con Exito.");
                        f = new FormaPago();
                        fSelected = new FormaPago();
                        pnl.Visible = false;
                        Habilitar(false);
                        BtnNuevo.Enabled = true;
                        fList = lg.ObtenerFormaPago(2);
                        cargarDgv(fList);
                    }

                }
                else
                {
                    if (lg.AltaFp(f))
                    {
                        MessageBox.Show("Forma de pago dada de alta con Exito.");
                        f = new FormaPago();
                        fSelected = new FormaPago();
                        pnl.Visible = false;
                        Habilitar(false);
                        BtnNuevo.Enabled = true;
                        fList = lg.ObtenerFormaPago(2);
                        cargarDgv(fList);
                    }
                }
            }
        }
        private void CargarFormPagoSelected(int id)
        {
            fSelected = new FormaPago();
            foreach (FormaPago i in fList)
            {
                if (i.id_formapago == id)
                {
                    fSelected = i;
                    break;
                }
            }
        }

        private void CargarPanel()
        {
            txbNombre.Text = fSelected.Formapago;
            chkActivo.Checked = fSelected.Baja_logica == 0 ? true : false;
        }
        private bool Validar()
        {

            if (txbNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe cargar el nombre de la Localidad.");
                return false;
            }


            return true;

        }
        private void AbstraerLocalidad()
        {
            f.Formapago = txbNombre.Text;
            f.Baja_logica = chkActivo.Checked ? 0 : 1;
        }

        private void DgvUnidadMed_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void DgvUnidadMed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvUnidadMed.Columns[e.ColumnIndex].Name == "Accion" && DgvUnidadMed.Rows.Count != 0)
            {
                if (Convert.ToInt32(DgvUnidadMed.CurrentRow.Cells[0].Value) == 1) 
                {

                    MessageBox.Show("No puede acceder al detalle del fiado.");
                    return;
                }
                else
                {
                    CargarFormPagoSelected(Convert.ToInt32(DgvUnidadMed.CurrentRow.Cells[0].Value));
                    CargarPanel();
                    pnl.Visible = true;
                    Habilitar(false);
                    chkActivo.Visible = true;
                    BtnEditar.Enabled = true;
                    BtnCancelar.Enabled = true;
                }
               


            }
        }

        private void FormFormaPago_Load(object sender, EventArgs e)
        {
            fList = lg.ObtenerFormaPago(2);
            cargarDgv(fList);
        }
    }
}
