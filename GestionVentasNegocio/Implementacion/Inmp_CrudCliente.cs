using GestionVentasBackend.Datos.Implementacion;
using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Dominio;
using GestionVentasNegocio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasNegocio.Implementacion
{
    public class Inmp_CrudCliente : In_CrudCliente
    {
        ICrudCliente lg;
        public Inmp_CrudCliente()
        {
            lg = new Imp_Cliente();
        }

        public bool AltaCliente(Cliente c)
        {
           return lg.AltaCliente(c);
        }

        public bool CheckearDNI(long dni)
        {
            return lg.CheckearDNI(dni);
        }

        public bool ModificacionCliente(Cliente c)
        {
            return lg.ModificacionCliente(c);
        }

        public List<Cliente> TrarClientes()
        {
            return lg.TrarClientes();
        }
    }
}
