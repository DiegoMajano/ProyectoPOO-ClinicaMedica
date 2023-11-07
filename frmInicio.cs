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
        private static Prueba_1Entities1 db = FormFactory.CrearEntidadDB();

        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        public void Recordatorios(/*DataGridView dgv*/)
        {
            /* switch (menu)
             {
                 case "admin":
                     RecordatorioAdmin(dgvCitasDia);
                     break;
                 case "medico":
                     RecordatorioMedico()
                     break;
                 case "soporte":
                     break;
                 default:
                     break;
             }*/
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

            dgvCitasDia.DataSource = fechas.ToList();
            dgvCitasDia.Columns["codPaciente"].HeaderText = "Código Paciente";
            dgvCitasDia.Columns["codMedico"].HeaderText = "Código Médico";
            dgvCitasDia.Columns["npaciente"].HeaderText = "Nombre Paciente";
            dgvCitasDia.Columns["nmedico"].HeaderText = "Nombre Médico";
            dgvCitasDia.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvCitasDia.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvCitasDia.ClearSelection();

        }
        /*private void RecordatorioAdmin(DataGridView dgv)
        {
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
            medico = Utilidades.ObtenerCodigoMedico(medico);

            var fechas = from citas in db.citasMedicas
                         join paciente in db.pacientes
                         on citas.codPaciente equals paciente.codPaciente
                         join m in db.medicos
                         on citas.codMedico equals medico
                         where citas.fechaHora.Value.Day == DateTime.Now.Day &&
                               citas.fechaHora.Value.Month == DateTime.Now.Month &&
                               citas.fechaHora.Value.Year == DateTime.Now.Year
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
        }*/
    }
}
