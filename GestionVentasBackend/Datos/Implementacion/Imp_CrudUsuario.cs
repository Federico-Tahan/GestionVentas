using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_rol", u.rol.id_rol);
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
            bool band = false;
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@ALIAS", alias);
            HelperDB.ObtenerInstancia().LeerDB("SP_EXISTEALIAS");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            band = HelperDB.ObtenerInstancia().Dr.Read() ? true : false;
            HelperDB.ObtenerInstancia().close();
            return band;

        }

        public bool CheckearDNI(long dni)
        {
            bool band = false;
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@DNI", dni);
            HelperDB.ObtenerInstancia().LeerDB("SP_EXISTEDNI");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            band = HelperDB.ObtenerInstancia().Dr.Read() ? true : false;
            HelperDB.ObtenerInstancia().close();
            return band;

        }

        public bool ModificacionUsuario(Usuario u)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario", u.Id_Usuario);
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
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_rol", u.rol.id_rol);
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
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@modo", a);
            HelperDB.ObtenerInstancia().LeerDB("SP_ObtenerUsuarios");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Usuario usuario = new Usuario();
                Empleado e = new Empleado();
                Rol r = new Rol();
                usuario.rol= r;
                Localidad l = new Localidad();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    usuario.Alias = HelperDB.ObtenerInstancia().Dr.GetString(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    usuario.Contraseña = encrypt.Desencriptar(HelperDB.ObtenerInstancia().Dr.GetString(1));
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    usuario.Baja_Logica = HelperDB.ObtenerInstancia().Dr.GetInt32(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    e.DNI = HelperDB.ObtenerInstancia().Dr.GetInt64(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    e.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    e.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    e.Calle = HelperDB.ObtenerInstancia().Dr.GetString(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    e.Altura = HelperDB.ObtenerInstancia().Dr.GetInt32(7);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    e.Piso = HelperDB.ObtenerInstancia().Dr.GetInt32(8);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(9))
                {
                    e.Departamento = HelperDB.ObtenerInstancia().Dr.GetString(9);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(10))
                {
                    e.Telefono = HelperDB.ObtenerInstancia().Dr.GetInt64(10);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(11))
                {
                    e.Email = HelperDB.ObtenerInstancia().Dr.GetString(11);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(12))
                {
                    l.id_Localidad = HelperDB.ObtenerInstancia().Dr.GetInt32(12);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(13))
                {
                    l.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(13);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(14))
                {
                    usuario.Id_Usuario = HelperDB.ObtenerInstancia().Dr.GetInt32(14);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(15))
                {
                    usuario.rol.id_rol = HelperDB.ObtenerInstancia().Dr.GetInt32(15);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(16))
                {
                    usuario.rol.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(16);
                }
                e.loc = l;
                usuario.Emp = e;

                lUsuarios.Add(usuario);
            }


            HelperDB.ObtenerInstancia().close();
            return lUsuarios;
        }
    }
}
