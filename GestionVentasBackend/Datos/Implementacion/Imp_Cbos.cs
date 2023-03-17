using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Datos.Implementacion
{
    public class Imp_Cbos : iCbos
    {
        public List<Localidad> ObtenerLocalidad(int modo)
        {
            List<Localidad> td = new List<Localidad>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@modo", modo);

            HelperDB.ObtenerInstancia().LeerDB("SP_ObtenerLocalidad");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Localidad rl = new Localidad();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.id_Localidad = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    rl.Baja_Logica = HelperDB.ObtenerInstancia().Dr.GetInt32(2);
                }
                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<Marca> ObtenerMarcas(int modo)
        {
            List<Marca> td = new List<Marca>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@modo", modo);

            HelperDB.ObtenerInstancia().LeerDB("SP_OBTENER_Marcas");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Marca rl = new Marca();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.id_Marca = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<Producto> ObtenerProducto(int rubro, int marca)
        {
            List<Producto> lproducto = new List<Producto>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@rubro", rubro);
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@marca", marca);
            HelperDB.ObtenerInstancia().LeerDB("SP_ObtenerProductoMarcaRubro");
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

        public List<Rol> ObtenerRol()
        {
            List<Rol> td = new List<Rol>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_OBTENER_ROL");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Rol rl = new Rol();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.id_rol = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<Rubro> ObtenerRubros(int modo)
        {
            List<Rubro> td = new List<Rubro>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@modo", modo);

            HelperDB.ObtenerInstancia().LeerDB("SP_OBTENER_Rubro");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Rubro rl = new Rubro();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.id_rubro = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<UnidadMedida> ObtenerUnidadMedida(int modo)
        {
            List<UnidadMedida> td = new List<UnidadMedida>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@modo", modo);

            HelperDB.ObtenerInstancia().LeerDB("SP_OBTENER_UnidadMedida");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                UnidadMedida rl = new UnidadMedida();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.Id_UnidadMedida = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.CantidadDecimal = HelperDB.ObtenerInstancia().Dr.GetInt32(3);
                }
                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }
    }
}
