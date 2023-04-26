using GestionVentasBackend.Datos.Implementacion;
using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Dominio.ClasesReportes;
using GestionVentasNegocio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasNegocio.Implementacion
{
    public class Inmp_Reporte : In_Reporte
    {
        IReportes lg;
        public Inmp_Reporte()
        {
            lg = new Imp_Reportes();
        }

        public List<ReporteDeudaCliente> DeudaCliente()
        {
            return lg.DeudaCliente();
        }


        public List<GeneradoXMarca> GetGeneradoxMarca()
        {
            return lg.GetGeneradoxMarca();
        }

        public List<GeneradoxRubro> GetGeneradoxRubro()
        {
            return lg.GetGeneradoxRubro();
        }

        public List<TOP10PRODUCTOS> GetProductos()
        {
            return lg.GetProductos();
        }

        public List<RecaudadoFP> Recaudacion(int a, int b)
        {
            return lg.Recaudacion(a,b);
        }
    }
}
