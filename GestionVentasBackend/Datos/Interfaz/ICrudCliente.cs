using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Datos.Interfaz
{
    public interface ICrudCliente
    {
        bool AltaCliente(Cliente c);
        List<Cliente> TrarClientes();
        bool CheckearDNI(long dni);
        bool ModificacionCliente(Cliente c);
    }
}
