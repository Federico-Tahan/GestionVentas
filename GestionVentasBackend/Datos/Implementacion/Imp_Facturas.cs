using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Datos.Implementacion
{
    public class Imp_Facturas : IFactura
    {
        public bool AltaFactura(Factura f)
        {
            bool bandera = false;
            SqlConnection conn = HelperDB.ObtenerInstancia().conexion();
            SqlTransaction tr = null;
            try
            {
                HelperDB.ObtenerInstancia().open();
                tr = conn.BeginTransaction();
                HelperDB.ObtenerInstancia().Command.Transaction = tr;
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_formapago", f.fp.id_formapago);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", f.c.Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@apellido", f.c.Apellido);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_cliente", f.c.DNI);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario", 22);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@monto_pagado", f.monto_pagado);


                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@IDFACTURA";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                HelperDB.ObtenerInstancia().Command.Parameters.Add(pOut);
                HelperDB.ObtenerInstancia().Command.CommandText = "AltaFactura";
                HelperDB.ObtenerInstancia().Command.ExecuteNonQuery();
                f.id_factura = (int)pOut.Value;

                HelperDB.ObtenerInstancia().Command.Parameters.Clear();

                for (int i = 0; i < f.LDetalle.Count; i++)
                {
                    HelperDB.ObtenerInstancia().Command.Transaction = tr;

                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_factura", f.id_factura);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_producto", f.LDetalle[i].prod.Id_Producto);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@cantidad", f.LDetalle[i].Cantidad);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@precio", f.LDetalle[i].Precio);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@descuento", f.LDetalle[i].Descuento);

                    HelperDB.ObtenerInstancia().Command.CommandText = "SP_AltaDetalle";
                    HelperDB.ObtenerInstancia().Command.ExecuteNonQuery();
                    HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                }
                tr.Commit();
                bandera = true;
            }
            catch (Exception)
            {
                tr.Rollback();
                bandera = false;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    HelperDB.ObtenerInstancia().close();
                }
            }
            return bandera;
        }

        public bool BajaFactura(Factura f)
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_factura", f.id_factura);
            HelperDB.ObtenerInstancia().updatear_db("SP_CacelarVenta");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            return true;
        }
        public bool BajaDetalleFactura(Factura f)
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_factura", f.id_factura);
            HelperDB.ObtenerInstancia().updatear_db("SP_CacelarDetalle");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            return true;
        }

        public bool ModificarFactura(Factura f)
        {
            if (BajaDetalleFactura(f))
            {
                bool bandera = false;
                SqlConnection conn = HelperDB.ObtenerInstancia().conexion();
                SqlTransaction tr = null;
                try
                {
                    HelperDB.ObtenerInstancia().open();
                    tr = conn.BeginTransaction();
                    HelperDB.ObtenerInstancia().Command.Transaction = tr;
                    HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_factura", f.id_factura);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_formapago", f.fp.id_formapago);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", f.c.Nombre);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@apellido", f.c.Apellido);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_cliente", f.c.DNI);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario", 22);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@monto_pagado", f.monto_pagado);
                    HelperDB.ObtenerInstancia().Command.CommandText = "SP_ModficarVenta";
                    HelperDB.ObtenerInstancia().Command.ExecuteNonQuery();

                    HelperDB.ObtenerInstancia().Command.Parameters.Clear();

                    for (int i = 0; i < f.LDetalle.Count; i++)
                    {
                        HelperDB.ObtenerInstancia().Command.Transaction = tr;

                        HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_factura", f.id_factura);
                        HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_producto", f.LDetalle[i].prod.Id_Producto);
                        HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@cantidad", f.LDetalle[i].Cantidad);
                        HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@precio", f.LDetalle[i].Precio);
                        HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@descuento", f.LDetalle[i].Descuento);

                        HelperDB.ObtenerInstancia().Command.CommandText = "SP_AltaDetalle";
                        HelperDB.ObtenerInstancia().Command.ExecuteNonQuery();
                        HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                    }
                    tr.Commit();
                    bandera = true;
                }
                catch (Exception)
                {
                    tr.Rollback();
                    bandera = false;
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        HelperDB.ObtenerInstancia().close();
                    }
                }
                return bandera;

            }
            else
            {
                return false;
            }
        }

        public List<DetalleFactura> TraerDetalleFacturas(int factura)
        {
            List<DetalleFactura> ldet = new List<DetalleFactura>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_factura", factura);
            HelperDB.ObtenerInstancia().LeerDB("SP_TraerDetalles");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                DetalleFactura detfac = new DetalleFactura();
                Producto p = new Producto();
                Rubro r = new Rubro();
                UnidadMedida um = new UnidadMedida();
                Marca marca = new Marca();  
                p.rubro = r;
                p.marca = marca;
                p.unidadMedida= um;
                detfac.prod = p;

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    detfac.id_Detalle = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    detfac.prod.Id_Producto = HelperDB.ObtenerInstancia().Dr.GetInt32(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    detfac.Cantidad = HelperDB.ObtenerInstancia().Dr.GetInt32(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    detfac.Precio = Math.Round(HelperDB.ObtenerInstancia().Dr.GetDecimal(2),2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    detfac.Descuento = HelperDB.ObtenerInstancia().Dr.GetInt32(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    detfac.prod.Nombre= HelperDB.ObtenerInstancia().Dr.GetString(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    detfac.prod.Descripcion = HelperDB.ObtenerInstancia().Dr.GetString(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    detfac.prod.unidadMedida.Id_UnidadMedida = HelperDB.ObtenerInstancia().Dr.GetInt32(7);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    detfac.prod.unidadMedida.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(8);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(9))
                {
                    detfac.prod.unidadMedida.CantidadDecimal = HelperDB.ObtenerInstancia().Dr.GetInt32(9);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(10))
                {
                    detfac.prod.marca.id_Marca = HelperDB.ObtenerInstancia().Dr.GetInt32(10);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(11))
                {
                    detfac.prod.marca.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(11);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(12))
                {
                    detfac.prod.rubro.id_rubro = HelperDB.ObtenerInstancia().Dr.GetInt32(12);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(13))
                {
                    detfac.prod.rubro.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(13);
                }
                ldet.Add(detfac);
            }


            HelperDB.ObtenerInstancia().close();
            return ldet;

        }

        public List<Factura> TraerFacturas()
        {
            List<Factura> lFactura = new List<Factura>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_TraerFacturas");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Factura factura = new Factura();
                FormaPago fp = new FormaPago();
                Cliente c = new Cliente();
                Usuario u = new Usuario();
                Empleado em = new Empleado();
                u.Emp = em;
                factura.fp = fp; 
                factura.c = c;
                factura.user= u;

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    factura.id_factura = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    factura.Fecha = HelperDB.ObtenerInstancia().Dr.GetDateTime(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    factura.fp.id_formapago = HelperDB.ObtenerInstancia().Dr.GetInt32(2);
                    factura.fp.Formapago = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    factura.c.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    factura.c.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    factura.c.DNI = HelperDB.ObtenerInstancia().Dr.GetInt64(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    factura.user.Id_Usuario = HelperDB.ObtenerInstancia().Dr.GetInt32(7);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    factura.user.Emp.DNI = HelperDB.ObtenerInstancia().Dr.GetInt64(8);
                    factura.user.Emp.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(9);
                    factura.user.Emp.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(10);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(11))
                {
                    factura.monto_pagado =Math.Round( HelperDB.ObtenerInstancia().Dr.GetDecimal(11),2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(12))
                {
                    factura.baja_logica = HelperDB.ObtenerInstancia().Dr.GetInt32(12);
                }
                lFactura.Add(factura);
            }


            HelperDB.ObtenerInstancia().close();
            return lFactura;
        }
    }
}
