using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicaMedica
{
    public partial class frmConsultarPersonal : ClinicaMedica.frmBase
    {
        public frmConsultarPersonal()
        {
            InitializeComponent();
        }
        public void LimpiarCampos()
        {
            //cbNombre.SelectedIndex = 0;
            //cbPuesto.SelectedIndex = 0;
            mtxtCodigo.Clear();
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
