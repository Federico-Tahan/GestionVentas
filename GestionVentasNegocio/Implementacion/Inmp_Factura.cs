using GestionVentasBackend.Datos.Implementacion;
using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Dominio;
using GestionVentasNegocio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasNegocio.Implementacion
{
    public class Inmp_Factura : In_Factura
    {
        IFactura lg;


        public Inmp_Factura()
        {
            lg = new Imp_Facturas();
        }

        public bool AltaFactura(Factura f)
        {
            return lg.AltaFactura(f);
        }

        public bool BajaFactura(Factura f)
        {
            throw new NotImplementedException();
        }

        public List<DetalleFactura> TraerDetalleFacturas(int factura)
        {
            return lg.TraerDetalleFacturas(factura);
        }

        public List<Factura> TraerFacturas()
        {
            return lg.TraerFacturas();
        }
    }
}
