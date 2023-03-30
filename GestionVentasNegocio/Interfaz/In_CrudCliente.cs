using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasNegocio.Interfaz
{
    public interface In_CrudCliente
    {
        bool AltaCliente(Cliente c);
        List<Cliente> TrarClientes();
        bool CheckearDNI(long dni);
        bool ModificacionCliente(Cliente c);

    }
}
