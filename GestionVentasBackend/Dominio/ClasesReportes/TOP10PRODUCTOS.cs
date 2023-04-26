using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Dominio.ClasesReportes
{
    public class TOP10PRODUCTOS
    {
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int Cantidad_Vendida { get; set; }
        public decimal stock_minimo { get; set; }
        public decimal stock { get; set; }
        public string Marca { get; set; }
        public string rubro { get; set; }
    }
}
