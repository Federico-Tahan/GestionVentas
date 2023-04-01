using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasNegocio.Interfaz
{
    public interface In_HistorialPago
    {
        bool AltaPago(HistoriaPagoCliente h);
        bool BajaPago(HistoriaPagoCliente h);

        List<HistoriaPagoCliente> TraerPagos(int modo);

    }
}
