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
    public class Inmp_CrudUsuario : In_CrudUsuario
    {
        ICrudUsuarios lg;

        public Inmp_CrudUsuario() {
            lg = new Imp_CrudUsuario();
            
        }

        public bool AltaUsuario(Usuario u)
        {
            return lg.AltaUsuario(u);
        }

        public bool CheckarAlias(string alias)
        {
            throw new NotImplementedException();
        }

        public bool CheckearDNI(long dni)
        {
            throw new NotImplementedException();
        }

        public bool ModificacionUsuario(Usuario u)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
