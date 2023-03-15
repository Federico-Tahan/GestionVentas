using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Dominio
{
    public class UnidadMedida
    {
        public int Id_UnidadMedida { get; set; }
        public string Nombre { get; set; }
        public int BajaLogica { get; set; }
        public int CantidadDecimal { get; set; }
    }
}
