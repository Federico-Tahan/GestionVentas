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
using GestionVentasFrontend.Formularios.Extra;
using System.Text.RegularExpressions;
using System.Collections;
using System.IO;

namespace GestionVentasFrontend.Formularios.Venta
{
    public partial class ConsultarVentas : Form
    {
        In_Factura lf;
        In_Cbos lc;
        ing_Configuracion lg = new ng_Configuracion();
        List<Factura> lFacturas = new List<Factura>();
        Factura FacSelected = new Factura();
        List<Producto> productosON = new List<Producto>();
        List<Producto> ProductosCBO = new List<Producto>();
        Producto prodaAgregar = new Producto();
        DetalleFactura df = new DetalleFactura();
        Factura nuevaFactura = new Factura();
        Config con = new Config();
        public ConsultarVentas()
        {
            InitializeComponent();
            lf = new Inmp_Factura();
            lc = new Inmp_Cbo();
            SeleccionarColor();
        }

        private void ConsultarVentas_Load(object sender, EventArgs e)
        {
            con = lg.TraerConfig();
            lFacturas = lf.TraerFacturas();
            CargarDGV(lFacturas);
        }

        private void CargarDGV(List<Factura> listafac)
        {
            DgvFacturas.Rows.Clear();
            foreach (Factura item in listafac)
            {
                item.LDetalle = lf.TraerDetalleFacturas(item.id_factura);
                DgvFacturas.Rows.Add(item.id_factura, item.c.Nombre + " " + item.c.Apellido, item.Fecha, item.fp.Formapago, item.user.Emp.Nombre + " " + item.user.Emp.Apellido, item.Calcular_Total(), item.baja_logica == 0 ? "" : "Cancelada");
            }
        }

        private void DgvFacturas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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


