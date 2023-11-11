using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicaMedica.Modelo;
using System.Linq;

namespace ClinicaMedica
{
    public partial class frmConsultarExpedienteReporte : ClinicaMedica.frmBase
    {
        ClinicaEntities db = FormFactory.CrearEntidadDB();
        static string puesto;
        public string id;
        Persona personas = null;
        
        public frmConsultarExpedienteReporte()
        {
            InitializeComponent();
        }

        public frmConsultarExpedienteReporte(string p,string id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id!=null)
            {
                CargarDatos(id);
            }
        }
        private void CargarDatos(string codPaciente)
        {
            lblTitulo.Text = $"Reportees paciente {codPaciente}";
            var reporte = from re in db.reportes 
                          join ci in db.citasMedicas on re.codCita equals ci.codCita
                          join si in db.signosVitales on re.codReporte equals si.codReporte
                          join rec in db.recetas on re.codReporte equals rec.codReporte
                          join me in db.medicamentos on rec.codReceta equals me.codReceta
                          join pa in db.pacientes on ci.codPaciente equals pa.codPaciente
                          
                          where ci.codPaciente == codPaciente
                          select new
                          {
                              CodCita = ci.codCita,
                              Paciente = pa.primerNombre + " " + pa.segundoNombre + " " + pa.primerApellido + " " + pa.segundoApellido,
                              FechaCita = ci.fechaHora,
                              Motivo = re.motivo,
                              Diagnostico = re.diagnostico,
                              Peso = si.peso,
                              Talla = si.talla,
                              Temperatura = si.temperatura,
                              PresionArterial = si.presionArterial,
                              FechaReceta = rec.fechaEmitida,
                              NombreMedicamento = me.nombreMedicamento,
                              Indicaciones = me.indicaciones
                          };

            dataGridView1.DataSource = reporte.ToList();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmConsultarExpedienteReporte_Load(object sender, EventArgs e)
        {
            switch (puesto)
            {
                case "M":
                    //algo
                    break;
                case "A":
                    // algo
                    break;
                default:
                    break;
            }
        }
    }
}
