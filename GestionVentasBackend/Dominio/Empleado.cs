using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Dominio
{
    public class Empleado
    {
        public long DNI { get; set; }
        public string Nombre  { get; set; }
        public string Apellido { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string Departamento { get; set; }
        public int Piso { get; set; }
        public long Telefono { get; set; }
        public string Email { get; set; }
        public int Baja_Logica { get; set; }
        public Localidad loc { get; set; }
    }
}