        private void DgvFacturas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvFacturas.Columns[e.ColumnIndex].Name == "action" && DgvFacturas.Rows.Count != 0)
            {
                FacSelected.id_factura = (int)DgvFacturas.CurrentRow.Cells[0].Value;
                CargarFacturaSeleccionado(FacSelected.id_factura);

                cargarDgvDetalle(FacSelected.LDetalle);
                pnlDetalle.Visible = true;
                lbAbona.Text =  FacSelected.monto_pagado.ToString();
                lbFormaPago.Text =  FacSelected.fp.Formapago;
                lbnombre.Text = FacSelected.c.Nombre + " " + FacSelected.c.Apellido;
                if (FacSelected.baja_logica == 0)
                {
                    BtnCancelarVenta.Visible = true;
                    BtnModificar.Visible = true;
                }
                else
                {
                    BtnCancelarVenta.Visible = false;
                    BtnModificar.Visible = false;
                }
            }
            else if (DgvFacturas.Columns[e.ColumnIndex].Name == "Ticket" && DgvFacturas.Rows.Count != 0)
            {
                PrintTicket t = new PrintTicket();
                FacSelected.id_factura = (int)DgvFacturas.CurrentRow.Cells[0].Value;
                CargarFacturaSeleccionado(FacSelected.id_factura);
                if (con.Imagen.Length != 0)
                {
                    t.Logo = Convertir_Bytes_A_Imagen(con.Imagen);
                }
                t.Cajero = FacSelected.user.Emp.Nombre + " " + FacSelected.user.Emp.Apellido;
                t.Direccion = con.Direccion;
                t.CUIT = con.CUIT;
                t.NombreNegocio = con.Nombre;
                t.SubTotal = FacSelected.Calcular_Subtotal().ToString();
                t.Total = FacSelected.Calcular_Total().ToString();
                t.products = FacSelected.LDetalle;
                t.Print();
                FacSelected = new Factura();
            }
        }
        private Image Convertir_Bytes_A_Imagen(byte[] bytes)
        {
            Image imagen;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                imagen = Image.FromStream(ms);
            }
            return imagen;
        }
        private void CargarFacturaSeleccionado(int id_Fac)
        {
            foreach (Factura u in lFacturas)
            {
                if (u.id_factura == id_Fac)
                {
                    FacSelected = u;
                    break;
                }
            }
        }

        private void cargarDgvDetalle(List<DetalleFactura> lp)
        {
            DgvDetalleVenta.Rows.Clear();

            foreach (DetalleFactura p in lp)
            {
                DgvDetalleVenta.Rows.Add(p.prod.Id_Producto, p.prod.Nombre, p.prod.Descripcion, p.prod.rubro.Nombre, p.prod.marca.Nombre, "$ " + Math.Round(p.Precio, 2), p.Cantidad, "% " + p.Descuento, "$ " + (Math.Round((p.Cantidad * p.Precio), 2) - Math.Round(((p.Cantidad * p.Precio) * p.Descuento) / 100, 2)));

            }
        }
        private void cargarDgvProd(List<DetalleFactura> lp)
        {
            DgvModVenta.Rows.Clear();

            foreach (DetalleFactura p in lp)
            {
                DgvModVenta.Rows.Add(p.prod.Id_Producto, p.prod.Nombre, p.prod.Descripcion, p.prod.rubro.Nombre, p.prod.marca.Nombre, "$ " + Math.Round(p.Precio, 2), p.Cantidad, "% " + p.Descuento, "$ " + (Math.Round((p.Cantidad * p.Precio), 2) - Math.Round(((p.Cantidad * p.Precio) * p.Descuento) / 100, 2)));

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
            PnlModificacion.BackColor = ColorTranslator.FromHtml(color);
            pnlDetalle.BackColor = ColorTranslator.FromHtml(color);


        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            pnlDetalle.Visible = false;
            FacSelected = new Factura();
            lbAbona.Text = "Abono con: ";
            lbFormaPago.Text = "Forma de Pago: ";
            lbnombre.Text = "Nombre Completo: ";

        }

        private void BtnCancelarVenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quiere cancelar esta venta?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lf.BajaFactura(FacSelected))
                {
                    MessageBox.Show("Venta dada de baja con Exito", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    pnlDetalle.Visible = false;
                    FacSelected = new Factura();
                    lFacturas = lf.TraerFacturas();
                    CargarDGV(lFacturas);
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            nuevaFactura = new Factura();
            PnlModificacion.Visible = true;
            cargar_cbo(cborubro, "Nombre", "id_rubro", lc.ObtenerRubros(0));
            cborubro.SelectedIndex = 0;
            cargar_cbo(cboMarca, "Nombre", "id_marca", lc.ObtenerMarcas(0));
            cboMarca.SelectedIndex = 0;
            productosON = lc.ObtenerProducto(1, 1);
            CombinarListas();
            cargar_cbo(cboproducto, "Nombre", "Id_Producto", ProductosCBO);
            CopiarFactura();
            nuevaFactura.LDetalle = FacSelected.LDetalle.ToList();
            cargarDgvProd(nuevaFactura.LDetalle);
            txbTotal.Text = "$ " + nuevaFactura.Calcular_Total();
            txbStock.Text = "";




        }

        private void CopiarFactura()
        {
            nuevaFactura.c = FacSelected.c;
            nuevaFactura.fp = FacSelected.fp;
            nuevaFactura.user = FacSelected.user;
            nuevaFactura.id_factura = FacSelected.id_factura;
            nuevaFactura.baja_logica = FacSelected.baja_logica;
            nuevaFactura.monto_pagado = FacSelected.monto_pagado;
            nuevaFactura.Fecha = FacSelected.Fecha;
        }
        private void cargar_cbo<T>(ComboBox cbo, string display, string value, List<T> lista)
        {
            cbo.DataSource = lista;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void CancelarModificacion_Click(object sender, EventArgs e)
        {
            PnlModificacion.Visible = false;
            nuevaFactura = new Factura();

        }


        private void CombinarListas()
        {
            ProductosCBO = productosON;
            foreach (DetalleFactura item in FacSelected.LDetalle)
            {
                bool ban = false;

                foreach (Producto prod in productosON)
                {
                    if (prod.Id_Producto == item.prod.Id_Producto)
                    {
                        ProductosCBO.Find(lp => lp.Id_Producto == item.prod.Id_Producto).Stock += item.Cantidad;
                        ban = true;
                        break;
                    }
                }
                if (!ban)
                {
                    item.prod.Stock = item.Cantidad;
                    ProductosCBO.Add(item.prod);

                }
            }
            
        }

        private void cboproducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboproducto.SelectedIndex != -1)
            {
                prodaAgregar = (Producto)cboproducto.SelectedItem;
                nupcant.DecimalPlaces = prodaAgregar.unidadMedida.CantidadDecimal;
                txbStock.Text = Math.Round(prodaAgregar.Stock, prodaAgregar.unidadMedida.CantidadDecimal).ToString();

            }
        }

        private void cboproducto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboproducto.SelectedIndex != -1)
            {
                prodaAgregar = (Producto)cboproducto.SelectedItem;
                nupcant.DecimalPlaces = prodaAgregar.unidadMedida.CantidadDecimal;
                txbStock.Text = Math.Round(prodaAgregar.Stock, prodaAgregar.unidadMedida.CantidadDecimal).ToString();

            }
        }

        private void cborubro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Producto> productosFiltrados = new List<Producto>();

            foreach (Producto producto in ProductosCBO)
            {
                if (((int)cboMarca.SelectedValue == 1 && (int)cborubro.SelectedValue == 1) ||
                    ((int)cboMarca.SelectedValue == 1 && producto.rubro.id_rubro == (int)cborubro.SelectedValue) ||
                    ((int)cborubro.SelectedValue == 1 && producto.marca.id_Marca == (int)cboMarca.SelectedValue) ||
                    (producto.marca.id_Marca == (int)cboMarca.SelectedValue && producto.rubro.id_rubro == (int)cborubro.SelectedValue))
                {
                    productosFiltrados.Add(producto);
                }
            }

            cargar_cbo(cboproducto, "Nombre", "Id_Producto", productosFiltrados);


        }

        private void cboMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Producto> productosFiltrados = new List<Producto>();

            foreach (Producto producto in ProductosCBO)
            {
                if (((int)cboMarca.SelectedValue == 1 && (int)cborubro.SelectedValue == 1) ||
                    ((int)cboMarca.SelectedValue == 1 && producto.rubro.id_rubro == (int)cborubro.SelectedValue) ||
                    ((int)cborubro.SelectedValue == 1 && producto.marca.id_Marca == (int)cboMarca.SelectedValue) ||
                    (producto.marca.id_Marca == (int)cboMarca.SelectedValue && producto.rubro.id_rubro == (int)cborubro.SelectedValue))
                {
                    productosFiltrados.Add(producto);
                }
            }

            cargar_cbo(cboproducto, "Nombre", "Id_Producto", productosFiltrados);
        }

        private void DgvModVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (cboproducto.SelectedIndex != -1)
            {
                if (Convert.ToDecimal(nupcant.Value) != 0)
                {
                    if (Convert.ToDecimal(nupcant.Value) <= Convert.ToDecimal(txbStock.Text))
                    {
                        if (!nuevaFactura.buscar(Convert.ToInt32(cboproducto.SelectedValue)))
                        {

                            df = new DetalleFactura();
                            df.prod = (Producto)cboproducto.SelectedItem;
                            df.Cantidad = Math.Round(Convert.ToDecimal(nupcant.Value), df.prod.unidadMedida.CantidadDecimal);
                            df.Precio = df.prod.Precio;
                            df.Descuento = df.prod.Descuento;

                            nuevaFactura.LDetalle.Add(df);
                            cargarDgvProd(nuevaFactura.LDetalle);
                            txbTotal.Text = "$ " + nuevaFactura.Calcular_Total();
                        }
                        else
                        {
                            MessageBox.Show("El producto que desea agregar ya está en la lista", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Stock no puede cubrir la cantidad solicitada de este Producto.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Debe cargar una cantidad", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe cargar un producto para poder agregarlo a la lista de Venta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (nuevaFactura.LDetalle.Count == 0)
            {
                MessageBox.Show("Debe Cargar al menos un producto a la venta para continuar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ConfirmarVenta cv = new ConfirmarVenta(nuevaFactura);
            cv.ShowDialog();
            if (cv.DialogResult == DialogResult.OK)
            {
                FacSelected = new Factura();
                nuevaFactura = new Factura();
                PnlModificacion.Visible = false;
                pnlDetalle.Visible = false;
                lFacturas = lf.TraerFacturas();
                CargarDGV(lFacturas);
            }
        }

        private void DgvModVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            df = new DetalleFactura();

            if (DgvModVenta.Columns[e.ColumnIndex].Name == "acion" && nuevaFactura.LDetalle.Count != 0)
            {
                CargarDetalleSelected(Convert.ToInt32(DgvModVenta.CurrentRow.Cells[0].Value));
                nuevaFactura.remover(df);
                DgvModVenta.Rows.Remove(DgvModVenta.CurrentRow);
                txbTotal.Text = "$" + nuevaFactura.Calcular_Total().ToString();
                df = new DetalleFactura();
            }
        }

        private void CargarDetalleSelected(int v)
        {
            df = new DetalleFactura();
            foreach (DetalleFactura u in nuevaFactura.LDetalle)
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
