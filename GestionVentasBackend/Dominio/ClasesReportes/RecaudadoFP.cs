using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Dominio.ClasesReportes
{
    public class RecaudadoFP
    {
        public string Fecha { get; set; }
        public int id_formaPago { get; set; }
        public string formapago { get; set; }
        public decimal Recaudado { get; set; }
    }
}
