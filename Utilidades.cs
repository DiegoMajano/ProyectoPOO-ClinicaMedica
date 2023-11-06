using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Modelo;

namespace ClinicaMedica
{
    public class Utilidades
    {
        private static Prueba_1Entities1 db = FormFactory.CrearEntidadDB();

        public static void LlenarCBPacientes(ComboBox comboBox)
        {
            // --- seleccionar los nombres de los pacientes y convertirlos en una lista
            var nombresPacientes = db.pacientes
                .Select(p => p.primerNombre + " " + p.segundoNombre + " " + p.primerApellido + " " + p.segundoApellido)
                .ToList();
            
            // autocompletar el nombre escrito con los nombres traidos de la base de datos

            AutoCompleteStringCollection autocompletarPacientes = new AutoCompleteStringCollection();
            autocompletarPacientes.AddRange(nombresPacientes.ToArray());
            comboBox.AutoCompleteCustomSource = autocompletarPacientes;
        }

        public static void LlenarCBMedicos(ComboBox comboBox)
        {
            // --- seleccionar los nombres de los medicos y convertirlos en una lista
            var nombresMedicos = db.medicos
                .Select(m => m.primerNombre + " " +  m.primerApellido)
                .ToList();

            // autocompletar el nombre escrito con los nombres traidos de la base de datos

            AutoCompleteStringCollection autocompletarDoctor = new AutoCompleteStringCollection();
            autocompletarDoctor.AddRange(nombresMedicos.ToArray());
            comboBox.AutoCompleteCustomSource = autocompletarDoctor;
        }

        public static void LlenarCBHorarios(ComboBox comboBox)
        {
            // Llenar combobox de los horarios
            List<TimeSpan> horarios = new List<TimeSpan>()
            {
                TimeSpan.Zero,
                new TimeSpan(7, 0, 0),
                new TimeSpan(7, 30, 0),
                new TimeSpan(8, 0, 0),
                new TimeSpan(8, 30, 0),
                new TimeSpan(9, 0, 0),
                new TimeSpan(9, 30, 0),
                new TimeSpan(10, 0, 0),
                new TimeSpan(10, 30, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(13, 30, 0),
                new TimeSpan(14, 0, 0),
                new TimeSpan(14, 30, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
            };
            comboBox.DataSource = horarios;
        }

        public static void LlenarCBEspecialidades(ComboBox comboBox)
        {
            List<String> especialidades = new List<string>
            {
                "Seleccionar especialidad", "Medicina General", "Pediatra", "Ginecología", "Odontología", "Medicina General"
            };
            comboBox.DataSource = especialidades;
        }

        public static string ObtenerCodigoPaciente(string nombrePaciente)
        {
            var codigoPaciente = db.pacientes
                .Where(p => p.primerNombre + " " + p.segundoNombre + " " + p.primerApellido + " " + p.segundoApellido == nombrePaciente)
                .Select(p => p.codPaciente)
                .FirstOrDefault();

            return codigoPaciente;
        }

        public static string ObtenerCodigoMedico(string nombreMedico)
        {
            var codigoMedico = db.medicos
               .Where(m => m.primerNombre + " " + m.primerApellido == nombreMedico)
               .Select(m => m.codMedico)
               .FirstOrDefault();

            return codigoMedico;
        }
    }
}
