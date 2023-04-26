using GestionVentasBackend.Dominio;
using GestionVentasFrontend.Formularios;
using GestionVentasNegocio.Implementacion;
using GestionVentasNegocio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVentasFrontend
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Activacion ac;
        public static Login lg;
        [STAThread]
        static void Main()
        {
            ing_Configuracion lc = new ng_Configuracion();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!lc.GetLicencia())
            {
                Application.Run(ac = new Activacion());

                if (ac.DialogResult == DialogResult.Yes)
                {
                    Application.Run(lg = new Login());
                }
            }
            else
            {
                Application.Run(lg = new Login());

            }
        }
    }
}
