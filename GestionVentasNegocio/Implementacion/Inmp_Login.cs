using GestionVentasBackend.Datos.Implementacion;
using GestionVentasBackend.Datos.Interfaz;
using GestionVentasBackend.Dominio;
using GestionVentasNegocio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasNegocio.Implementacion
{
    public class Inmp_Login:Ing_Login
    {
        ILogin lg;
        public Inmp_Login()
        {
            lg = new Imp_Login();
        }

        public bool CheckLogin(string alias, string contraseña)
        {
            return lg.CheckLogin(alias, contraseña);
        }

        public bool Logeado(Usuario u, string alias, string contraseña)
        {
            return lg.Logeado(u,alias,contraseña);
        }
    }
}
