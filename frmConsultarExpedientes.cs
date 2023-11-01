using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicaMedica
{
    public partial class frmConsultarExpedientes : ClinicaMedica.frmBase
    {
        public frmConsultarExpedientes()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtBusqueda.Clear();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
