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

        public bool AltaFp(FormaPago c)
        {
            return lg.AltaFp(c);
        }

        public bool AltaLocalidad(Localidad c)
        {
            return lg.AltaLocalidad(c);
        }

        public bool AltaMarca(Marca c)
        {
            return lg.AltaMarca(c);
        }

        public bool AltaRubro(Rubro c)
        {
            return lg.AltaRubro(c);
        }

        public bool AltaUnidadMed(UnidadMedida c)
        {
            return lg.AltaUnidadMed(c);
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

        public bool UpdateFp(FormaPago c)
        {
            return lg.UpdateFp(c);
        }

        public bool UpdateLocalidad(Localidad c)
        {
            return lg.UpdateLocalidad(c);
        }

        public bool UpdateMarca(Marca c)
        {
            return lg.UpdateMarca(c);
        }

        public bool UpdateRubro(Rubro c)
        {
            return lg.UpdateRubro(c);
        }

        public bool UpdateUnidadMed(UnidadMedida c)
        {
            return lg.UpdateUnidadMed(c);
        }
    }
}
