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

        public void LimpiarCampos()
        {
            //cbBuscar.SelectedIndex = 0;
            mtxtCodPaci.Clear();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
