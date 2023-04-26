using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasBackend.Datos.Interfaz
{
    public interface IConfiguracion
    {
        SqlConnection Conexion();

        bool GetLicencia();
        bool InsertLicencia(string key);

        bool InsertInfoEmpresa(string Nombre, string Direccion, string Cuit, byte[] imagen);

        Config TraerConfig();

    }
}
