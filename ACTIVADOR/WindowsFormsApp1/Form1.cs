using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net.NetworkInformation;
using System.IO;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Encriptacion en = new Encriptacion();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Generar una clave de activación única basada en la dirección MAC

            // Mostrar la clave de activación para el usuario


            if (VerficacionSerial(textBox1.Text))
            {
                MessageBox.Show("Si");
            }
            else
            {
                MessageBox.Show("NO");

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
            if (en.Desencriptar(a) == GetMacAddress()+ "CODEFLOWSYSTEM")
            {
                
                return true;

            }
            else
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(rutaEscritorio, "DireccionMAC.txt");

            using (StreamWriter archivoTexto = new StreamWriter(rutaArchivo))
            {
                archivoTexto.WriteLine(en.Encriptar(GetMacAddress()));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(rutaEscritorio, "Crack.txt");

            using (StreamWriter archivoTexto = new StreamWriter(rutaArchivo))
            {
                string desencripted = en.Desencriptar(textBox2.Text);
                archivoTexto.WriteLine(en.Encriptar(desencripted + "CODEFLOWSYSTEM"));

            }
        }
    }
}
