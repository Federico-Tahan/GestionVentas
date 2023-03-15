using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Datos.Implementacion
{
    public class Imp_CrudUsuario : ICrudUsuarios
    {
        Encriptacion encrypt = new Encriptacion();

        public bool AltaUsuario(Usuario u)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@DNI", u.Emp.DNI);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", u.Emp.Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@apellido", u.Emp.Apellido);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@calle", u.Emp.Calle);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@altura", u.Emp.Altura);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@piso", u.Emp.Piso);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@departamento", u.Emp.Departamento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@localidad", 1);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@Telefono", u.Emp.Telefono);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@Email", u.Emp.Email);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@Alias", u.Alias);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@Contraseña",encrypt.Encriptar(u.Contraseña));

                HelperDB.ObtenerInstancia().updatear_db("SP_Insertar_Usuario");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CheckarAlias(string alias)
        {
            throw new NotImplementedException();
        }

        public bool CheckearDNI(long dni)
        {
            throw new NotImplementedException();
        }

        public bool ModificacionUsuario(Usuario u)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@DNI", u.Emp.DNI);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", u.Emp.Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@apellido", u.Emp.Apellido);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@calle", u.Emp.Calle);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@altura", u.Emp.Altura);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@piso", u.Emp.Piso);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@departamento", u.Emp.Departamento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@localidad", 1);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@Telefono", u.Emp.Telefono);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@Email", u.Emp.Email);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@Alias", u.Alias);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@Contraseña", encrypt.Encriptar(u.Contraseña));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@bajaLogica", u.Baja_Logica);
                HelperDB.ObtenerInstancia().updatear_db("SP_Modificar_Usuario");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Usuario> ObtenerUsuarios(int a)
        {
            List<Usuario> lUsuarios = new List<Usuario>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@condicion", a);
            HelperDB.ObtenerInstancia().LeerDB("SP_Obtener_usuarios");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Usuario usuario = new Usuario();
                Empleado e = new Empleado();

                Localidad l = new Localidad();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    e.DNI = HelperDB.ObtenerInstancia().Dr.GetInt64(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    usuario.ID_Usuario = HelperDB.ObtenerInstancia().Dr.GetInt32(1);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    e.DNI = HelperDB.ObtenerInstancia().Dr.GetInt64(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    e.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    e.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    e.Direccion = HelperDB.ObtenerInstancia().Dr.GetString(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    e.FechaNacimiento = HelperDB.ObtenerInstancia().Dr.GetDateTime(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    e.Telefono = HelperDB.ObtenerInstancia().Dr.GetInt64(7);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    e.Baja_logica = HelperDB.ObtenerInstancia().Dr.GetInt32(8);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(9))
                {
                    usuario.Alias = HelperDB.ObtenerInstancia().Dr.GetString(9);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(10))
                {
                    usuario.Contraseña = encrypt.Desencriptar(HelperDB.ObtenerInstancia().Dr.GetString(10));
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(11))
                {
                    r.Id_Rol = HelperDB.ObtenerInstancia().Dr.GetInt32(11);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(12))
                {
                    usuario.Baja_Logica = HelperDB.ObtenerInstancia().Dr.GetInt32(12);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(13))
                {
                    r.Rol = HelperDB.ObtenerInstancia().Dr.GetString(13);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(14))
                {
                    usuario.FechaAlta = HelperDB.ObtenerInstancia().Dr.GetDateTime(14);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(15))
                {
                    usuario.FechaBaja = HelperDB.ObtenerInstancia().Dr.GetDateTime(15);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(16))
                {
                    e.Altura = HelperDB.ObtenerInstancia().Dr.GetInt32(16);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(17))
                {
                    e.Piso = HelperDB.ObtenerInstancia().Dr.GetInt32(17);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(18))
                {
                    e.Departamento = HelperDB.ObtenerInstancia().Dr.GetString(18);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(19))
                {
                    l.idLocalidad = HelperDB.ObtenerInstancia().Dr.GetInt32(19);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(20))
                {
                    l.NLocalidad = HelperDB.ObtenerInstancia().Dr.GetString(20);

                }
                e.Loc = l;
                usuario.Empleado = e;
                usuario.Rol = r;
                lUsuarios.Add(usuario);
            }
            HelperDB.ObtenerInstancia().close();
            return lUsuarios;
        }
    }
}
