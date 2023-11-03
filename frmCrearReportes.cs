using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicaMedica.Modelo;
using System.Linq;

namespace ClinicaMedica
{
    public partial class frmCrearReportes : ClinicaMedica.frmBase
    {
        Paciente p = new Paciente();
        private List<Paciente> pacientes = new List<Paciente>();

        Prueba_1Entities1 db = FormFactory.CrearEntidadDB();
        public frmCrearReportes()
        {
            InitializeComponent();
        }

        private void frmCrearReportes_Load(object sender, EventArgs e)
        {
            Utilidades.LlenarCBPacientes(cbPacBusqueda);
            DeshabilidarGroupBox();
        }
        
        private void DeshabilidarGroupBox()
        {
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

        private void LlenarDatosPaciente()
        {
            string nombrePaciente = cbPacBusqueda.Text;
            string codigoPaciente = Utilidades.ObtenerCodigoPaciente(nombrePaciente);
            var nombre = from paciente in db.pacientes
                         where (paciente.primerNombre + " " + paciente.segundoNombre + " " + paciente.primerApellido + " " + paciente.segundoApellido).Equals(nombrePaciente)
                         select paciente;

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            LlenarDatosPaciente();

            gbDReporte.Enabled = true;
            gbMedicamento.Enabled = true;
            gbSignosVitales.Enabled = true;
            mtxtPeso.Focus();
        }

        private void cbPacBusqueda_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
