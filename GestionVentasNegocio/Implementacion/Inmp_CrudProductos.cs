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
    public class Inmp_CrudProductos : In_CrudProductos
    {
        ICrudProducto lg;


        public Inmp_CrudProductos()
        {
            lg = new Imp_CrudProducto();
        }
        public bool AltaProducto(Producto p)
        {
            return lg.AltaProducto(p);
        }

        public bool ModificacionProducto(Producto p)
        {
            return lg.ModificacionProducto(p);
        }

        public List<Producto> ObtenerProductos(int modo)
        {
            return lg.ObtenerProductos(modo);
        }
    }
}
