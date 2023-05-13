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
    public partial class FormLocalidad : Form
    {
        In_Cbos lg = new Inmp_Cbo();
        Localidad l  = new Localidad();
        Localidad lSelected = new Localidad();
        List<Localidad> lLocalidad = new List<Localidad>();
        public FormLocalidad()
        {
            InitializeComponent();
            SeleccionarColor();

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            txbNombre.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            pnl.Visible = true;
            chkActivo.Visible = false;
            Limpiar();

        }
        private void cargarDgv(List<Localidad> lp)
        {
            DgvUnidadMed.Rows.Clear();

            foreach (Localidad p in lp)
            {

                DgvUnidadMed.Rows.Add(p.id_Localidad, p.Nombre, p.Baja_Logica == 0 ? "Sí" : "No");

            }
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

        private void FormLocalidad_Load(object sender, EventArgs e)
        {
            lLocalidad = lg.ObtenerLocalidad(2);
            cargarDgv(lLocalidad);
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
        private void DgvUnidadMed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvUnidadMed.Columns[e.ColumnIndex].Name == "Accion" && DgvUnidadMed.Rows.Count != 0)
            {

                CargarLocSelected(Convert.ToInt32(DgvUnidadMed.CurrentRow.Cells[0].Value));
                CargarPanel();
                pnl.Visible = true;
                Habilitar(false);
                chkActivo.Visible = true;
                BtnEditar.Enabled = true;
                BtnCancelar.Enabled = true;


            }
        }

        private void CargarLocSelected(int id)
        {
            lSelected = new Localidad();
            foreach (Localidad i in lLocalidad)
            {
                if (i.id_Localidad == id)
                {
                    lSelected = i;
                    break;
                }
            }
        }

        private void CargarPanel()
        {
            txbNombre.Text = lSelected.Nombre;
            chkActivo.Checked = lSelected.Baja_Logica == 0 ? true : false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                AbstraerLocalidad();
                if (lSelected.id_Localidad != 0)
                {
                    l.id_Localidad = lSelected.id_Localidad;

                    if (lg.UpdateLocalidad(l))
                    {
                        MessageBox.Show("Localidad modificada con Exito.");
                        l = new Localidad();
                        lSelected = new Localidad();
                        pnl.Visible = false;
                        Habilitar(false);
                        BtnNuevo.Enabled = true;
                        lLocalidad = lg.ObtenerLocalidad(2);
                        cargarDgv(lLocalidad);
                    }

                }
                else
                {
                    if (lg.AltaLocalidad(l))
                    {
                        MessageBox.Show("Localidad dada de alta con Exito.");
                        l = new Localidad();
                        lSelected = new Localidad();
                        pnl.Visible = false;
                        Habilitar(false);
                        BtnNuevo.Enabled = true;
                        lLocalidad = lg.ObtenerLocalidad(0);
                        cargarDgv(lLocalidad);
                    }
                }
            }

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
            l.Nombre = txbNombre.Text;
            l.Baja_Logica = chkActivo.Checked ? 0 : 1;
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

        private void FormLocalidad_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
