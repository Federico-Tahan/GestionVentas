using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Datos.Implementacion
{
    public class Imp_HistorialPago : IHistorialPago
    {
        public bool AltaPago(HistoriaPagoCliente h)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@DNI", h.client.DNI);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@monto", h.Monto);
                HelperDB.ObtenerInstancia().updatear_db("SP_AltaPago");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool BajaPago(HistoriaPagoCliente h)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_pago", h.Id_pago);
                HelperDB.ObtenerInstancia().updatear_db("SP_BajaPago");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<HistoriaPagoCliente> TraerPagos(int modo)
        {
            List<HistoriaPagoCliente> td = new List<HistoriaPagoCliente>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@modo", modo);

            HelperDB.ObtenerInstancia().LeerDB("SP_TraerHistorialPago");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                HistoriaPagoCliente rl = new HistoriaPagoCliente();
                Cliente client = new Cliente();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.Id_pago = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    client.DNI = HelperDB.ObtenerInstancia().Dr.GetInt64(1);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    client.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                   client.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    rl.Fecha = HelperDB.ObtenerInstancia().Dr.GetDateTime(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    rl.Baja_Logica = HelperDB.ObtenerInstancia().Dr.GetInt32(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    rl.Monto = Math.Round(HelperDB.ObtenerInstancia().Dr.GetDecimal(6),2);
                }
                rl.client = client;
                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }
    }
}
