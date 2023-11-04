using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Modelo;

namespace ClinicaMedica
{
    public partial class frmConsultarCita : Form
    {
        Prueba_1Entities1 db = FormFactory.CrearEntidadDB();
        private bool filtroFecha;
        private bool filtroHora;
        private bool filtroPaciente;
        private bool filtroMedico;

        public frmConsultarCita()
        {
            InitializeComponent();
        }

        private void frmConsultarCita_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
            LimpiarCampos();
        }


        public void LimpiarCampos()
        {
            cbHorario.SelectedIndex = 0;
            cbPaciente.SelectedIndex = 0;
            cbMedico.SelectedIndex = 0;
            dtpFechaCita.Value = System.DateTime.Now;
            filtroMedico = false;
            filtroFecha = false;
            filtroHora = false;
            filtroPaciente = false;
        }

        private void LlenarComboBox()
        {
            Utilidades.LlenarCBHorarios(cbHorario);
            Utilidades.LlenarCBMedicos(cbMedico);
            Utilidades.LlenarCBPacientes(cbPaciente);            
        }

        // --- Validaciones 
        private void cbPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // condicionadores para el filtrado
        private DateTime fecha;

        private void cbHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHorario.SelectedIndex != 0)
            {
                filtroHora = true;
            }
        }

        private void cbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaciente.SelectedIndex != 0)
            {
                filtroPaciente = true;
            }
        }

        private void cbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMedico.SelectedIndex != 0)
            {
                filtroMedico = true;
            }
        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaCita.Value==DateTime.Now)
            {
                fecha = DateTime.Now;

            }
            else
            {
                fecha = dtpFechaCita.Value;
            }
            filtroFecha = true;
        }

        // busqueda por filtros
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {     
            TimeSpan hora = TimeSpan.Parse(cbHorario.Text);

            string codigoMedico = Utilidades.ObtenerCodigoMedico(cbMedico.Text);
            string codigoPaciente = Utilidades.ObtenerCodigoPaciente(cbPaciente.Text);

            var consulta = from cita in db.citasMedicas
                           join medico in db.medicos
                           on cita.codMedico equals medico.codMedico
                           join paciente in db.pacientes
                           on cita.codPaciente equals paciente.codPaciente
                           where
                               (!filtroHora || cita.fechaHora.Value.Hour == hora.Hours && cita.fechaHora.Value.Minute == hora.Minutes) &&
                               (!filtroMedico || medico.codMedico == codigoMedico) &&
                               (!filtroPaciente || cita.codPaciente == codigoPaciente) &&
                               (!filtroFecha || cita.fechaHora.Value.Day == fecha.Day && cita.fechaHora.Value.Month == fecha.Month && cita.fechaHora.Value.Year == fecha.Year)
                           orderby cita.fechaHora
                           select new
                           {
                               CodCita = cita.codCita,
                               CodMedico = medico.codMedico,
                               NombreMedico = medico.primerNombre + " " + medico.primerApellido,
                               CodPaciente = paciente.codPaciente,
                               NombrePaciente = paciente.primerNombre + " " + paciente.primerApellido,
                               Fecha = cita.fechaHora,
                               Hora = cita.hora,
                           };

            dgvConsultarCitas.DataSource = consulta.ToList();

            dgvConsultarCitas.Columns["NombreMedico"].HeaderText = "Nombre Medico";
            dgvConsultarCitas.Columns["NombrePaciente"].HeaderText = "Nombre Paciente";
            dgvConsultarCitas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";

            LimpiarCampos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvConsultarCitas.DataSource = null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // agregar la funcionalidad de editar cuando el agendar cita esté listo
        }

        private void dgvConsultarCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
