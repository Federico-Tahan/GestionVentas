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
