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

namespace GestionVentasFrontend.Formularios.Venta
{
    public partial class Venta : Form
    {
        In_Cbos lc;
        In_CrudProductos lg;

        Producto prodaAgregar = new Producto();
        DetalleFactura DetalleSeleccionado = new DetalleFactura();

        Factura f = new Factura();
        List<DetalleFactura> detFact = new List<DetalleFactura>();
        DetalleFactura df = new DetalleFactura();

        public Venta()
        {
            InitializeComponent();
            lc = new Inmp_Cbo();
            lg = new Inmp_CrudProductos();
            f.LDetalle = detFact;
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            ConfirmarVenta cv = new ConfirmarVenta();
            cv.ShowDialog();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            cargar_cbo(cboMarca, "Nombre", "id_Marca", lc.ObtenerMarcas(0));
            cboMarca.SelectedIndex = 0;
            cargar_cbo(cborubro, "Nombre", "id_rubro", lc.ObtenerRubros(0));
            cborubro.SelectedIndex = 0;
            cargar_cbo(cboprod, "Nombre", "Id_Producto", lc.ObtenerProducto((int)cborubro.SelectedValue, (int)cboMarca.SelectedValue));
            txbStock.Text = "";

        }
        private void cargar_cbo<T>(ComboBox cbo, string display, string value, List<T> lista)
        {
            cbo.DataSource = lista;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void cboMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_cbo(cboprod, "Nombre", "Id_Producto", lc.ObtenerProducto((int)cborubro.SelectedValue, (int)cboMarca.SelectedValue));
            txbStock.Text = "";

        }

        private void cborubro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_cbo(cboprod, "Nombre", "Id_Producto", lc.ObtenerProducto((int)cborubro.SelectedValue, (int)cboMarca.SelectedValue));
            txbStock.Text = "";

        }

        private void cboprod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboprod.SelectedIndex != -1)
            {
                prodaAgregar = (Producto)cboprod.SelectedItem;
                nupCant.DecimalPlaces = prodaAgregar.unidadMedida.CantidadDecimal;
                txbStock.Text = Math.Round(prodaAgregar.Stock,prodaAgregar.unidadMedida.CantidadDecimal).ToString();

            }
        }

        private void cboprod_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboprod.SelectedIndex != -1)
            {
                prodaAgregar = (Producto)cboprod.SelectedItem;
                nupCant.DecimalPlaces = prodaAgregar.unidadMedida.CantidadDecimal;
                txbStock.Text = Math.Round(prodaAgregar.Stock, prodaAgregar.unidadMedida.CantidadDecimal).ToString();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (cboprod.SelectedIndex != -1)
            {
                if (!f.buscar(Convert.ToInt32(cboprod.SelectedValue)))
                {
                    df = new DetalleFactura();

                    if (Convert.ToDecimal(nupCant.Value) != 0)
                    {
                        df.prod = (Producto)cboprod.SelectedItem;
                        df.Cantidad = Math.Round(Convert.ToDecimal(nupCant.Value), df.prod.unidadMedida.CantidadDecimal);
                        df.Precio = df.prod.Precio;
                        df.Descuento = df.prod.Descuento;

                        f.LDetalle.Add(df);
                        cargarDgv(f.LDetalle);
                        txbTotal.Text = "$ " + f.Calcular_Total();
                    }
                }
                else
                {
                    MessageBox.Show("El producto que desea agregar ya está en la lista", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe cargar un producto para poder agregarlo a la lista de Venta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cargarDgv(List<DetalleFactura> lp)
        {
            DgvDetalle.Rows.Clear();

            foreach (DetalleFactura p in lp)
            {
                DgvDetalle.Rows.Add(p.prod.Id_Producto, p.prod.Nombre, p.prod.Descripcion, p.prod.rubro.Nombre, p.prod.marca.Nombre, "$ " + Math.Round(p.Precio, 2),p.Cantidad, "% " + p.prod.Descuento,"$ "+( Math.Round((p.Cantidad * p.Precio),2) -Math.Round(((p.Cantidad*p.Precio)*p.Descuento)/100,2)));

            }
        }

        private void DgvDetalle_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            df = new DetalleFactura();

            if (DgvDetalle.Columns[e.ColumnIndex].Name == "Accion" && f.LDetalle.Count != 0)
            {
                CargarDetalleSelected(Convert.ToInt32(DgvDetalle.CurrentRow.Cells[0].Value));
                f.remover(df);
                DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow);
                txbTotal.Text = f.Calcular_Total().ToString();
                df = new DetalleFactura();
            }
        }

        private void CargarDetalleSelected(int v)
        {
            df = new DetalleFactura();
            foreach (DetalleFactura u in f.LDetalle)
            {
                if (u.prod.Id_Producto == v)
                {
                    df = u;
                    break;
                }
            }
        }
    }
}
