using GestionVentasBackend.Dominio;
using GestionVentasBackend.Dominio.ClasesReportes;
using GestionVentasNegocio.Implementacion;
using GestionVentasNegocio.Interfaz;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVentasFrontend.Formularios.Reportes
{
    public partial class FormRecaudacionFP : Form
    {
        In_Cbos lc = new Inmp_Cbo();
        In_Reporte lg = new Inmp_Reporte();
        List<RecaudadoFP> list = new List<RecaudadoFP>();   
        List<FormaPago> lfp = new List<FormaPago>();
        FormaPago forma = new FormaPago();
        private void cargar_cbo<T>(ComboBox cbo, string display, string value, List<T> lista)
        {
            cbo.DataSource = lista;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }
        public FormRecaudacionFP()
        {
            InitializeComponent();
            forma.id_formapago = 0;
            forma.Formapago = "<<Todas las formas de pago>>";
            lfp = lc.ObtenerFormaPago(0);
            lfp.Insert(0,forma);
            cargar_cbo(cboFp, "Formapago", "id_formapago", lfp);
        }

        private void FormRecaudacionFP_Load(object sender, EventArgs e)
        {
            list = lg.Recaudacion(2, 0);
            if ((int)cboFp.SelectedValue == 0)
            {
                this.sPReporteRecaudacionBindingSource.DataSource = list;
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.sPReporteRecaudacionBindingSource.DataSource = list.Where(p => p.id_formaPago == (int)cboFp.SelectedValue);
                this.reportViewer1.RefreshReport();
            }
        }

        private void RbtAnual_CheckedChanged(object sender, EventArgs e)
        {
            list = lg.Recaudacion(3, 0);
            if ((int)cboFp.SelectedValue == 0)
            {
                this.sPReporteRecaudacionBindingSource.DataSource = list;
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.sPReporteRecaudacionBindingSource.DataSource = list.Where(p => p.id_formaPago == (int)cboFp.SelectedValue);
                this.reportViewer1.RefreshReport();
            }
        }

        private void RbtMensual_CheckedChanged(object sender, EventArgs e)
        {
            list = lg.Recaudacion(2, 0);
            if ((int)cboFp.SelectedValue == 0)
            {
                this.sPReporteRecaudacionBindingSource.DataSource = list;
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.sPReporteRecaudacionBindingSource.DataSource = list.Where(p => p.id_formaPago == (int)cboFp.SelectedValue);
                this.reportViewer1.RefreshReport();
            }
        }

        private void RbtDiario_CheckedChanged(object sender, EventArgs e)
        {
            list = lg.Recaudacion(1, 0);
            if ((int)cboFp.SelectedValue == 0)
            {
                this.sPReporteRecaudacionBindingSource.DataSource = list;
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.sPReporteRecaudacionBindingSource.DataSource = list.Where(p => p.id_formaPago == (int)cboFp.SelectedValue);
                this.reportViewer1.RefreshReport();
            }

        }

        private void cboFp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (RbtAnual.Checked)
            {
                list = lg.Recaudacion(3, 0);
                if ((int)cboFp.SelectedValue == 0)
                {
                    this.sPReporteRecaudacionBindingSource.DataSource = list;
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    this.sPReporteRecaudacionBindingSource.DataSource = list.Where(p => p.id_formaPago == (int)cboFp.SelectedValue);
                    this.reportViewer1.RefreshReport();
                }
                
            }else if (RbtMensual.Checked)
            {
                list = lg.Recaudacion(2, 0);
                if ((int)cboFp.SelectedValue == 0)
                {
                    this.sPReporteRecaudacionBindingSource.DataSource = list;
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    this.sPReporteRecaudacionBindingSource.DataSource = list.Where(p => p.id_formaPago == (int)cboFp.SelectedValue);
                    this.reportViewer1.RefreshReport();
                }
            }
            else
            {
                list = lg.Recaudacion(1, 0);
                if ((int)cboFp.SelectedValue == 0)
                {
                    this.sPReporteRecaudacionBindingSource.DataSource = list;
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    this.sPReporteRecaudacionBindingSource.DataSource = list.Where(p => p.id_formaPago == (int)cboFp.SelectedValue);
                    this.reportViewer1.RefreshReport();
                }
            }
        }
    }
}
