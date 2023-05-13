using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Datos.Interfaz
{
    public interface IInfoPrincipal
    {
        decimal RecaudadoHoy();

        int VentasDelDia();
        int VentasDelMES();

        bool FaltaStock();

    }
}
