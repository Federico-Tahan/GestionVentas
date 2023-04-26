using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Datos.Implementacion
{
    public class Imp_InfoPrincipal : IInfoPrincipal
    {
        public decimal RecaudadoHoy()
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().LeerDB("SP_RecaudadoHoy");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();

                if (HelperDB.ObtenerInstancia().Dr.Read())
                {
                    if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                    {
                        decimal valor = Math.Round(HelperDB.ObtenerInstancia().Dr.GetDecimal(0), 2);
                        HelperDB.ObtenerInstancia().close();
                        return valor;
                    }
           
                    HelperDB.ObtenerInstancia().close();
                    return 0;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int VentasDelDia()
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().LeerDB("SP_VentasdelDia");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();

                if (HelperDB.ObtenerInstancia().Dr.Read())
                {
                    if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                    {
                        int valor = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                        HelperDB.ObtenerInstancia().close();
                        return valor;
                    }

                    HelperDB.ObtenerInstancia().close();
                    return 0;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int VentasDelMES()
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().LeerDB("SP_VentasdelMES");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();

                if (HelperDB.ObtenerInstancia().Dr.Read())
                {
                    if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                    {
                        int valor = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                        HelperDB.ObtenerInstancia().close();
                        return valor;
                    }

                    HelperDB.ObtenerInstancia().close();
                    return 0;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
