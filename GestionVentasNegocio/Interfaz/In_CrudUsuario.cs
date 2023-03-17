using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasNegocio.Interfaz
{
    public interface In_CrudUsuario
    {
        bool AltaUsuario(Usuario u);
        bool ModificacionUsuario(Usuario u);
        List<Usuario> ObtenerUsuarios(int a);
        bool CheckearDNI(long dni);
        bool CheckarAlias(string alias);
    }
}
