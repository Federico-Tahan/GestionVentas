using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Datos.Implementacion
{
    public class Imp_CrudProducto : ICrudProducto
    {
        public bool AltaProducto(Producto p)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_rubro", p.rubro.id_rubro);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_marca", p.marca.id_Marca);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", p.Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@descripcion", p.Descripcion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@precio", Math.Round(p.Precio,2));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@descuento", p.Descuento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@stock", Math.Round(p.Stock, 2));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@stock_minimo", Math.Round(p.Stock_Minimo,2));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_unidadMedida", p.unidadMedida.Id_UnidadMedida);
                HelperDB.ObtenerInstancia().updatear_db("SP_InsertarProducto");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ModificacionProducto(Producto p)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_producto", p.Id_Producto);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_rubro", p.rubro.id_rubro);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_marca", p.marca.id_Marca);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", p.Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@descripcion", p.Descripcion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@precio", Math.Round(p.Precio, 2));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@descuento", p.Descuento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@stock", Math.Round(p.Stock,2));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@stock_minimo", Math.Round(p.Stock_Minimo,2));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_unidadMedida", p.unidadMedida.Id_UnidadMedida);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@baja_logica", p.BajaLogica);
                HelperDB.ObtenerInstancia().updatear_db("SP_ModificarProductow");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Producto> ObtenerProductos(int modo)
        {
            List<Producto> lproducto = new List<Producto>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@modo", modo);
            HelperDB.ObtenerInstancia().LeerDB("SP_ObtenerProductos");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Producto prod = new Producto();
                UnidadMedida um = new UnidadMedida();
                Marca m = new Marca();
                Rubro r = new Rubro();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    prod.Id_Producto = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                   r.id_rubro = HelperDB.ObtenerInstancia().Dr.GetInt32(1);
                   r.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    m.id_Marca = HelperDB.ObtenerInstancia().Dr.GetInt32(3);
                    m.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    prod.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    prod.Descripcion = HelperDB.ObtenerInstancia().Dr.GetString(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    prod.Precio = HelperDB.ObtenerInstancia().Dr.GetDecimal(7);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    prod.Descuento = HelperDB.ObtenerInstancia().Dr.GetInt32(8);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(9))
                {
                    prod.Stock = HelperDB.ObtenerInstancia().Dr.GetDecimal(9);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(10))
                {
                    prod.Stock_Minimo = HelperDB.ObtenerInstancia().Dr.GetDecimal(10);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(11))
                {
                    um.Id_UnidadMedida = HelperDB.ObtenerInstancia().Dr.GetInt32(11);
                    um.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(12);
                    um.CantidadDecimal = HelperDB.ObtenerInstancia().Dr.GetInt32(14);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(13))
                {
                    prod.BajaLogica = HelperDB.ObtenerInstancia().Dr.GetInt32(13);
                }

                prod.rubro = r;
                prod.marca = m;
                prod.unidadMedida = um;
                lproducto.Add(prod);
            }
            HelperDB.ObtenerInstancia().close();
            return lproducto;
        }
    }
}
