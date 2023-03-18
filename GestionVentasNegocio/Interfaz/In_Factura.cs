using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasNegocio.Interfaz
{
    public interface In_Factura
    {
        bool AltaFactura(Factura f);

        bool BajaFactura(Factura f);
        List<Factura> TraerFacturas();
        List<DetalleFactura> TraerDetalleFacturas(int factura);

    }
}
