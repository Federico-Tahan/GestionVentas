using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Dominio
{
    public class Cliente
    {
        public long DNINuevo { get; set; }

        public long DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Telefono { get; set; }
        public string Email { get; set; }
        public decimal Debe { get; set; }
        public int BajaLogica { get; set; }
    }
}
