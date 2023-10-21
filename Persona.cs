using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    public class Persona
    {
        // Atributos
        private string primerNombre;
        private string segundoNombre;
        private string primerApellido;
        private string segundoApellido;
        private int edad;
        private string genero;
        private DateTime fechaNacimiento;

        // Propiedades
        public string PrimerNombre
        {
            get { return primerNombre; } set { primerNombre = value; } 
        }
        public string SegundoNombre
        {
            get { return segundoNombre; } set { segundoNombre = value; }
        }
        public string PrimerApellido
        {
            get { return primerApellido; } set { primerApellido = value; }
        }
        public string SegundoApellido
        {
            get { return segundoApellido; } set { segundoApellido = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; } set { fechaNacimiento = value; }
        }
        public int Edad
        {
            get { return CalcularEdad(); }
        }
        public string Genero
        {
            get { return genero; } set { genero = value; }
        }

        // Métodos
        public int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Ajustar la edad si aún no ha cumplido años
            if (System.DateTime.Now.Subtract(fechaNacimiento.AddYears(edad)).TotalDays < 0)
            {
                edad--;
            }

            return edad;
        }
    }

    public class Paciente : Persona
    {
        // Atributos
        private int idPaciente;
        private string direccion;
        private string telefono;
        private string dui;
        private string nit;

        // Propiedades
        public int IdPaciente
        {
            get { return idPaciente; } set { idPaciente = value; }
        }

        public string Direccion
        {
            get { return direccion; } set { direccion = value; }
        }
        public string Telefono
        {
            get { return telefono; } set { telefono = value; }
        }

        public string Dui
        {
            get { return dui; } set { dui = value; }
        }
        public string Nit
        {
            get { return nit; } set { nit = value; }
        }        
    }

    public class Medico : Persona
    {
        // Atributos
        private int idMedico;
        private string especialidad;

        // Propiedades
        public int IdMedico
        {
            get { return idMedico; } set { idMedico = value; }
        }
        public string Especialidad
        {
            get { return especialidad; } set { especialidad = value; }
        }
        // Metodos
    }
}