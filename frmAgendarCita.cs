using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Windows.Forms;
using ClinicaMedica.Modelo;

namespace ClinicaMedica
{
    public partial class frmAgendarCita : ClinicaMedica.frmBase
    {
        private static Prueba_1Entities1 db = FormFactory.CrearEntidadDB();

        public frmAgendarCita()
        {
            InitializeComponent();
        }
        private void frmAgendarCita_Load(object sender, EventArgs e)
        {
            Refrescar();
            dgvCitas.ClearSelection();
            LlenarComboBox();
            cbNombrePaciente.Focus();
            LimpiarCampos();
        }

        private void Refrescar()
        {            
            var citas = from cita in db.citasMedicas
                        join paciente in db.pacientes
                        on cita.codPaciente equals paciente.codPaciente
                        join medico in db.medicos
                        on cita.codMedico equals medico.codMedico
                        orderby cita.fechaHora
                        select new
                        {
                            Codigo = cita.codCita,
                            CodigoMedico = cita.codMedico,
                            medico = medico.primerNombre + " " + medico.primerApellido,
                            Especialidad = medico.especialidad,
                            codPaciente = cita.codPaciente,
                            Paciente = paciente.primerNombre + " " + paciente.segundoNombre + " " + paciente.primerApellido + " " + paciente.segundoApellido,
                            Fecha = cita.fechaHora,
                            Hora = cita.hora
                        };

            dgvCitas.DataSource = citas.ToList();
            dgvCitas.ClearSelection();
            dgvCitas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvCitas.Columns["medico"].HeaderText = "Médico";
            dgvCitas.Columns["CodigoMedico"].HeaderText = "Código Médico";
            dgvCitas.Columns["codPaciente"].HeaderText = "Código Paciente";
            dgvCitas.Columns["Codigo"].HeaderText = "Código Cita";
            dgvCitas.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }
        private void LlenarComboBox()
        {
            Utilidades.LlenarCBHorarios(cbHorarioCitas);
            Utilidades.LlenarCBPacientes(cbNombrePaciente);
            Utilidades.LlenarCBMedicos(cbNombreMedico);
        }

        private void LimpiarCampos()
        {
            cbNombrePaciente.Text = "";
            cbNombreMedico.Text = "";
            cbHorarioCitas.SelectedIndex = 0;
            dtpFechaCita.Value = DateTime.Now;
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
        private void cbDoctores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaCita.Value.Day < DateTime.Now.Day || dtpFechaCita.Value.Hour < DateTime.Now.Hour)
            {
                MessageBox.Show("Seleccionar una fecha y hora válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private string validador;
        private bool VerificarCitaPaciente(DateTime fechahora, string paciente)
        {
            
            var verificacion = from citas in db.citasMedicas
                               where citas.fechaHora == fechahora || citas.codPaciente == paciente
                               select new
                               {
                                   codpaciente = citas.codPaciente,
                                   fecha = citas.fechaHora
                               };                              

            if (verificacion.Any(cp => cp.codpaciente == paciente || cp.fecha.Value.Day == fechahora.Day))
            {
                validador = validador + "paciente";
                return false;
            }
            else
            {
                return true;

            }
        }

        private bool VerificarCitaMedico(DateTime fechahora, string medico)
        {
            var verificacion = from citas in db.citasMedicas
                                 where citas.fechaHora == fechahora && citas.codMedico == medico
                                 select citas.codMedico;

            if (verificacion.Any(cm => cm == medico))
            {
                validador = validador + "medico";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {            
            string codigoMedico = Utilidades.ObtenerCodigoMedico(cbNombreMedico.Text);
            string codigoPaciente = Utilidades.ObtenerCodigoPaciente(cbNombrePaciente.Text);
            string fecha = dtpFechaCita.Value.ToString("dd/MM/yyyy");
            string hora = cbHorarioCitas.Text;
            string FechaHora = $"{fecha} {hora}";
            DateTime fechahora = DateTime.ParseExact(FechaHora,"dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);

            CrearCita nuevaCita = new CrearCita();
            nuevaCita.CodPaciente = codigoPaciente;
            nuevaCita.CodMedico = codigoMedico;
            nuevaCita.FechaHora = fechahora;

            
            if ( fechahora > DateTime.Now && VerificarCitaPaciente(fechahora,codigoPaciente)&& VerificarCitaMedico(fechahora, codigoMedico))
            {
                db.IngresarCita(nuevaCita.CodPaciente, nuevaCita.CodMedico, nuevaCita.FechaHora);
                MessageBox.Show("La cita se ha registrado exitosamente", "Registro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch (validador)
                {
                    case "paciente":
                        MessageBox.Show("El paciente ya posee una cita este dia", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validador = "";
                        break;
                    case "medico":
                        MessageBox.Show("El medidco ya posee una cita este dia a esa hora", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validador = "";
                        break;
                    default:
                        MessageBox.Show("Error al agendar una cita en la fecha y/o hora seleccionada", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validador = "";
                        break;
                }
            }
            validador = "";
            Refrescar();
            LimpiarCampos();
            cbNombrePaciente.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
