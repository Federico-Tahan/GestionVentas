using GestionVentasBackend.Dominio;
using GestionVentasNegocio.Implementacion;
using GestionVentasNegocio.Interfaz;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVentasFrontend.Formularios
{
    public partial class CrudProductos : Form
    {
        In_Cbos lc;
        In_CrudProductos lg;
        Producto productoSelected = new Producto();
        Producto Producto;
        List<Producto> lproductos = new List<Producto>();

        public CrudProductos()
        {
            InitializeComponent();
            lc = new Inmp_Cbo();
            lg = new Inmp_CrudProductos();
            
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            pnlForm.Visible= !pnlForm.Visible;
            HabilitarBtn(false);
            HabilitarCampos(true);
            BtnCancelar.Enabled = true; BtnGuardar.Enabled = true;
            chkActivo.Visible = false;
            Limpiar();
        }

        private void CrudProductos_Load(object sender, EventArgs e)
        {
            cargar_cbo(cboMarca, "Nombre", "id_Marca", lc.ObtenerMarcas(1));
            cargar_cbo(cborubro, "Nombre", "id_rubro", lc.ObtenerRubros(1));
            cargar_cbo(cboMarcafil, "Nombre", "id_Marca", lc.ObtenerMarcas(0));
            cboMarcafil.SelectedIndex = 0;
            cargar_cbo(cboRubrofil, "Nombre", "id_rubro", lc.ObtenerRubros(0));
            cboRubrofil.SelectedIndex = 0;
            cargar_cbo(CboUnidadMed, "Nombre", "Id_UnidadMedida", lc.ObtenerUnidadMedida(1));
            lproductos = lg.ObtenerProductos(0);
            cargarDgv(lproductos);

        }

        private void HabilitarBtn(bool a)
        {
            BtnNuevo.Enabled = a;
            BtnEditar.Enabled = a;
            BtnCancelar.Enabled = a;
            BtnGuardar.Enabled = a;
        }

        private void HabilitarCampos(bool a)
        {
            txbNombre.Enabled = a;
            txbDescripcion.Enabled = a;
            cboMarca.Enabled = a;
            cborubro.Enabled = a;
            CboUnidadMed.Enabled = a;
            nupStock.Enabled = a;
            nupStockMin.Enabled = a;
            nupPrecio.Enabled = a;
            chkActivo.Enabled = a;
            nupDescuento.Enabled = a;
            picLimpiar.Enabled = a;
        }

        private void Limpiar()
        {
            txbNombre.Text = string.Empty;
            txbDescripcion.Text = string.Empty;
            cboMarca.SelectedIndex = -1;
            cborubro.SelectedIndex = -1;
            CboUnidadMed.SelectedIndex = -1;
            nupStock.Value = 0;
            nupStockMin.Value = 0;
            nupPrecio.Value = 0;
            chkActivo.Checked = true;
            nupDescuento.Value = 0;
        }

        private void PicBajar_Click(object sender, EventArgs e)
        {
            pnlForm.Visible = !pnlForm.Visible;
            productoSelected = new Producto();
            HabilitarBtn(false);
            Limpiar();
            BtnNuevo.Enabled = true;
        }

        private void cargar_cbo<T>(ComboBox cbo, string display, string value, List<T> lista)
        {
            cbo.DataSource = lista;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }


        private void CargarProductoSelected(int id)
        {
            productoSelected = new Producto();
            foreach (Producto u in lproductos)
            {
                if (u.Id_Producto == id)
                {
                    productoSelected = u;
                    break;
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!chkActivo.Checked)
            {
                if(MessageBox.Show("Esta por guardar un producto como inactivo, Desea continuar?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CargarBD();
                    rbtactivo.Checked = true;
                    cboRubrofil.SelectedIndex = 0;
                    cboMarcafil.SelectedIndex = 0;
                }

            }
            else
            {
                if (MessageBox.Show("Desea guardar el producto?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CargarBD();
                    rbtactivo.Checked = true;
                    cboRubrofil.SelectedIndex = 0;
                    cboMarcafil.SelectedIndex = 0;
                }

            }
        }

        private void AbstraerProducto()
        {
            Producto = new Producto();
            Marca marca = new Marca();
            Rubro r = new Rubro();
            UnidadMedida um = new UnidadMedida();
            Producto.Nombre = txbNombre.Text;
            Producto.Descripcion = txbDescripcion.Text;
            Producto.Stock = Math.Round(Convert.ToDecimal(nupStock.Value),2);
            Producto.Stock_Minimo = Math.Round(Convert.ToDecimal(nupStockMin.Value),2);
            Producto.Precio = Math.Round(Convert.ToDecimal(nupPrecio.Value));
            Producto.Descuento = Convert.ToInt32(nupDescuento.Value);
            um.Id_UnidadMedida = Convert.ToInt32(CboUnidadMed.SelectedValue);
            r.id_rubro = Convert.ToInt32(cborubro.SelectedValue);
            marca.id_Marca = Convert.ToInt32(cboMarca.SelectedValue);
            if (chkActivo.Checked)
            {
                Producto.BajaLogica = 0;

            }
            else
            {
                Producto.BajaLogica = 1;

            }
            Producto.marca = marca;
            Producto.unidadMedida = um;
            Producto.rubro = r;

        }


        private void CargarBD()
        {

            if (Validacion())
            {
                AbstraerProducto();
                if (productoSelected.Id_Producto != 0)
                {
                    Producto.Id_Producto = productoSelected.Id_Producto;

                    if (lg.ModificacionProducto(Producto))
                    {
                        MessageBox.Show("Producto Modificado con exito");
                        Producto = new Producto();
                        productoSelected = new Producto();
                        pnlForm.Visible = false;
                        Limpiar();
                        HabilitarBtn(false);
                        BtnNuevo.Enabled = true;
                        lproductos = lg.ObtenerProductos(0);
                        cargarDgv(lproductos);

                    }
                }
                else
                {
                    if (lg.AltaProducto(Producto))
                    {
                        MessageBox.Show("Producto dado de alta con exito");
                        Producto = new Producto();
                        pnlForm.Visible = false;
                        Limpiar();
                        HabilitarBtn(false);
                        BtnNuevo.Enabled = true;
                        lproductos = lg.ObtenerProductos(0);
                        cargarDgv(lproductos);
                    }
                }

            }

        }

        private bool Validacion()
        {
            if (txbNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe cargar el nombre del producto","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if (cborubro.SelectedIndex == -1)
            {
                MessageBox.Show("Debe cargar el Rubro del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe cargar la Marca del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CboUnidadMed.SelectedIndex == -1)
            {
                MessageBox.Show("Debe cargar la unidad de Medida del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nupPrecio.Value == 0)
            {
                MessageBox.Show("Debe cargar el Precio del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nupStock.Value == 0)
            {
                MessageBox.Show("Debe cargar el Stock Total del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nupStockMin.Value == 0)
            {
                MessageBox.Show("Debe cargar el Stock Minimo del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void cargarDgv(List<Producto> lp)
        {
            DgvProductos.Rows.Clear();

            foreach (Producto p in lp)
            {
                string baj = "No";
                if (p.BajaLogica == 0)
                {
                    baj = "Sí";
                }
                DgvProductos.Rows.Add(p.Id_Producto,p.Nombre,p.Descripcion,p.rubro.Nombre,p.marca.Nombre,p.unidadMedida.Nombre,Math.Round(p.Stock,p.unidadMedida.CantidadDecimal),"% "+p.Descuento,"$ "+ Math.Round(p.Precio,2),baj);

            }
        }

        private void DgvProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvProductos.Columns[e.ColumnIndex].Name == "Accion" && DgvProductos.Rows.Count != 0)
            {
                productoSelected = new Producto();
                Marca m = new Marca();
                UnidadMedida um = new UnidadMedida();
                Rubro r = new Rubro();
                chkActivo.Visible = true;
                productoSelected.unidadMedida = um;
                productoSelected.marca = m;
                productoSelected.rubro = r;
                pnlForm.Visible = true;
                productoSelected.Id_Producto = Convert.ToInt32(DgvProductos.CurrentRow.Cells[0].Value);
                CargarProductoSelected(productoSelected.Id_Producto);
                CargarPanelProducto(productoSelected);
                HabilitarCampos(false);
                picLimpiar.Enabled = false;
                HabilitarBtn(false);
                BtnEditar.Enabled = true;


            }
        }

        private void CargarPanelProducto(Producto prodSelect)
        {
            txbNombre.Text = productoSelected.Nombre;
            txbDescripcion.Text = productoSelected.Descripcion;
            nupDescuento.Value = productoSelected.Descuento;
            nupPrecio.Value = productoSelected.Precio;
            nupStock.Value = productoSelected.Stock;
            nupStockMin.Value = productoSelected.Stock_Minimo;
            cboMarca.SelectedValue = productoSelected.marca.id_Marca;
            cborubro.SelectedValue = productoSelected.rubro.id_rubro;
            CboUnidadMed.SelectedValue = productoSelected.unidadMedida.Id_UnidadMedida;
            if (productoSelected.BajaLogica == 0)
            {
                chkActivo.Checked = true;
            }
            else
            {
                chkActivo.Checked = false;

            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            HabilitarBtn(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

        }

        private void picLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            pnlForm.Visible = !pnlForm.Visible;
            productoSelected = new Producto();
            HabilitarBtn(false);
            Limpiar();
            BtnNuevo.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lproductos = lg.ObtenerProductos(0);
            cargarDgv(lproductos);
            cboRubrofil.SelectedIndex = 0;
            cboMarcafil.SelectedIndex = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lproductos = lg.ObtenerProductos(1);
            cargarDgv(lproductos);
            cboRubrofil.SelectedIndex = 0;
            cboMarcafil.SelectedIndex = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lproductos = lg.ObtenerProductos(2);
            cargarDgv(lproductos);
            cboRubrofil.SelectedIndex = 0;
            cboMarcafil.SelectedIndex = 0;
        }

        private void CboUnidadMed_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UnidadMedida Seleccionada = new UnidadMedida();
            Seleccionada = (UnidadMedida)CboUnidadMed.SelectedItem;
            nupStock.DecimalPlaces = Seleccionada.CantidadDecimal;
            nupStockMin.DecimalPlaces = Seleccionada.CantidadDecimal;

        }

        private void CboUnidadMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboUnidadMed.SelectedIndex != -1)
            {
                UnidadMedida Seleccionada = new UnidadMedida();
                Seleccionada = (UnidadMedida)CboUnidadMed.SelectedItem;
                nupStock.DecimalPlaces = Seleccionada.CantidadDecimal;
                nupStockMin.DecimalPlaces = Seleccionada.CantidadDecimal;
            }
            else
            {
                nupStock.DecimalPlaces = 0;
                nupStockMin.DecimalPlaces = 0;
            }
        }

        private void cboRubrofil_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboRubrofil.SelectedIndex != 0)
            {
                cboMarcafil.SelectedIndex = 0;
                List<Producto> listaFiltrada = lproductos.Where(p => p.rubro.Nombre == cboRubrofil.Text).ToList();
                cargarDgv(listaFiltrada);
            }
            else
            {
                cboMarcafil.SelectedIndex = 0;
                lproductos = lg.ObtenerProductos(0);
                cargarDgv(lproductos);
            }

        }

        private void cboMarcafil_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboMarcafil.SelectedIndex != 0)
            {


                if (cboRubrofil.SelectedIndex != 0)
                {
                    List<Producto> listaFiltrada = lproductos.Where(p => p.rubro.Nombre == cboRubrofil.Text && p.marca.Nombre == cboMarcafil.Text).ToList();
                    cargarDgv(listaFiltrada);
                }
                else
                {
                    List<Producto> listaFiltrada = lproductos.Where(p => p.marca.Nombre == cboMarcafil.Text).ToList();
                    cargarDgv(listaFiltrada);

                }

            }
            else
            {
                if (cboRubrofil.SelectedIndex != 0)
                {
                    List<Producto> listaFiltrada = lproductos.Where(p => p.rubro.Nombre == cboRubrofil.Text).ToList();
                    cargarDgv(listaFiltrada);
                }
                else
                {
                    cargarDgv(lproductos);
                }
            }
        }

        private void TxbNombreFil_TextChanged(object sender, EventArgs e)
        {
            if (cboRubrofil.SelectedIndex != 0 && cboMarcafil.SelectedIndex != 0)
            {
                List<Producto> listaFiltrada = lproductos.Where(p => p.rubro.Nombre == cboRubrofil.Text && p.marca.Nombre == cboMarcafil.Text && p.Nombre.ToLower().Contains(TxbNombreFil.Text.ToLower())).ToList();
                cargarDgv(listaFiltrada);
            }
            else if (cboRubrofil.SelectedIndex != 0 && cboMarcafil.SelectedIndex == 0)
            {
                List<Producto> listaFiltrada = lproductos.Where(p => p.rubro.Nombre == cboRubrofil.Text && p.Nombre.ToLower().Contains(TxbNombreFil.Text.ToLower())).ToList();
                cargarDgv(listaFiltrada);
            }
            else if (cboRubrofil.SelectedIndex == 0 && cboMarcafil.SelectedIndex != 0)
            {
                List<Producto> listaFiltrada = lproductos.Where(p => p.marca.Nombre == cboMarcafil.Text && p.Nombre.ToLower().Contains(TxbNombreFil.Text.ToLower())).ToList();
                cargarDgv(listaFiltrada);
            }
            else if (cboRubrofil.SelectedIndex == 0 && cboMarcafil.SelectedIndex == 0)
            {
                List<Producto> listaFiltrada = lproductos.Where(p => p.Nombre.ToLower().Contains(TxbNombreFil.Text.ToLower())).ToList();
                cargarDgv(listaFiltrada);

            } 
        }

        private void DgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                // Establecer el color de fondo en LightGray para filas pares
                e.CellStyle.BackColor = ColorTranslator.FromHtml("#d2eaf1");
            }
            else
            {
                // Establecer el color de fondo en White para filas impares
                e.CellStyle.BackColor = ColorTranslator.FromHtml("#e2f0fb");
            }
        }
    }
}
