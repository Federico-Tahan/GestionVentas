using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Dominio
{
    public class Config
    {
        public string CUIT { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public byte[] Imagen { get; set; }
    }
}
