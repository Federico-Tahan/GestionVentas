using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Dominio
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Alias { get; set; }
        public string Contraseña { get; set; }
        public int Baja_Logica { get; set; }
        public Rol rol { get; set; }
        public Empleado Emp { get; set; }
    }
}
