using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    public class Receta
    {
        // atributos para tabla receta
        private string codReporte;
        private DateTime fechaEmitida;

        // atributos para tabla medicamento
        private string codReceta;
        private string nombreMedicamento;
        private string indicaciones;

        public string CodReporte
        {
            get { return codReporte; }
            set { codReporte = value; }
        }
        public DateTime FechaEmitida
        {
            get { return fechaEmitida; }
            set { fechaEmitida = value; }
        }

        // propiedades de tabla medicamento
        public string CodReceta
        {
            get { return codReceta; }
            set { codReceta = value; }
        }
        public string NombreMedicamento
        {
            get { return nombreMedicamento; }
            set { nombreMedicamento = value; }
        }
        public string Indicaciones
        {
            get { return indicaciones; }
            set { indicaciones = value; }
        }
    }
}
