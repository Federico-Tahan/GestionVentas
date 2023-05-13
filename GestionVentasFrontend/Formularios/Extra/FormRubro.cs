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
    public partial class FormRubro : Form
    {
        In_Cbos lg = new Inmp_Cbo();

        Rubro rSelected = new Rubro();
        Rubro r = new Rubro();
        List<Rubro> lRubro = new List<Rubro>();
        public FormRubro()
        {
            InitializeComponent();
            SeleccionarColor();
        }

        private void DgvUnidadMed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvUnidadMed.Columns[e.ColumnIndex].Name == "Accion" && DgvUnidadMed.Rows.Count != 0)
            {

                CargarMarcaSelected(Convert.ToInt32(DgvUnidadMed.CurrentRow.Cells[0].Value));
                CargarPanel();
                pnl.Visible = true;
                Habilitar(false);
                chkActivo.Visible = true;
                BtnEditar.Enabled = true;
                BtnCancelar.Enabled = true;


            }
        }
        private void CargarPanel()
        {
            txbNombre.Text = rSelected.Nombre;
            chkActivo.Checked = rSelected.BajaLogica == 0 ? true : false;
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
        private void CargarMarcaSelected(int id)
        {
            rSelected = new Rubro();
            foreach (Rubro i in lRubro)
            {
                if (i.id_rubro == id)
                {
                    rSelected = i;
                    break;
                }
            }
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
        private void Limpiar()
        {
            txbNombre.Text = String.Empty;
        }
        private bool Validar()
        {

            if (txbNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe cargar el nombre del Rubro.");
                return false;
            }


            return true;

        }
        private void AbstraerRubro()
        {
            r.Nombre = txbNombre.Text;
            r.BajaLogica = chkActivo.Checked ? 0 : 1;
        }
        private void cargarDgv(List<Rubro> lp)
        {
            DgvUnidadMed.Rows.Clear();

            foreach (Rubro p in lp)
            {

                DgvUnidadMed.Rows.Add(p.id_rubro, p.Nombre, p.BajaLogica == 0 ? "Sí" : "No");

            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                AbstraerRubro();
                if (rSelected.id_rubro != 0)
                {
                    r.id_rubro = rSelected.id_rubro;

                    if (lg.UpdateRubro(r))
                    {
                        MessageBox.Show("Rubro modificado con Exito.");
                        r = new Rubro();
                        rSelected = new Rubro();
                        pnl.Visible = false;
                        Habilitar(false);
                        BtnNuevo.Enabled = true;
                        lRubro = lg.ObtenerRubros(1);
                        cargarDgv(lRubro);
                    }

                }
                else
                {
                    if (lg.AltaRubro(r))
                    {
                        MessageBox.Show("Rubro dado de Alta con Exito.");
                        r = new Rubro();
                        rSelected = new Rubro();
                        pnl.Visible = false;
                        Habilitar(false);
                        BtnNuevo.Enabled = true;
                        lRubro = lg.ObtenerRubros(1);
                        cargarDgv(lRubro);
                    }
                }
            }
        }

        private void FormRubro_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;

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
        private void FormRubro_Load(object sender, EventArgs e)
        {
            lRubro = lg.ObtenerRubros(1);
            cargarDgv(lRubro);
        }
    }
}
