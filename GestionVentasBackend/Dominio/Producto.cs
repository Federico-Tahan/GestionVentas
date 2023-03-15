using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Dominio
{
    public class Producto
    {
        public int Id_Producto { get; set; }
        public Rubro rubro { get; set; }
        public Marca marca  { get; set; }
        public UnidadMedida unidadMedida { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Stock { get; set; }
        public decimal Stock_Minimo { get; set; }
        public int Descuento { get; set; }
        public int BajaLogica { get; set; }

        public bool Seleccindo { get; set; }





    }
}
