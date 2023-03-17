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
            return lg.CheckarAlias(alias);
        }

        public bool CheckearDNI(long dni)
        {
            return lg.CheckearDNI(dni);
        }

        public bool ModificacionUsuario(Usuario u)
        {
            return lg.ModificacionUsuario(u);
        }

        public List<Usuario> ObtenerUsuarios(int a)
        {
            return lg.ObtenerUsuarios(a);
        }
    }
}
