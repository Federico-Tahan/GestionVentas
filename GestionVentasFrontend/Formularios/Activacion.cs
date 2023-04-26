using GestionVentasBackend.Dominio;
using GestionVentasNegocio.Implementacion;
using GestionVentasNegocio.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVentasFrontend.Formularios
{
    public partial class Activacion : Form
    {
        Encriptacion en = new Encriptacion();
        ing_Configuracion lc = new ng_Configuracion();

        public Activacion()
        {
            InitializeComponent();
        }

        private void btnkey_Click(object sender, EventArgs e)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(rutaEscritorio, "key.txt");

            using (StreamWriter archivoTexto = new StreamWriter(rutaArchivo))
            {
                archivoTexto.WriteLine(en.Encriptar(GetMacAddress()));
            }
        }

        static string GetMacAddress()
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


        private bool VerficacionSerial(string a)
        {
            if (en.Desencriptar(a) == GetMacAddress() + "CODEFLOWSYSTEM")
            {

                return true;

            }
            else
            {
                return false;
            }
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            if (VerficacionSerial(textBox1.Text))
            {
                if (lc.InsertLicencia(textBox1.Text))
                {
                    MessageBox.Show("Licencia Activada con Exito.");
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("La licencia ingresada no es valida.");

            }
        }
    }
}
