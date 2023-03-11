using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVentasFrontend.Formularios
{
    public partial class CrudUsuario : Form
    {
        int modo = 0;
        public CrudUsuario(int tipo)
        {
            InitializeComponent();
            modo = tipo;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            pnlForm.Visible = true;
        }

        private void CrudUsuario_Load(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                this.FormBorderStyle= FormBorderStyle.None;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;

            }
        }
    }
}
