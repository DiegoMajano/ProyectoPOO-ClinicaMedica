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
        public void limpiar()
        {
            txtBusqueda.Clear();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            limpiar(); //no se si es par borrar una consulta buscada pero no creo jajaj
        }
    }
}
