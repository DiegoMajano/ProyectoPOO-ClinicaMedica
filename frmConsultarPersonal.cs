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
    public partial class frmConsultarPersonal : ClinicaMedica.frmBase
    {
        Prueba_1Entities1 db = FormFactory.CrearEntidadDB();
        private bool filtroNombre;
        private bool filtroCodigo;
        private bool filtroEspecialidad;
        public frmConsultarPersonal()
        {
            InitializeComponent();
        }
        private void frmConsultarPersonal_Load(object sender, EventArgs e)
        {
            LlenarCB();
            LimpiarCampos();
            dgvConsultarMedicos.DataSource = null;
        }

        private void LlenarCB()
        {
            Utilidades.LlenarCBMedicos(cbNombreMedico);
            Utilidades.LlenarCBEspecialidades(cbEspecialidades);
        }
        public void LimpiarCampos()
        {
            cbNombreMedico.SelectedIndex = 0;
            mtxtCodigo.Clear();
            filtroNombre = false;
            filtroCodigo = false;
            filtroEspecialidad = false;
        }

        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNombreMedico.SelectedIndex != 0)
            {
                filtroNombre = true;
            }
        }
        private void mtxtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (mtxtCodigo.Text !="    -")
            {
                filtroCodigo = true;
            }
        }
        private void cbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEspecialidades.SelectedIndex!=0)
            {
                filtroEspecialidad = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busquedaCodigo = mtxtCodigo.Text;
            string nombreMedico = cbNombreMedico.Text;
            string especialidadMedico = cbEspecialidades.Text;

            var busqueda = from medico in db.medicos
                           where (!filtroCodigo || medico.codMedico.Equals(busquedaCodigo)) &&
                                  (!filtroNombre || medico.primerNombre + " " + medico.primerApellido == nombreMedico) &&
                                  (!filtroEspecialidad || medico.especialidad == especialidadMedico)
                           select new
                           {
                               Codigo = medico.codMedico,
                               Nombre = medico.primerNombre + " " + medico.primerApellido,
                               Telefono = medico.telefono,
                               Especialidad = medico.especialidad
                           };            
            dgvConsultarMedicos.DataSource = busqueda.ToList();
            dgvConsultarMedicos.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvConsultarMedicos.ClearSelection();
            LimpiarCampos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvConsultarMedicos.DataSource = null;
        }

        private void dgvConsultarMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
