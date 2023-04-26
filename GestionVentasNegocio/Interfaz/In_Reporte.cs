using GestionVentasBackend.Dominio.ClasesReportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasNegocio.Interfaz
{
    public interface In_Reporte
    {
        List<TOP10PRODUCTOS> GetProductos();
        List<GeneradoxRubro> GetGeneradoxRubro();
        List<GeneradoXMarca> GetGeneradoxMarca();
        List<ReporteDeudaCliente> DeudaCliente();
        List<RecaudadoFP> Recaudacion(int a, int b);



    }
}
