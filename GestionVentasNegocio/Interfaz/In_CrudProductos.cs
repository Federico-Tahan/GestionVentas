using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionVentasBackend.Dominio;

namespace GestionVentasNegocio.Interfaz
{
    public interface In_CrudProductos
    {
        bool AltaProducto(Producto p);
        bool ModificacionProducto(Producto p);
        List<Producto> ObtenerProductos(int modo);
    }
}
