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
    public class Inmp_Cbo : In_Cbos
    {
        iCbos lg;


        public Inmp_Cbo()
        {
            lg = new Imp_Cbos();
        }
        public List<Marca> ObtenerMarcas(int modo)
        {
            return lg.ObtenerMarcas(modo);
        }

        public List<Rubro> ObtenerRubros(int modo)
        {
            return lg.ObtenerRubros(modo);
        }

        public List<UnidadMedida> ObtenerUnidadMedida(int modo)
        {
            return lg.ObtenerUnidadMedida(modo);
        }
    }
}
