using GestionVentasBackend.Dominio;
using GestionVentasNegocio.Implementacion;
using GestionVentasNegocio.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVentasFrontend.Formularios.Venta
{
    public partial class ConfirmarVenta : Form
    {
        In_Cbos lc;
        In_Factura lf;

        Factura fac = new Factura();
        Cliente cli = new Cliente();
        Usuario u = new Usuario();
        FormaPago fp = new FormaPago();
        public ConfirmarVenta(Factura f)
        {
            InitializeComponent();
            fac = f;
            lc = new Inmp_Cbo();
            lf = new Inmp_Factura();


        }

        private void ConfirmarVenta_Load(object sender, EventArgs e)
        {
            cargar_cbo(cborFormaPago, "Formapago", "id_formapago", lc.ObtenerFormaPago(0));
            txbtotal.Text = fac.Calcular_Total().ToString();

        }

        private void cargar_cbo<T>(ComboBox cbo, string display, string value, List<T> lista)
        {
            cbo.DataSource = lista;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle= ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }

        private void chkFiado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiado.Checked)
            {
                BtnBuscarCliente.Visible = true;
                txbCliente.Visible = true;
                cborFormaPago.SelectedValue =1;
            }
            else
            {
                BtnBuscarCliente.Visible = false;
                txbCliente.Visible = false;
                cborFormaPago.SelectedIndex = - 1;
            }
        }

        private void cborFormaPago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((int)cborFormaPago.SelectedValue == 1)
            {
                BtnBuscarCliente.Visible = true;
                txbCliente.Visible = true;
            }
            else
            {
                BtnBuscarCliente.Visible = false;
                txbCliente.Visible = false;
            }
        }

        private void cborFormaPago_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void txtAbona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // Permitir solo una coma
            if (e.KeyChar == ',' && txtAbona.Text.Contains(','))
            {
                e.Handled = true;
            }
        }

        private void txtAbona_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAbona.Text, out decimal compra))
            {
                decimal pago = Math.Round(Convert.ToDecimal(txbtotal.Text),2);
                 decimal vuelto = Math.Round(compra - pago,2);
                txtVuelto.Text = vuelto.ToString();
            }
            else
            {
                txtVuelto.Text = "-" + txbtotal.Text;
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (cborFormaPago.SelectedIndex != -1)
            {


                if ((int)cborFormaPago.SelectedValue == 1)
                {



                }
                else
                {
                    if (txtAbona.Text != string.Empty && Convert.ToDecimal(txtVuelto.Text) >= 0)
                    {


                        abstraerFactura();


                        if (lf.AltaFactura(fac))
                        {
                            MessageBox.Show("Factura dada de alta con Exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult= DialogResult.OK;
                            this. Close();
                        }



                    }
                    else
                    {
                        MessageBox.Show("El valor que abona el Cliente es insuficiente para cubrir la Venta","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }


                }



















            }
        }

        private void abstraerFactura()
        {
            u = new Usuario();
            fp = new FormaPago();
            cli = new Cliente();
            fac.user = u;
            fac.fp = fp;
            fac.c = cli;
            fac.fp.id_formapago = (int)cborFormaPago.SelectedValue;
            fac.c.Apellido = txbApellido.Text;
            fac.c.Nombre = txbNombre.Text;
            fac.monto_pagado = Math.Round(Convert.ToDecimal(txtAbona.Text),2);
        }
    }
}
