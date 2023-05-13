using GestionVentasBackend.Dominio;
using GestionVentasNegocio.Implementacion;
using GestionVentasNegocio.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVentasFrontend.Formularios.Extra
{
    public partial class UnidadDeMedida : Form
    {
        In_Cbos lg = new Inmp_Cbo();

        UnidadMedida uSelected = new UnidadMedida();
        UnidadMedida u = new UnidadMedida();

        List<UnidadMedida> lUnidadMedida;
        public UnidadDeMedida()
        {
            InitializeComponent();
            SeleccionarColor();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            txbNombre.Enabled = true;
            numDec.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            pnl.Visible = true;
            chkActivo.Visible = false;
            Limpiar();

        }

        private void UnidadDeMedida_Load(object sender, EventArgs e)
        {
            lUnidadMedida = lg.ObtenerUnidadMedida(1);
            cargarDgv(lUnidadMedida);
        }

        private void Habilitar(bool a) 
        {       
            BtnCancelar.Enabled = a;
            BtnEditar.Enabled = a;
            BtnGuardar.Enabled = a;
            BtnNuevo.Enabled = a;
            txbNombre.Enabled = a;
            numDec.Enabled = a;
            chkActivo.Enabled = a;
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
            numDec.Value = 0;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            txbNombre.Enabled = true;
            numDec.Enabled = true;
            chkActivo.Enabled = true;
            BtnEditar.Enabled=false;
            BtnGuardar.Enabled = true;
        }

        private void cargarDgv(List<UnidadMedida> lp)
        {
            DgvUnidadMed.Rows.Clear();

            foreach (UnidadMedida p in lp)
            {
              
                DgvUnidadMed.Rows.Add(p.Id_UnidadMedida,p.Nombre,p.CantidadDecimal,p.BajaLogica == 0 ? "Sí":"No");

            }
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

                CargarUnidadSelected(Convert.ToInt32(DgvUnidadMed.CurrentRow.Cells[0].Value));
                CargarPanel();
                pnl.Visible = true;
                Habilitar(false);
                chkActivo.Visible = true;
                BtnEditar.Enabled = true;
                BtnCancelar.Enabled = true;


            }
        }

        private void CargarUnidadSelected(int id)
        {
            uSelected = new UnidadMedida();
            foreach (UnidadMedida i in lUnidadMedida)
            {
                if (i.Id_UnidadMedida == id)
                {
                    uSelected = i;
                    break;
                }
            }
        }


        private void CargarPanel()
        {
            txbNombre.Text = uSelected.Nombre;
            numDec.Value = uSelected.CantidadDecimal;
            chkActivo.Checked = uSelected.BajaLogica == 0 ? true: false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar()) 
            {
                AbstraerUnidad();
                if (uSelected.Id_UnidadMedida != 0)
                {
                    u.Id_UnidadMedida = uSelected.Id_UnidadMedida;

                    if (lg.UpdateUnidadMed(u)) 
                    {
                        MessageBox.Show("Unidad de Medida modificada con Exito.");
                        u = new UnidadMedida();
                        pnl.Visible = false;
                        Habilitar(false);
                        BtnNuevo.Enabled = true;
                        lUnidadMedida = lg.ObtenerUnidadMedida(1);
                        cargarDgv(lUnidadMedida);
                    }

                }
                else 
                {
                    if (lg.AltaUnidadMed(u)) 
                    {
                        MessageBox.Show("Unidad de Medida dada de alta con Exito.");
                        u = new UnidadMedida();
                        pnl.Visible = false;
                        Habilitar(false);
                        BtnNuevo.Enabled = true;
                        lUnidadMedida = lg.ObtenerUnidadMedida(1);
                        cargarDgv(lUnidadMedida);
                    }
                }
            }
        }

        private void AbstraerUnidad() 
        {

            u.Nombre = txbNombre.Text;
            u.CantidadDecimal = (int)numDec.Value;
            u.BajaLogica = chkActivo.Checked ? 0 : 1;
        }


        private bool Validar()
        {

            if (txbNombre.Text == String.Empty) 
            {
                MessageBox.Show("Debe cargar el nombre de la unidad de medida.");
                return false;
            }


            return true;    

        }

        private void UnidadDeMedida_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
