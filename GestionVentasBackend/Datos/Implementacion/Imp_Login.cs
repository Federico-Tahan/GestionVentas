using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Datos.Implementacion
{
    public class Imp_Login : ILogin
    {
        Encriptacion encriptacion = new Encriptacion();
        public bool CheckLogin(string alias, string contraseña)
        {
                bool band = false;
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@usuario", alias);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@contraseña", encriptacion.Encriptar(contraseña));
                HelperDB.ObtenerInstancia().LeerDB("SP_CheckLogin");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                band = HelperDB.ObtenerInstancia().Dr.Read() ? true : false;
                HelperDB.ObtenerInstancia().close();
                return band;
        }
        public bool Logeado(Usuario u, string alias, string contraseña)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@usuario", alias);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@contraseña", encriptacion.Encriptar(contraseña));
                HelperDB.ObtenerInstancia().LeerDB("SP_Logeado");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();

                if (HelperDB.ObtenerInstancia().Dr.Read())
                {
                    Empleado e = new Empleado();
                    Rol r = new Rol();
                    if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                    {
                        e.DNI = HelperDB.ObtenerInstancia().Dr.GetInt64(0);
                    }
                    if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                    {
                        e.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                    }
                    if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                    {
                        e.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(2);
                    }
                    if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                    {
                        r.id_rol = HelperDB.ObtenerInstancia().Dr.GetInt32(3);
                    }
                    if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                    {
                        u.Id_Usuario = HelperDB.ObtenerInstancia().Dr.GetInt32(4);
                    }
                    u.rol = r;
                    u.Emp = e;
                    HelperDB.ObtenerInstancia().close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
