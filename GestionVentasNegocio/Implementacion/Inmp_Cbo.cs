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

        public List<FormaPago> ObtenerFormaPago(int modo)
        {
            return lg.ObtenerFormaPago(modo);
        }

        public List<Localidad> ObtenerLocalidad(int modo)
        {
            return lg.ObtenerLocalidad(modo);
        }

        public List<Marca> ObtenerMarcas(int modo)
        {
            return lg.ObtenerMarcas(modo);
        }

        public List<Producto> ObtenerProducto(int rubro, int marca)
        {
            return lg.ObtenerProducto(rubro,marca);
        }

        public List<Rol> ObtenerRol()
        {
            return lg.ObtenerRol();
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
