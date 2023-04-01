using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionVentasBackend.Dominio;
using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Datos.Implementacion;
using GestionVentasNegocio.Interfaz;
namespace GestionVentasNegocio.Implementacion
{
    public class Inmp_HistorialPago : In_HistorialPago
    {
        IHistorialPago lg;
        public Inmp_HistorialPago()
        {
            lg = new Imp_HistorialPago();
        }

        public bool AltaPago(HistoriaPagoCliente h)
        {
            return lg.AltaPago(h);
        }

        public bool BajaPago(HistoriaPagoCliente h)
        {
            return lg.BajaPago(h);
        }

        public List<HistoriaPagoCliente> TraerPagos(int modo)
        {
            return lg.TraerPagos(modo);
        }
    }
}
