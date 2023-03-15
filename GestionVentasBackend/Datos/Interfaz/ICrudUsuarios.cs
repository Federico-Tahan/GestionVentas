using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Datos.Interfaz
{
    public interface ICrudUsuarios
    {
        bool AltaUsuario(Usuario u);
        bool ModificacionUsuario(Usuario u);
        List<Usuario> ObtenerUsuarios(int a);
        bool CheckearDNI(long dni);
        bool CheckarAlias(string alias);


    }
}
