using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    public class CrearReporte
    {
        private string codCita;

        // atributos para tabla signos vitales
        private decimal peso;
        private decimal talla;
        private decimal temperatura;
        private string presionArterial;

        //  atributos para tabla Reporte
        private string motivo;
        private string diagnostico;

        // atributos para tabla receta
        private string codReporte;
        private DateTime fechaEmitida;

        // atributos para tabla medicamento
        private string codReceta;
        private string nombreMedicamento;
        private string indicaciones;

        public string CodCita
        {
            get { return codCita; } set { codCita = value; } 
        }

        // propiedades de tabla signos vitales
        public decimal Peso
        {
            get { return peso; } set { peso = value; } 
        }
        public decimal Talla
        {
            get { return talla; } set { talla = value; }
        }
        public decimal Temperatura
        {
            get { return temperatura; } set { temperatura = value; }
        }
        public string PresionArterial
        {
            get { return presionArterial; } set { presionArterial = value; }
        }

        // propiedades de tabla reporte

        public string Motivo
        {
            get { return motivo; } set { motivo = value; }
        }
        public string Diagnostico
        {
            get { return diagnostico; } set { diagnostico = value; }
        }

        // propiedades de tabla receta
        public string CodReporte
        {
            get { return codReporte; } set { codReporte = value; }
        }
        public DateTime FechaEmitida
        {
            get { return fechaEmitida; } set { fechaEmitida = value; }
        }

        // propiedades de tabla medicamento
        public string CodReceta
        {
            get { return codReceta; } set { codReceta = value; }
        }
        public string NombreMedicamento
        {
            get { return nombreMedicamento; } set { nombreMedicamento = value; }
        }
        public string Indicaciones
        {
            get { return indicaciones; } set { indicaciones = value; }
        }
    }
}
