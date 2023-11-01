using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicaMedica
{
    public partial class frmCrearReportes : ClinicaMedica.frmBase
    {
        public frmCrearReportes()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            cbPacBusqueda.Items.Clear();
            txtCodPaciente.Clear();
            txtCodExp.Clear();
            txtP_Nombre.Clear();
            txtApellidos.Clear();
            txtEdad.Clear();
            txtGenero.Clear();
            txtCodCita.Clear();
            txtFechaCita.Clear();
            txtPeso.Clear();
            txtEstatura.Clear();
            txtFrecCar.Clear();
            txtTemp.Clear();
            txtPresionArt.Clear();
            txtMotivo.Clear();
            txtDiagnostico.Clear();
            txtIndicaciones.Clear();
            cbMedicamentos.Items.Clear();

        }
        private void lblPeso_Click(object sender, EventArgs e)
        {

        }

        private void lblEstatura_Click(object sender, EventArgs e)
        {

        }

        private void lblFrecCard_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbSignosVitales_Enter(object sender, EventArgs e)
        {

        }

        private void pnContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
