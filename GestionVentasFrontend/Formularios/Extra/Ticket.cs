using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionVentasBackend.Dominio;

namespace GestionVentasFrontend.Formularios.Extra
{
    public class PrintTicket
    {
        public Image Logo { get; set; }
        public string NombreNegocio { get; set; }
        public string CUIT { get; set; }
        public string Direccion { get; set; }
        public string Cajero { get; set; }
        public string SubTotal { get; set; }
        public string Descuento { get; set; }
        public string Total { get; set; }

        private PrintPreviewDialog vista = new PrintPreviewDialog();
        public List<DetalleFactura> products = new List<DetalleFactura>();
        int Y = 0;
        public void Print()
        {
            // Configurar la impresora
            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = pd.DefaultPageSettings.PrinterSettings.PrinterName;
            pd.DefaultPageSettings.PaperSize = new PaperSize("Ticket", (int)(88 / 25.4 * 100), CalcularTamaño() + 120);
            pd.PrintPage += new PrintPageEventHandler(PrintPage);
            vista.Document = pd;
            vista.Show();
            // Imprimir el ticket
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("True Type", 10);

            // Imprimir el encabezado del ticket
            graphics.DrawString(NombreNegocio, font, new SolidBrush(Color.Black), 0, Y);
            if (Logo != null)
            {
                e.Graphics.DrawImage(Logo, 305, Y, 36, 36);
                Y += 20;
            }
            else
            {
                Y += 20;
            }

            font.Dispose();
            font = new Font("True Type", 6);

            graphics.DrawString("CUIT:" + CUIT, font, new SolidBrush(Color.Black), 0, Y);
            Y += 20;
            graphics.DrawString("Dirección: "+Direccion, font, new SolidBrush(Color.Black), 0, Y);
            Y += 20;
            font.Dispose();
            font = new Font("True Type", 8);
            graphics.DrawString("Cajero:" + Cajero, font, new SolidBrush(Color.Black), 0, Y);
            Y += 20;
            graphics.DrawString("Fecha: " + DateTime.Now.ToShortDateString() + "           Hora:" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second, font, new SolidBrush(Color.Black), 0, Y);
            Y += 20;
            font.Dispose();
            font = new Font("True Type", 8, FontStyle.Bold);
            graphics.DrawString("*************************************************", font, new SolidBrush(Color.Black), 56, Y);
            Y += 10;
            graphics.DrawString("*      Documento NO valido como factura     *", font, new SolidBrush(Color.Black), 56, Y);
            Y += 14;
            graphics.DrawString("*************************************************", font, new SolidBrush(Color.Black), 56, Y);
            font.Dispose();
            font = new Font("True Type", 8);

            Y += 20;

            // Imprimir el detalle del producto
            graphics.DrawString("**************************************************************************************************************", font, new SolidBrush(Color.Black), 0, Y);
            Y += 14;

            graphics.DrawString("Cant.      Nombre                                      Precio                Total", font, new SolidBrush(Color.Black), 0, Y);
            Y += 14;
            graphics.DrawString("**************************************************************************************************************", font, new SolidBrush(Color.Black), 0, Y);
            Y += 20;

            for (int i = 0; i < products.Count; i++)
            {
                string cantidad = Convert.ToString(products[i].Cantidad);
                string nombre = Convert.ToString(products[i].prod.Nombre);
                if (Convert.ToString(cantidad).Length == 1)
                {
                    cantidad = "0" + cantidad;

                }
                graphics.DrawString(cantidad, font, new SolidBrush(Color.Black), 0, Y);

                if (nombre.Length > 26)
                {
                    string nombrec26prim;
                    string sub;
                    nombrec26prim = nombre.Substring(0, Math.Min(nombre.Length, 22));
                    sub = nombre.Substring(22, nombre.Length - 22);
                    graphics.DrawString(nombrec26prim, font, new SolidBrush(Color.Black), 44, Y);
                    Y += 20;
                    sub += "(%" + products[i].Descuento.ToString() + ")";
                    graphics.DrawString(sub, font, new SolidBrush(Color.Black), 44, Y);
                    Y -= 40;
                    Y += 20;
                    graphics.DrawString("$" + products[i].Precio, font, new SolidBrush(Color.Black), 200, Y);
                    graphics.DrawString("$" + (products[i].Precio * products[i].Cantidad -(((products[i].Precio * products[i].Cantidad)* products[i].Descuento)/100)), font, new SolidBrush(Color.Black), 270, Y);
                    Y += 20;



                }
                else
                {
                    nombre += "(%" + products[i].Descuento.ToString() + ")";
                    graphics.DrawString(nombre, font, new SolidBrush(Color.Black), 44, Y);
                    graphics.DrawString("$" + products[i].Precio, font, new SolidBrush(Color.Black), 200, Y);
                    graphics.DrawString("$" + (products[i].Precio * products[i].Cantidad - (((products[i].Precio * products[i].Cantidad) * products[i].Descuento) / 100)), font, new SolidBrush(Color.Black), 270, Y);
                }



                Y += 20;
            }
            Y += 20;

            graphics.DrawString("---------------------------------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), 0, Y);
            Y += 20;


            // Imprimir el total, descuento y total con descuento
            graphics.DrawString("SubTotal: $" + SubTotal, font, new SolidBrush(Color.Black), 0, Y);
            Y += 20;

            graphics.DrawString("Total: $" + Total, font, new SolidBrush(Color.Black), 0, Y);
            Y += 20;

            graphics.DrawString("Gracias por su Compra!", font, new SolidBrush(Color.Black), 100, Y);
        }
        private int CalcularTamaño()
        {
            int altura = 120; // Altura inicial del ticket

            for (int i = 0; i < products.Count; i++)
            {
                string nombre = products[i].prod.Nombre;
                if (nombre.Length > 26)
                {
                    altura += 40; // Si el nombre ocupa más de 26 caracteres, sumar 40 a la altura
                }
                else
                {
                    altura += 20; // Si el nombre ocupa 26 o menos caracteres, sumar 20 a la altura
                }
            }

            altura += 80; // Sumar 80 a la altura para tener en cuenta el espacio de los encabezados y el total

            return altura;
        }
    }
}
