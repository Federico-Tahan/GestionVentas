using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Dominio
{
    public class HistoriaPagoCliente
    {
        public int Id_pago { get; set; }
        public Cliente client { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
