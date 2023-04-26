using GestionVentasBackend.Dominio;
using GestionVentasNegocio.Implementacion;
using GestionVentasNegocio.Interfaz;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVentasFrontend.Formularios
{
    public partial class Configuracion : Form
    {
        ing_Configuracion lg = new ng_Configuracion();

        public Configuracion()
        {
            InitializeComponent();
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            pnlBackup.Visible = true;
            pnlGeneral.Visible = false;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txbRespaldo.Text = fbd.SelectedPath;
                BtnRespaldo.Enabled = true;
                BtnRespaldo.Show();
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.bak";
            ofd.Title = "Database Restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRestauracion.Text = ofd.FileName;
                btnRestauracion.Show();
            }
        }

        private void BtnRespaldo_Click(object sender, EventArgs e)
        {
            lg.Conexion().Open();
            String database = lg.Conexion().Database.ToString();
            try
            {
                string q = "BACKUP DATABASE [" + database + "] TO DISK='" + txbRespaldo.Text + "\\" + "FlowSell" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                SqlCommand cmd = new SqlCommand(q, lg.Conexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("BackUp Realizado Con Exito.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnRespaldo.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lg.Conexion().Close();
            }
        }

        private void btnRestauracion_Click(object sender, EventArgs e)
        {
            lg.Conexion().Open();
            String database = lg.Conexion().Database.ToString();
            try
            {
                string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sql1, lg.Conexion());
                cmd1.ExecuteNonQuery();

                string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txtRestauracion.Text + "' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sql2, lg.Conexion());
                cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, lg.Conexion());
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Base de datos restaurada con exito.", "Restauracion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRestauracion.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lg.Conexion().Close();
            }
        }

        private void BtnGeneral_Click(object sender, EventArgs e)
        {
            pnlBackup.Visible = false;
            pnlGeneral.Visible = true;
        }

        private void BtnSubir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = Image.FromFile(@"" + openFileDialog1.FileName + "");
                picImage.SizeMode = PictureBoxSizeMode.Zoom;
                picImage.Tag = "SI";
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Config c = new Config();
            c.Nombre = txbNombre.Text;
            c.CUIT = txbCUIT.Text;
            c.Direccion = TxbDireccion.Text;
            if (picImage.Tag == "SI")
            {
                c.Imagen = Convertir_Imagen();
            }
            else
            {
                c.Imagen = new byte[0];

            }

            if (lg.InsertInfoEmpresa(c.Nombre,c.Direccion,c.CUIT,c.Imagen))
            {
                MessageBox.Show("Datos de la empresa actualizados con exito");
            }
            else
            {
                MessageBox.Show("Los Datos de la empresa no se pudieron actualizar.");

            }
        }
        private byte[] Convertir_Imagen()
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            picImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            picImage.Tag = "No";
            picImage.Image = Properties.Resources.placeholder;
        }


        private void TraerConfig()
        {
            Config config = lg.TraerConfig();

            txbCUIT.Text = config.CUIT;
            txbNombre.Text = config.Nombre;
            TxbDireccion.Text = config.Direccion;
            if (config.Imagen.Length == 0)
            {
                picImage.Image = Properties.Resources.placeholder;
            }
            else
            {
                MemoryStream ms = new MemoryStream(config.Imagen);
                picImage.Image = Image.FromStream(ms);
            }


        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            TraerConfig();
        }
    }
}
