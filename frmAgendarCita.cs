﻿using System;
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
            dgvCitas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvCitas.Columns["medico"].HeaderText = "Médico";
            dgvCitas.Columns["CodigoMedico"].HeaderText = "Código Médico";
            dgvCitas.Columns["codPaciente"].HeaderText = "Código Paciente";
            dgvCitas.Columns["Codigo"].HeaderText = "Código Cita";
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
            if (dtpFechaCita.Value < DateTime.Now)
            {
                MessageBox.Show("Seleccionar una fecha válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            
            db.IngresarCita(nuevaCita.CodPaciente,nuevaCita.CodMedico,nuevaCita.FechaHora);
            Refrescar();
            LimpiarCampos();
            cbNombrePaciente.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
