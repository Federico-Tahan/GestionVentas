﻿using System;
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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            ConfirmarVenta cv = new ConfirmarVenta();
            cv.ShowDialog();
        }
    }
}