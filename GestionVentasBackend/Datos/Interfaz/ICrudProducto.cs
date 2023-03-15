using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Datos.Interfaz
{
    public interface ICrudProducto
    {
        bool AltaProducto(Producto p);
        bool ModificacionProducto(Producto p);
        List<Producto> ObtenerProductos(int modo);
    }
}
