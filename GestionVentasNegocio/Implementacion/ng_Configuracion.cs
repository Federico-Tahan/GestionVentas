using GestionVentasBackend.Datos.Implementacion;
using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Dominio;
using GestionVentasNegocio.Interfaz;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasNegocio.Implementacion
{
    public class ng_Configuracion : ing_Configuracion
    {
        private IConfiguracion lg;

        public ng_Configuracion()
        {
            lg = new Im_Configuracion();
        }
        public SqlConnection Conexion()
        {
            return lg.Conexion();
        }

        public bool GetLicencia()
        {
            return lg.GetLicencia();
        }

        public bool InsertInfoEmpresa(string Nombre, string Direccion, string Cuit, byte[] imagen)
        {
            return lg.InsertInfoEmpresa(Nombre,Direccion,Cuit,imagen);
        }

        public bool InsertLicencia(string key)
        {
            return lg.InsertLicencia(key);
        }

        public Config TraerConfig()
        {
           return lg.TraerConfig();
        }
    }
}
