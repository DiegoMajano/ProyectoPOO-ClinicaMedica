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
    public partial class frmCrearReportes : ClinicaMedica.frmBase
    {
        Paciente p = new Paciente();
        private List<Paciente> pacientes = new List<Paciente>();
        CrearReporte reporte = new CrearReporte();

        ClinicaEntities db = FormFactory.CrearEntidadDB();
        public frmCrearReportes()
        {
            InitializeComponent();
        }

        private void frmCrearReportes_Load(object sender, EventArgs e)
        {
            Utilidades.LlenarCBPacientes(cbPacBusqueda);
            DeshabilidarGroupBox();
        }
        
        private void DeshabilidarGroupBox()
        {
            gbSignosVitales.Enabled = false;
            gbDReporte.Enabled = false;
            gbMedicamento.Enabled = false;
        }
        public void LimpiarCampos()
        {
            cbPacBusqueda.SelectedIndex=0;
            txtCodPaciente.Clear();
            txtP_Nombre.Clear();
            txtApellidos.Clear();
            txtEdad.Clear();
            txtGenero.Clear();
            txtCodCita.Clear();
            txtFechaCita.Clear();
            mtxtPeso.Clear();
            mtxtEstatura.Clear();
            mtxtFrecCar.Clear();
            mtxtTemp.Clear();
            mtxtPresionArt.Clear();
            txtMotivo.Clear();
            txtDiagnostico.Clear();
            txtIndicaciones.Clear();           
            for (int i = 0; i < clbMedicamentos.Items.Count; i++)
            {
                clbMedicamentos.SetItemChecked(i, false);
            }
        }
        
        private bool ValidarCita(string paciente)
        {
            var cita = from c in db.citasMedicas
                       join p in db.pacientes
                       on c.codPaciente equals p.codPaciente
                       where c.codPaciente.Equals(paciente)
                       select c;

            if (cita.Any(c=>c.codPaciente.Equals(paciente)))
            {
                return true;
            }
            else
            {
                return false;
            }
                    
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LlenarDatosPaciente()
        {
            // -----  VALIDAR QUE TENGA CITA EN ESTE DIA 
            string nombrePaciente = cbPacBusqueda.Text;
            string codigoPaciente = Utilidades.ObtenerCodigoPaciente(nombrePaciente);

            if (ValidarCita(codigoPaciente))
            {
                var datos = from p in db.pacientes
                            join c in db.citasMedicas
                            on p.codPaciente equals c.codPaciente
                            where (p.codPaciente.Equals(codigoPaciente) && c.fechaHora.Value.Day.Equals(DateTime.Now.Day))
                            select new
                            {
                                cod = p.codPaciente,
                                nombre = p.primerNombre + " " + p.segundoNombre,
                                apellido = p.primerApellido + " " + p.segundoApellido,
                                edad = p.edad.ToString(),
                                genero = p.sexo,
                                cita = c.codCita,
                                fecha = c.fechaHora.ToString()
                            };

                Dictionary<string, string> paciente = new Dictionary<string, string>();

                try
                {
                    foreach (var n in datos)
                    {
                        paciente.Add("Codigo", n.cod);
                        paciente.Add("Nombre", n.nombre);
                        paciente.Add("Apellido", n.apellido);
                        if (n.genero.Equals("M"))
                        {
                            paciente.Add("Genero", "Masculino");
                        }
                        else
                        {
                            paciente.Add("Genero", "Femenino");
                        }
                        paciente.Add("Edad", n.edad);
                        paciente.Add("Cita", n.cita);
                        paciente.Add("Fecha", n.fecha.ToString());
                    }

                    txtCodPaciente.Text = paciente["Codigo"];
                    txtP_Nombre.Text = paciente["Nombre"];
                    txtApellidos.Text = paciente["Apellido"];
                    txtEdad.Text = paciente["Edad"];
                    txtGenero.Text = paciente["Genero"];
                    txtCodCita.Text = paciente["Cita"];
                    txtFechaCita.Text = paciente["Fecha"];
                }
                catch
                {
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Seleccionar paciente con cita programada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            LlenarDatosPaciente();
            gbDReporte.Enabled = true;
            gbMedicamento.Enabled = true;
            gbSignosVitales.Enabled = true;
            mtxtPeso.Focus();
        }

        private void GuardarReporte()
        {
            try
            {
                reporte.Motivo = txtMotivo.Text;
                reporte.Diagnostico = txtDiagnostico.Text;
                reporte.CodCita = txtCodCita.Text;
                reporte.Peso = decimal.Parse(mtxtPeso.Text);
                reporte.Talla = decimal.Parse(mtxtEstatura.Text);
                reporte.Temperatura = decimal.Parse(mtxtTemp.Text);
                reporte.PresionArterial = mtxtPresionArt.Text + " " + mtxtFrecCar.Text;

                db.CrearReporte(reporte.CodCita, reporte.Motivo, reporte.Diagnostico, reporte.Peso, reporte.Talla, reporte.Temperatura, reporte.PresionArterial);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
            
        }

        private void cbPacBusqueda_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarReporte();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
