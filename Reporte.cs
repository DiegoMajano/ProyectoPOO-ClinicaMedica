using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    public class Reporte
    {
        // cambiar a reporte

        private string codCita;

        // atributos para tabla signos vitales
        private decimal peso;
        private decimal talla;
        private decimal temperatura;
        private string presionArterial;

        //  atributos para tabla Reporte
        private string motivo;
        private string diagnostico;

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

        /// <summary>
        /// 
        /// Se separará esta parte de la clase para clase receta donde estara receta y medicamento
        /// 
        /// </summary>
        // propiedades de tabla receta
        
    }
}
