using GestionVentasBackend.Datos.Implementacion;
using GestionVentasBackend.Datos.Interfaz;
using GestionVentasNegocio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasNegocio.Implementacion
{
    public class ing_InfoPrincipal : Ing_Inforprincipal
    {
        IInfoPrincipal lg;
        public ing_InfoPrincipal()
        {
            lg = new Imp_InfoPrincipal();
        }

        public decimal RecaudadoHoy()
        {
           return lg.RecaudadoHoy();
        }

        public int VentasDelDia()
        {
            return lg.VentasDelDia();
        }

        public int VentasDelMES()
        {
            return lg.VentasDelMES();
        }
    }
}
