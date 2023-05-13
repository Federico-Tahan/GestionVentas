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
    public partial class FormMarca : Form
    {
        In_Cbos lg = new Inmp_Cbo();
        Marca mSelected = new Marca();
        Marca m = new Marca();
        List<Marca> marcaList = new List<Marca>();
        public FormMarca()
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
        private void cargarDgv(List<Marca> lp)
        {
            DgvUnidadMed.Rows.Clear();

            foreach (Marca p in lp)
            {

                DgvUnidadMed.Rows.Add(p.id_Marca, p.Nombre, p.BajaLogica == 0 ? "Sí" : "No");

            }
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
            txbNombre.Text = mSelected.Nombre;
            chkActivo.Checked = mSelected.BajaLogica == 0 ? true : false;
        }



        private void CargarMarcaSelected(int id)
        {
            mSelected = new Marca();
            foreach (Marca i in marcaList)
            {
                if (i.id_Marca == id)
                {
                    mSelected = i;
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

        private void FormMarca_Load(object sender, EventArgs e)
        {
            marcaList = lg.ObtenerMarcas(1);
            cargarDgv(marcaList);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                AbstraerMarca();
                if (mSelected.id_Marca != 0)
                {
                    m.id_Marca = mSelected.id_Marca;

                    if (lg.UpdateMarca(m))
                    {
                        MessageBox.Show("Marca modificada con Exito.");
                        m = new Marca();
                        mSelected = new Marca();
                        pnl.Visible = false;
                        Habilitar(false);
                        BtnNuevo.Enabled = true;
                        marcaList = lg.ObtenerMarcas(1);
                        cargarDgv(marcaList);
                    }

                }
                else
                {
                    if (lg.AltaMarca(m))
                    {
                        MessageBox.Show("Marca dada de Alta con Exito.");
                        m = new Marca();
                        mSelected = new Marca();
                        pnl.Visible = false;
                        Habilitar(false);
                        BtnNuevo.Enabled = true;
                        marcaList = lg.ObtenerMarcas(1);
                        cargarDgv(marcaList);
                    }
                }
            }


        }
        private bool Validar()
        {

            if (txbNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe cargar el nombre de la Marca.");
                return false;
            }


            return true;

        }
        private void AbstraerMarca()
        {
            m.Nombre = txbNombre.Text;
            m.BajaLogica = chkActivo.Checked ? 0 : 1;
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
        private void FormMarca_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;

        }
    }
}
