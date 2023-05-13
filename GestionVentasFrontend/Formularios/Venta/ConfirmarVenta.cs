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
        In_CrudCliente cl;
        
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
            cl = new Inmp_CrudCliente();
            SeleccionarColor();

        }

        private void ConfirmarVenta_Load(object sender, EventArgs e)
        {
            
            cargar_cbo(cborFormaPago, "Formapago", "id_formapago", lc.ObtenerFormaPago(0));
            cborFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            txbtotal.Text = fac.Calcular_Total().ToString();
            txtVuelto.Text = "-" + fac.Calcular_Total();
            cargar_cbo(cboDNI, "DNI", "DNI", cl.TrarClientes());
            txbNombre.Text = string.Empty;
            txbApellido.Text= string.Empty;
        }

        private void cargar_cbo<T>(ComboBox cbo, string display, string value, List<T> lista)
        {
            cbo.DataSource = lista;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }


        private void cborFormaPago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((int)cborFormaPago.SelectedValue == 1)
            {
                cboDNI.Visible = true;
                lbdni.Visible = true;
                BtnAgregarCliente.Visible = true;
            }
            else
            {
                cboDNI.Visible = false;
                lbdni.Visible = false;
                BtnAgregarCliente.Visible = false;

            }
        }
        ing_Configuracion lv = new ng_Configuracion();

        private void SeleccionarColor()
        {
            Config c = new Config();
            c = lv.TraerConfig();
            int tema = c.t.id_tema;
            string color = "#513b56";
            string color2 = "#45364b";

            if (tema == 1)
            {
                color = "#513b56";
                color2 = "#45364b";

            }
            else if (tema == 2)
            {
                color = "#469d89";

            }
            else if (tema == 3)
            {
                color = "#adb5bd";

            }
            else if (tema == 4)
            {
                color = "#212529";

            }

            this.BackColor = ColorTranslator.FromHtml(color);

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
                                                                                        

                if ((int)cborFormaPago.SelectedValue != 1 && Math.Round(Convert.ToDecimal(txtAbona.Text), 2)  -  Math.Round(Convert.ToDecimal(txbtotal.Text),2) <0)
                {
                    MessageBox.Show("El monto ingresado no es suficiente para cubrir la venta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                if ((int)cborFormaPago.SelectedValue == 1 && cboDNI.SelectedIndex == -1)
                {
                    MessageBox.Show("Para vender al fiado es necesario que ingrese la cuenta de un Cliente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtAbona.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el valor que abona el cliente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Desea Generar la venta?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                abstraerFactura();

                if ((int)cborFormaPago.SelectedValue == 1 && cboDNI.SelectedIndex != -1)
                {
                    fac.c = (Cliente)cboDNI.SelectedItem;
                }

                if (fac.id_factura != 0)
                {
                    if (lf.ModificarFactura(fac))
                    {
                        MessageBox.Show("Factura Modoficada con Exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    if (lf.AltaFactura(fac))
                    {
                        MessageBox.Show("Factura dada de alta con Exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Debe cargar la forma de pago.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void abstraerFactura()
        {
            u = new Usuario();
            fp = new FormaPago();
            cli = new Cliente();
            u.Id_Usuario = Login.usuario.Id_Usuario;
            fac.user = u;
            fac.fp = fp;
            fac.c = cli;
            fac.fp.id_formapago = (int)cborFormaPago.SelectedValue;
            fac.c.Apellido = txbApellido.Text;
            fac.c.Nombre = txbNombre.Text;
            fac.monto_pagado = Math.Round(Convert.ToDecimal(txtAbona.Text),2);
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void cboDNI_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboDNI.SelectedIndex != -1)
            {
                cli = (Cliente)cboDNI.SelectedItem;
                txbNombre.Text = cli.Nombre;
                txbApellido.Text = cli.Apellido;

            }
        }

        private void cboDNI_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboDNI.SelectedIndex != -1)
            {
                cli = (Cliente)cboDNI.SelectedItem;
                txbNombre.Text = cli.Nombre;
                txbApellido.Text = cli.Apellido;

            }
        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            CrudCliente  c = new CrudCliente();
            c.FormBorderStyle = FormBorderStyle.FixedSingle;
            c.StartPosition = FormStartPosition.CenterScreen;
            c.ShowDialog();

            cargar_cbo(cboDNI, "DNI", "DNI", cl.TrarClientes());

        }
    }
}
