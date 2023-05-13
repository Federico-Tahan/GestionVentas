using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionVentasBackend.Dominio;

namespace GestionVentasNegocio.Interfaz
{
    public interface In_Cbos
    {
        List<Marca> ObtenerMarcas(int modo);
        List<UnidadMedida> ObtenerUnidadMedida(int modo);
        List<Rubro> ObtenerRubros(int modo);
        List<Localidad> ObtenerLocalidad(int modo);
        List<Rol> ObtenerRol();
        List<Producto> ObtenerProducto(int rubro, int marca);
        List<FormaPago> ObtenerFormaPago(int modo);

        bool AltaUnidadMed(UnidadMedida c);
        bool UpdateUnidadMed(UnidadMedida c);


        bool AltaLocalidad(Localidad c);
        bool UpdateLocalidad(Localidad c);

        bool AltaMarca(Marca c);
        bool UpdateMarca(Marca c);
        bool AltaRubro(Rubro c);
        bool UpdateRubro(Rubro c);
        bool AltaFp(FormaPago c);
        bool UpdateFp(FormaPago c);
    }
}
