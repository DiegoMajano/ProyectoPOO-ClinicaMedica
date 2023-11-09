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
    public partial class frmConsultarExpedientes : ClinicaMedica.frmBase
    {
        ClinicaEntities db = FormFactory.CrearEntidadDB();
        private bool filtroNombre=false;
        private bool filtroCodigo=false;
        public frmConsultarExpedientes()
        {
            InitializeComponent();
        }

        private void frmConsultarExpedientes_Load(object sender, EventArgs e)
        {
            Utilidades.LlenarCBPacientes(cbNombrePaciente);
            LimpiarCampos();
            dgvConsultarExpediente.DataSource = null;
        }

        public void Refrescar()
        {                       
            var lista = from datos in db.pacientes
                select datos;                    
            dgvConsultarExpediente.DataSource = lista.ToList();   
        }

        public void LimpiarCampos()
        {
            cbNombrePaciente.SelectedIndex = 0;
            mtxtCodPaci.Clear();
            filtroCodigo = false; 
            filtroNombre = false;
        }

        // --- Validaciones
        private void cbNombrePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Busqueda()
        {
            string busquedaNombre = cbNombrePaciente.Text;
            string busquedaCodigo = mtxtCodPaci.Text;

            var busqueda = from pacientes in db.pacientes
                           where (!filtroCodigo || pacientes.codPaciente == busquedaCodigo) &&
                                 (!filtroNombre || pacientes.primerNombre + " " + pacientes.segundoNombre + " " + pacientes.primerApellido + " " + pacientes.segundoApellido == busquedaNombre)
                           select new
                           {
                               codPaciente = pacientes.codPaciente,
                               Nombre = pacientes.primerNombre + " " + pacientes.segundoNombre + " " + pacientes.primerApellido + " " + pacientes.segundoApellido,
                               Dirección = pacientes.direccion,
                               Teléfono = pacientes.telefono,
                               Género = pacientes.sexo,
                               FechaNacimiento = pacientes.fechaNacimiento,
                               Edad = pacientes.edad,
                               DUI = pacientes.dui,
                               NIT = pacientes.nit
                           };
        
            dgvConsultarExpediente.DataSource = busqueda.ToList();
            dgvConsultarExpediente.Columns["codPaciente"].HeaderText = "Código Paciente";
            dgvConsultarExpediente.Columns["FechaNacimiento"].HeaderText = "Fecha Nacimiento";
            dgvConsultarExpediente.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvConsultarExpediente.ClearSelection();
        }
        private void cbNombrePaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNombrePaciente.SelectedIndex != 0)
            {
                filtroNombre = true;
            }
        }

        private void mtxtCodPaci_TextChanged(object sender, EventArgs e)
        {
            filtroCodigo = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Busqueda();
            LimpiarCampos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvConsultarExpediente.DataSource = null;
        }

        private void dgvConsultarExpediente_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Context.ToString(), "Error");
        }

        private void btnVerReportes_Click(object sender, EventArgs e)
        {

        }
    }
}
