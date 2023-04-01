using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Datos.Interfaz
{
    public interface IHistorialPago
    {

        bool AltaPago(HistoriaPagoCliente h);
        bool BajaPago(HistoriaPagoCliente h);

        List<HistoriaPagoCliente> TraerPagos(int modo);

    }
}
