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
            Recordatorios();
        }

        public void Recordatorios()
        {
            var fechas = from citas in db.citasMedicas
                         join paciente in db.pacientes
                         on citas.codPaciente equals paciente.codPaciente
                         where citas.fechaHora.Value.Day == DateTime.Now.Day && 
                               citas.fechaHora.Value.Month == DateTime.Now.Month && 
                               citas.fechaHora.Value.Year == DateTime.Now.Year
                         orderby citas.hora
                         select new
                         {
                             Cita = citas.codCita,
                             codPaciente = citas.codPaciente,
                             npaciente = paciente.primerNombre + " " + paciente.segundoNombre + " " + paciente.primerApellido + " " + paciente.segundoApellido,
                             Fecha = citas.fechaHora,
                             Hora = citas.hora,
                         };

            dgvCitasDia.DataSource = fechas.ToList();
            dgvCitasDia.Columns["codPaciente"].HeaderText = "Código Paciente";
            dgvCitasDia.Columns["npaciente"].HeaderText = "Nombre Paciente";
            dgvCitasDia.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
    }
}
