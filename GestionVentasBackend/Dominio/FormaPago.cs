using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Dominio
{
    public class FormaPago
    {
        public int id_formapago { get; set; }
        public string Formapago { get; set; }
        public int Baja_logica { get; set; }
    }
}
