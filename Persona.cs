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
        private string telefono;

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
        public string Telefono
        {
            get { return telefono; } set { telefono = value; }
        }

    }

    public class Paciente : Persona
    {
        // Atributos
        private string direccion;
        private string dui;
        private string nit;
        private string genero;
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; } set { fechaNacimiento = value; }
        }

        public string Genero
        {
            get { return genero; } set { genero = value; }
        }
        public string Direccion
        {
            get { return direccion; } set { direccion = value; }
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
        private string especialidad;

        // Propiedades        
        public string Especialidad
        {
            get { return especialidad; } set { especialidad = value; }
        }
    }
}