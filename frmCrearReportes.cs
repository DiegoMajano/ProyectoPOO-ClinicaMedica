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
            gbSignosVitales.Enabled = false;
            gbDReporte.Enabled = false;
            gbMedicamento.Enabled = false;
        }
        public void LimpiarCampos()
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
            mtxtPeso.Clear();
            mtxtEstatura.Clear();
            mtxtFrecCar.Clear();
            mtxtTemp.Clear();
            mtxtPresionArt.Clear();
            txtMotivo.Clear();
            txtDiagnostico.Clear();
            txtIndicaciones.Clear();           
            for (int i = 0; i < clbMedicamentos.Items.Count; i++)
            {
                clbMedicamentos.SetItemChecked(i, false);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            gbDReporte.Enabled = true;
            gbMedicamento.Enabled = true;
            gbSignosVitales.Enabled = true;
        }
    }
}
