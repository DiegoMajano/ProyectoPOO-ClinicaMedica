using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    /* ------ IMPLEMENTACIÓN DEL PATRÓN DE DISEÑO "FACTORY METHOD" PARA LA CREACION DE LOS FORMULARIOS HIJOS EN LOS MENÚS ------ */
    public class FormFactory
    {
        public static frmAgendarCita CrearFormAgendarCita()
        {
            return new frmAgendarCita();
        }
        public static frmAgregarPaciente CrearFormAgregarPaciente()
        {
            return new frmAgregarPaciente();
        }
        public static frmConsultarCita CrarFormConsultarCita()
        {
            return new frmConsultarCita();
        }
        public static frmConsultarExpedientes CrearFormConsultarExpedientes()
        {
            return new frmConsultarExpedientes();
        }
        public static frmConsultarPersonal CrearFormConsultarPersonal()
        {
            return new frmConsultarPersonal();
        }
        public static frmCrearReportes CrearFormCrearReportes()
        {
            return new frmCrearReportes();
        }        
        public static frmRegistrarMedico CrearFormRegistrarMedico()
        {
            return new frmRegistrarMedico();
        }
    }
}
