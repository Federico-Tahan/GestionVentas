using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Dominio
{
    public class Factura
    {
        public int id_factura { get; set; }
        public DateTime Fecha { get; set; }
        public FormaPago fp { get; set; }
        public Cliente c { get; set; }
        public Usuario user { get; set; }
        public decimal monto_pagado { get; set; }
        public int baja_logica { get; set; }
        public List<DetalleFactura> LDetalle { get; set; }

        public bool buscar(int value)
        {
           return LDetalle.Any(detalle => detalle.prod.Id_Producto == value);

        }

        public void remover(DetalleFactura df)
        {
            LDetalle.Remove(df);
        }

        public decimal Calcular_Subtotal()
        {
            decimal SubTotal = 0;
            foreach (DetalleFactura item in LDetalle)
            {
                SubTotal += item.Precio * item.Cantidad;
            }

            return Math.Round(SubTotal, 2);
        }
        public decimal Calcular_Total()
        {
            decimal Total = 0;
            foreach (DetalleFactura item in LDetalle)
            {
                decimal subtotal = item.Cantidad * item.Precio;
                if (item.Descuento != 100 && item.Descuento > 0 && item.Descuento < 100)
                {
                    subtotal = subtotal -(subtotal * item.Descuento) / 100;
                }
                else if (item.Descuento ==100)
                {
                    subtotal = 0;
                }
                Total += subtotal;
            }
            return Math.Round(Total, 2);
        }
    }

}
