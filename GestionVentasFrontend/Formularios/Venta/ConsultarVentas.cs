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
    public partial class ConsultarVentas : Form
    {
        In_Factura lf;
        List<Factura> lFacturas = new List<Factura>();
        Factura FacSelected = new Factura();
        public ConsultarVentas()
        {
            InitializeComponent();
            lf = new Inmp_Factura();
        }

        private void ConsultarVentas_Load(object sender, EventArgs e)
        {
            lFacturas = lf.TraerFacturas();
            CargarDGV(lFacturas);
        }

        private void CargarDGV(List<Factura> listafac)
        {
            DgvFacturas.Rows.Clear();
            foreach (Factura item in listafac)
            {
                item.LDetalle = lf.TraerDetalleFacturas(item.id_factura);
                DgvFacturas.Rows.Add(item.id_factura,item.c.Nombre + " " + item.c.Apellido,item.Fecha,item.fp.Formapago, "$"+ item.monto_pagado.ToString(),item.Calcular_Total(),item.baja_logica == 0 ? "": "Cancelada");
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
                lbAbona.Text = "Abono con: $"+ FacSelected.monto_pagado.ToString();
                lbFormaPago.Text = "Forma de Pago: "+ FacSelected.fp.Formapago;
                lbnombre.Text = "Nombre Completo: " + FacSelected.c.Nombre + " "+ FacSelected.c.Apellido;
            }
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
                DgvDetalleVenta.Rows.Add(p.prod.Id_Producto, p.prod.Nombre, p.prod.Descripcion, p.prod.rubro.Nombre, p.prod.marca.Nombre, "$ " + Math.Round(p.Precio, 2), p.Cantidad, "% " + p.prod.Descuento, "$ " + (Math.Round((p.Cantidad * p.Precio), 2) - Math.Round(((p.Cantidad * p.Precio) * p.Descuento) / 100, 2)));

            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            pnlDetalle.Visible = false;
            FacSelected = new Factura();
            lbAbona.Text = "Abono con: ";
            lbFormaPago.Text = "Forma de Pago: ";
            lbnombre.Text = "Nombre Completo: ";

        }
    }
}
