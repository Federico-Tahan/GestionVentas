using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Datos.Interfaz
{
    public interface iCbos
    {
        List<Marca> ObtenerMarcas(int modo);
        List<UnidadMedida> ObtenerUnidadMedida(int modo);
        List<Rubro> ObtenerRubros(int modo);

    }
}
