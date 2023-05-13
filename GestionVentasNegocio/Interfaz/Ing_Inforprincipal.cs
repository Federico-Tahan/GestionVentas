using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasNegocio.Interfaz
{
    public interface Ing_Inforprincipal
    {
        decimal RecaudadoHoy();
        int VentasDelDia();
        int VentasDelMES();
        bool FaltaStock();
    }
}
