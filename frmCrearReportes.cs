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
        Reporte reporte = new Reporte();
        Receta receta = new Receta();


        ClinicaEntities db = FormFactory.CrearEntidadDB();
        public frmCrearReportes()
        {
            InitializeComponent();
        }

        private void frmCrearReportes_Load(object sender, EventArgs e)
        {
            Utilidades.LlenarCBPacientes(cbPacBusqueda);
            Utilidades.LlenarCLBMedicamentos(clbMedicamentos);
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

        private void cbPacBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void mtxtPeso_Leave(object sender, EventArgs e)
        {
            if (double.Parse(mtxtPeso.Text) <= 999 && double.Parse(mtxtPeso.Text) >= 0)
            {

            }
            else
            {
                MessageBox.Show("Digitar un peso válido. Rango: 0 lbs a 999 lbs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtxtPeso.Focus();
            }
        }

        private void mtxtEstatura_Leave(object sender, EventArgs e)
        {
            if (double.Parse(mtxtEstatura.Text) >= 0 && double.Parse(mtxtEstatura.Text) <= 3)
            {

            }
            else
            {
                MessageBox.Show("Digitar una estatura válida Rango: 0 mts a 3.00 mts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtxtEstatura.Focus();
            }
        }

        private void mtxtTemp_Leave(object sender, EventArgs e)
        {
            if (double.Parse(mtxtTemp.Text) >= 0 && double.Parse(mtxtTemp.Text) <= 45)
            {

            }
            else
            {
                MessageBox.Show("Digitar una temperatura válida Rango: 0° a 45°", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtxtTemp.Focus();
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
                MessageBox.Show("Seleccionar paciente con cita programada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            LlenarDatosPaciente();
            gbDReporte.Enabled = true;
            gbSignosVitales.Enabled = true;
            mtxtPeso.Focus();
            btnGuardar.Enabled = true;
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
                db.SaveChanges();

                MessageBox.Show("Agregar los medicamentos que desee agregar al reporte con sus respectivas indicaciones","Registro casi completo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                gbMedicamento.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString(),"Error");
            }
        }

        private void BuscarCodigoReporte()
        {
            try
            {
                var codigoReporte = (from cr in db.reportes
                                     where cr.codCita.Equals(txtCodCita.Text)
                                     select cr.codReporte).FirstOrDefault();

                if (codigoReporte != null)
                {
                    receta.CodReporte = codigoReporte.ToString();
                    txtCodReporte.Text = receta.CodReporte;
                    receta.FechaEmitida = DateTime.Now;
                    if (string.IsNullOrEmpty(receta.CodReceta))
                    {
                        db.CrearReceta(receta.CodReporte, receta.FechaEmitida);
                        db.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("No existe código del reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }
        private void BuscarCodigoReceta()
        {
            try
            {
                var codigoReceta = (from cr in db.recetas
                                     where cr.codReporte.Equals(txtCodReporte.Text)
                                     select cr.codReceta).FirstOrDefault();

                if (codigoReceta != null)
                {
                    receta.CodReceta = codigoReceta.ToString();
                }
                else
                {
                    MessageBox.Show("No existe código de la receta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El paciente ya posee un reporte asginado a esta cita", "Error");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(mtxtTemp.Text) && !string.IsNullOrEmpty(mtxtPresionArt.Text) && !string.IsNullOrEmpty(mtxtFrecCar.Text) && !string.IsNullOrEmpty(mtxtPeso.Text) && !string.IsNullOrEmpty(mtxtEstatura.Text) && !string.IsNullOrEmpty(txtDiagnostico.Text) && !string.IsNullOrEmpty(txtMotivo.Text))
                {
                    GuardarReporte();
                    btnGuardar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Debe de completar todos los campos para guardar el reporte.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    btnGuardar.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void clbMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarCodigoReporte();
            if (string.IsNullOrEmpty(receta.CodReceta))
            {
                BuscarCodigoReceta();
            }
        }

        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            try
            {
                receta.CodReporte = txtCodReporte.Text;
                receta.NombreMedicamento = clbMedicamentos.SelectedItem.ToString();
                receta.Indicaciones = txtIndicaciones.Text;
                db.AgregarMedicamento(receta.CodReceta,receta.NombreMedicamento,receta.Indicaciones);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            receta.NombreMedicamento = "";
            receta.Indicaciones = "";
            for (int i = 0; i < clbMedicamentos.Items.Count; i++)
            {
                clbMedicamentos.SetItemChecked(i, false);
            }
            txtIndicaciones.Clear();

        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            MessageBox.Show("Registro del reporte completo realizado.","Registro exitoso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            LimpiarCampos();
            DeshabilidarGroupBox();
            txtCodReporte.Clear();
        }
    }
}
