using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaMedica.Modelo;

namespace ClinicaMedica
{
    public class Cita
    {
        private string codPaciente;
        private string codMedico;
        private DateTime fechaHora;        
        public string CodPaciente
        {
            get { return codPaciente; }
            set { codPaciente = value; }
        }
        public string CodMedico
        {
            get { return codMedico; }
            set { codMedico = value; }
        }
        public DateTime FechaHora
        {
            get; set;
        }
    }
}
