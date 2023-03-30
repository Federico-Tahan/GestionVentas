using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Datos.Implementacion
{
    public class Imp_Cliente : ICrudCliente
    {
        public bool AltaCliente(Cliente c)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@DNI", c.DNI);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", c.Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@apellido", c.Apellido);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@telefono", c.Telefono);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@email", c.Email);
                HelperDB.ObtenerInstancia().updatear_db("SP_AltaCliente");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CheckearDNI(long dni)
        {
            bool band = false;
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@DNI", dni);
            HelperDB.ObtenerInstancia().LeerDB("SP_EXISTEDNICli");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            band = HelperDB.ObtenerInstancia().Dr.Read() ? true : false;
            HelperDB.ObtenerInstancia().close();
            return band;
        }

        public bool ModificacionCliente(Cliente c)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@DNINuevo", c.DNINuevo);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@DNI", c.DNI);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", c.Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@apellido", c.Apellido);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@telefono", c.Telefono);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@email", c.Email);
                HelperDB.ObtenerInstancia().updatear_db("SP_ModificarCliente");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Cliente> TrarClientes()
        {
            List<Cliente> lcliente = new List<Cliente>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_TraerClientes");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Cliente client = new Cliente();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    client.DNI = HelperDB.ObtenerInstancia().Dr.GetInt64(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    client.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    client.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    client.Telefono = HelperDB.ObtenerInstancia().Dr.GetInt64(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    client.Email = HelperDB.ObtenerInstancia().Dr.GetString(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    client.Debe = Math.Round(HelperDB.ObtenerInstancia().Dr.GetDecimal(5),2);
                }
                lcliente.Add(client);
            }
            HelperDB.ObtenerInstancia().close();
            return lcliente;
        }
    }
}
