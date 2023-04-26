using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Dominio;
using GestionVentasBackend.Dominio.ClasesReportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Datos.Implementacion
{
    public class Imp_Reportes : IReportes
    {
        public List<ReporteDeudaCliente> DeudaCliente()
        {
            List<ReporteDeudaCliente> lproducto = new List<ReporteDeudaCliente>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_DeudasClientes");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                ReporteDeudaCliente prod = new ReporteDeudaCliente();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    prod.DNI = HelperDB.ObtenerInstancia().Dr.GetInt64(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    prod.NombreCompleto = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    prod.DeudaCliente = Math.Round(HelperDB.ObtenerInstancia().Dr.GetDecimal(2), 2);
                }
                lproducto.Add(prod);
            }
            HelperDB.ObtenerInstancia().close();
            return lproducto;
        }

        public List<GeneradoXMarca> GetGeneradoxMarca()
        {
            List<GeneradoXMarca> lproducto = new List<GeneradoXMarca>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_GeneradoXMarca");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                GeneradoXMarca prod = new GeneradoXMarca();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    prod.id_Marca = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    prod.Marca = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    prod.Generado = Math.Round(HelperDB.ObtenerInstancia().Dr.GetDecimal(2), 2);
                }
                lproducto.Add(prod);
            }
            HelperDB.ObtenerInstancia().close();
            return lproducto;
        }

        public List<GeneradoxRubro> GetGeneradoxRubro()
        {
            List<GeneradoxRubro> lproducto = new List<GeneradoxRubro>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_GeneradoXRubro");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                GeneradoxRubro prod = new GeneradoxRubro();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    prod.id_rubro = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    prod.rubro = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    prod.Generado = Math.Round(HelperDB.ObtenerInstancia().Dr.GetDecimal(2),2);
                }
                lproducto.Add(prod);
            }
            HelperDB.ObtenerInstancia().close();
            return lproducto;
        }

        public List<TOP10PRODUCTOS> GetProductos()
        {
            List<TOP10PRODUCTOS> lproducto = new List<TOP10PRODUCTOS>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_ReporteTOPproductos");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                TOP10PRODUCTOS prod = new TOP10PRODUCTOS();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    prod.id_producto = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    prod.nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    prod.descripcion = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    prod.precio = Math.Round(HelperDB.ObtenerInstancia().Dr.GetDecimal(3),2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    prod.Cantidad_Vendida = HelperDB.ObtenerInstancia().Dr.GetInt32(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    prod.stock_minimo = Math.Round(HelperDB.ObtenerInstancia().Dr.GetDecimal(5),2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    prod.stock = Math.Round(HelperDB.ObtenerInstancia().Dr.GetDecimal(6), 2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    prod.Marca = HelperDB.ObtenerInstancia().Dr.GetString(7);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    prod.rubro = HelperDB.ObtenerInstancia().Dr.GetString(8);
                }
                lproducto.Add(prod);
            }
            HelperDB.ObtenerInstancia().close();
            return lproducto;
        }

        public List<RecaudadoFP> Recaudacion(int a, int b)
        {
            List<RecaudadoFP> lproducto = new List<RecaudadoFP>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@tipoFecha",a);
            HelperDB.ObtenerInstancia().LeerDB("SP_Reporte_Recaudacion");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                RecaudadoFP prod = new RecaudadoFP();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    prod.Fecha = HelperDB.ObtenerInstancia().Dr.GetString(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    prod.id_formaPago = HelperDB.ObtenerInstancia().Dr.GetInt32(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    prod.formapago = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    prod.Recaudado = Math.Round(HelperDB.ObtenerInstancia().Dr.GetDecimal(3), 2);

                }
                lproducto.Add(prod);
            }
            HelperDB.ObtenerInstancia().close();
            return lproducto;
        }
    }
}
