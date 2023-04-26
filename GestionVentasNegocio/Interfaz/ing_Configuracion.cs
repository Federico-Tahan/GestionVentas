using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasNegocio.Interfaz
{
    public interface ing_Configuracion
    {
        SqlConnection Conexion();

        bool GetLicencia();
        bool InsertLicencia(string key);
        bool InsertInfoEmpresa(string Nombre, string Direccion, string Cuit, byte[] imagen);

        Config TraerConfig();
    }
}
