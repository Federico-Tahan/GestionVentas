using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Dominio
{
    public class DetalleFactura
    {
        public int id_Detalle { get; set; }
        public Producto prod { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int Descuento { get; set; }
        public int Baja_Logica { get; set; }
    }
}
