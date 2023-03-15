using GestionVentasBackend.Dominio;
using GestionVentasNegocio.Implementacion;
using GestionVentasNegocio.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVentasFrontend.Formularios
{
    public partial class Stock : Form
    {
        In_Cbos lc;
        In_CrudProductos lg;
        List<Producto> lproductos = new List<Producto>();
        List<Producto> lproductosAmodificar = new List<Producto>();
        Producto producoselected = new Producto();
        public Stock()
        {
            InitializeComponent();
            lc = new Inmp_Cbo();
            lg = new Inmp_CrudProductos();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            lproductos = lg.ObtenerProductos(0);
            cargarDgv(lproductos);

            cargar_cbo(cboMarca, "Nombre", "id_Marca", lc.ObtenerMarcas(0));
            cboMarca.SelectedIndex = 0;
            cargar_cbo(cborubro, "Nombre", "id_rubro", lc.ObtenerRubros(0));
            cborubro.SelectedIndex = 0;
        }
        private void cargar_cbo<T>(ComboBox cbo, string display, string value, List<T> lista)
        {
            cbo.DataSource = lista;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
        private void cargarDgv(List<Producto> lp)
        {
            DgvStock.Rows.Clear();

            foreach (Producto p in lp)
            {
                DgvStock.Rows.Add(p.Id_Producto, p.Nombre, p.Descripcion, p.rubro.Nombre, p.marca.Nombre, "$ " + Math.Round(p.Precio, 2), Math.Round(p.Stock_Minimo, p.unidadMedida.CantidadDecimal), Math.Round(p.Stock, p.unidadMedida.CantidadDecimal),p.Seleccindo);

            }
        }

        private void DgvStock_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvStock.Columns[e.ColumnIndex].Name == "Seleccion" && DgvStock.Rows.Count != 0)
            {
                producoselected = new Producto();
                CargarProducto(Convert.ToInt32(DgvStock.CurrentRow.Cells[0].Value));
                DgvStock.CurrentRow.Cells[8].Value = !(bool)DgvStock.CurrentRow.Cells[8].Value;
                if ((bool)DgvStock.CurrentRow.Cells[8].Value)
                {
                    CambiarSeleccion(producoselected);
                    lproductosAmodificar.Add(producoselected);
                }
                else
                {
                    CambiarSeleccion(producoselected);
                    lproductosAmodificar.Remove(producoselected);
                }
                lbitem.Text = "items: " + lproductosAmodificar.Count;
            }
        }


        private void CargarProducto(int id_prod)
        {
            foreach (Producto u in lproductos)
            {
                if (u.Id_Producto == id_prod)
                {
                    producoselected = u;
                    break;
                }
            }
        }

        private void CambiarSeleccion(Producto p)
        {
            foreach (Producto u in lproductos)
            {
                if (u.Id_Producto == p.Id_Producto)
                {
                    u.Seleccindo = !u.Seleccindo;
                    break;
                }
            }
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea aplicar el aumento?","Informacion",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {

            
                if (lproductosAmodificar.Count != 0)
                {

            
                    if (nupAumento.Value != 0)
                    {
                        aplicarAumento();
                        foreach (Producto item in lproductosAmodificar)
                        {
                            if (lg.ModificacionProducto(item))
                            {
                                nupAumento.Value = 0;
                                lproductos = lg.ObtenerProductos(0);
                                cargarDgv(lproductos);
                                cborubro.SelectedIndex = 0;
                           
                            }
                        }
                        lproductosAmodificar = new List<Producto>();
                        MessageBox.Show("Productos modificados con Exito", "Informacion");


                    }
                    else
                    {
                        MessageBox.Show("Debe cargar un valor para aplicar los cambios","Informacion");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar productos para aplicar cambios", "Informacion");

                }
                lbitem.Text = "items: " + lproductosAmodificar.Count;
            }
        }

        private void cborubro_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cborubro.SelectedIndex != 0)
            {
                cboMarca.SelectedIndex = 0;
                List<Producto> listaFiltrada = lproductos.Where(p => p.rubro.Nombre == cborubro.Text).ToList();
                cargarDgv(listaFiltrada);
            }
            else
            {
                cboMarca.SelectedIndex = 0;
                cargarDgv(lproductos);
            }
        }

        private void cboMarca_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboMarca.SelectedIndex != 0)
            {


                if (cborubro.SelectedIndex != 0)
                {
                    List<Producto> listaFiltrada = lproductos.Where(p => p.rubro.Nombre == cborubro.Text && p.marca.Nombre == cboMarca.Text).ToList();
                    cargarDgv(listaFiltrada);
                }
                else
                {
                    List<Producto> listaFiltrada = lproductos.Where(p => p.marca.Nombre == cboMarca.Text).ToList();
                    cargarDgv(listaFiltrada);

                }

            }
            else
            {
                if (cborubro.SelectedIndex != 0)
                {
                    List<Producto> listaFiltrada = lproductos.Where(p => p.rubro.Nombre == cborubro.Text).ToList();
                    cargarDgv(listaFiltrada);
                }
                else
                {
                    cargarDgv(lproductos);
                }



            }
        }


        private void aplicarAumento()
        {
            foreach (Producto item in lproductosAmodificar)
            {
                if (RbtStock.Checked)
                {
                    item.Stock += nupAumento.Value;
                }
                else if (rbtPorcentaje.Checked)
                {
                    item.Precio += (item.Precio * nupAumento.Value) / 100;

                }
                else if (RbtMonto.Checked)
                {
                    item.Precio += nupAumento.Value;
                }
            }
        }

        private void RbtStock_CheckedChanged(object sender, EventArgs e)
        {
            nupAumento.DecimalPlaces = 0;
        }

        private void rbtPorcentaje_CheckedChanged(object sender, EventArgs e)
        {
            nupAumento.DecimalPlaces = 0;

        }

        private void RbtMonto_CheckedChanged(object sender, EventArgs e)
        {
            nupAumento.DecimalPlaces = 2;

        }

        private void DgvStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
