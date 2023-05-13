using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GestionVentasBackend.Datos.Implementacion
{
    public class Im_Configuracion:IConfiguracion
    {
        Encriptacion en = new Encriptacion();
        public SqlConnection Conexion()
        {
            return HelperDB.ObtenerInstancia().conexion();
        }

        public bool GetLicencia()
        {
            bool band = false;
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_EXISTELicencia");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            if (HelperDB.ObtenerInstancia().Dr.Read()) 
            {
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    if (en.Desencriptar(HelperDB.ObtenerInstancia().Dr.GetString(0)) == GetMacAddress() + "CODEFLOWSYSTEM")
                    {

                        band = true;

                    }
                    else
                    {
                        band = false;
                    }
                }
                else
                {
                    band = false;

                }


            }
            HelperDB.ObtenerInstancia().close();
            return band;
        }

        public string GetMacAddress()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();

            string macAddress = string.Empty;

            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"] == true)
                {
                    macAddress = mo["MacAddress"].ToString();
                    break;
                }
            }

            return macAddress.Replace(":", "");
        }

        public List<Tema> GetTemas()
        {
            List<Tema> td = new List<Tema>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_Tema");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Tema rl = new Tema();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.id_tema = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }

                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }
    

        public bool InsertInfoEmpresa(string Nombre, string Direccion, string Cuit, byte[] imagen)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@CUIT", Cuit);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@direccion", Direccion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@imagen", imagen);
                HelperDB.ObtenerInstancia().updatear_db("SP_InfoEmpresa");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool InsertLicencia(string key)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@key", key);
                HelperDB.ObtenerInstancia().updatear_db("SP_InsertarKey");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Config TraerConfig()
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_TraerConfig");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            Config rl = new Config();
            Tema t = new Tema();
            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.CUIT = HelperDB.ObtenerInstancia().Dr.GetString(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.Imagen = (byte[])HelperDB.ObtenerInstancia().Dr.GetValue(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    rl.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    rl.Direccion = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    t.id_tema = HelperDB.ObtenerInstancia().Dr.GetInt32(5);
                }
            }
        
            HelperDB.ObtenerInstancia().close();
            rl.t = t;
            return rl;
        }

        public bool UpdateTema(int i)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id", i);
                HelperDB.ObtenerInstancia().updatear_db("SP_Insert_Tema");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
