using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Dominio.ClasesReportes
{
    public class ReporteDeudaCliente
    {
        public long DNI { get; set; }
        public string NombreCompleto { get; set; }
        public decimal DeudaCliente { get; set; }
    }
}
