using ClinicaMedica.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ClinicaMedica
{
    public partial class frmInicio : ClinicaMedica.frmBase
    {
        ClinicaEntities db = FormFactory.CrearEntidadDB();
        static string p;
        static string nombre;
        public frmInicio()
        {
            InitializeComponent();
        }
        public frmInicio(string puesto)
        {
            InitializeComponent();
            p = puesto;
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            switch (p)
            {
                case "A":
                    nombre = frmLoginAdmin.usuario_nombre;
                    lblNombre.Text = nombre;
                    lblPuestoUser.Text = "Administración";
                    lblPuestoUser.Visible = true;
                    lblNombreUser.Visible = false;
                    break;

                case "M":
                    nombre = frmLoginMedico.usuario_nombre;
                    lblNombreUser.Text = nombre;
                    lblPuestoUser.Text = "Médico";
                    lblPuestoUser.Visible = true;
                    lblNombreUser.Visible = true;
                    break;

                case "S":
                    lblNombreUser.Text = "soporte god";
                    lblPuestoUser.Text = "Soporte";
                    lblPuestoUser.Visible = true;
                    lblNombreUser.Visible = true;
                    break ;
            }         
        }

        public void Recordatorios()
        {            
            switch (p)
            {
                case "A":
                    RecordatorioAdmin(dgvCitasDia);
                    break;

                case "M":
                    RecordatorioMedico(dgvCitasDia, nombre);
                    break;
                case "S":
                    break;
            }            
        }

        private void RecordatorioAdmin(DataGridView dgv)
        {
            dgv.DataSource = null;
            
            var fechas = from citas in db.citasMedicas
                         join paciente in db.pacientes
                         on citas.codPaciente equals paciente.codPaciente
                         join medico in db.medicos
                         on citas.codMedico equals medico.codMedico
                         where citas.fechaHora.Value.Day == DateTime.Now.Day &&
                               citas.fechaHora.Value.Month == DateTime.Now.Month &&
                               citas.fechaHora.Value.Year == DateTime.Now.Year
                         orderby citas.hora
                         select new
                         {
                             Cita = citas.codCita,
                             codMedico = citas.codMedico,
                             nmedico = medico.primerNombre + " " + medico.primerApellido,
                             codPaciente = citas.codPaciente,
                             npaciente = paciente.primerNombre + " " + paciente.segundoNombre + " " + paciente.primerApellido + " " + paciente.segundoApellido,
                             Fecha = citas.fechaHora,
                             Hora = citas.hora,
                         };

            dgv.DataSource = fechas.ToList();
            dgv.Columns["codPaciente"].HeaderText = "Código Paciente";
            dgv.Columns["codMedico"].HeaderText = "Código Médico";
            dgv.Columns["npaciente"].HeaderText = "Nombre Paciente";
            dgv.Columns["nmedico"].HeaderText = "Nombre Médico";
            dgv.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void RecordatorioMedico(DataGridView dgv, string medico)
        {
            dgv.DataSource = null;
            string codmedico = Utilidades.ObtenerCodigoMedico(medico);

            var fechas = from citas in db.citasMedicas
                         join paciente in db.pacientes
                         on citas.codPaciente equals paciente.codPaciente
                         join m in db.medicos
                         on citas.codMedico equals m.codMedico
                         where (citas.fechaHora.Value.Day == DateTime.Now.Day &&
                               citas.fechaHora.Value.Month == DateTime.Now.Month &&
                               citas.fechaHora.Value.Year == DateTime.Now.Year) && 
                               citas.codMedico.Equals(codmedico)
                         orderby citas.hora
                         select new
                         {
                             Cita = citas.codCita,
                             codMedico = citas.codMedico,
                             nmedico = m.primerNombre + " " + m.primerApellido,
                             codPaciente = citas.codPaciente,
                             npaciente = paciente.primerNombre + " " + paciente.segundoNombre + " " + paciente.primerApellido + " " + paciente.segundoApellido,
                             Fecha = citas.fechaHora,
                             Hora = citas.hora,
                         };

            dgv.DataSource = fechas.ToList();
            dgv.Columns["codPaciente"].HeaderText = "Código Paciente";
            dgv.Columns["codMedico"].HeaderText = "Código Médico";
            dgv.Columns["npaciente"].HeaderText = "Nombre Paciente";
            dgv.Columns["nmedico"].HeaderText = "Nombre Médico";
            dgv.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void frmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            p = "";
            nombre = "";
        }
    }
}
