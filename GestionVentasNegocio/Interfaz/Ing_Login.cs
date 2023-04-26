using GestionVentasBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasNegocio.Interfaz
{
    public interface Ing_Login
    {
        bool Logeado(Usuario u, string alias, string contraseña);

        bool CheckLogin(string alias, string contraseña);
    }
}
