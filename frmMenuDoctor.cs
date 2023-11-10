using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica
{
    public partial class frmMenuDoctor : Form
    {
        static string puesto;
        public frmMenuDoctor()
        {
            InitializeComponent();
        }
        public frmMenuDoctor(string p)
        {
            InitializeComponent();
            puesto = p;
        }

        private void frmMenuDoctor_Load(object sender, EventArgs e)
        {
            mostrarInicio();
            inicio.Recordatorios();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmHome home = new frmHome();
                this.Close();
                pnContenido.Controls.Clear();
                home.Show();
                puesto = "";
            }
        }

        private void LimpiarTodo()
        {
            pnContenido.Controls.Clear();

            // liberar recursos del sistema llamando el método 'Dispose':
            pnContenido.Controls.Clear();
            //inicio?.Dispose();
            crearReporte?.Dispose();
            consultarExpediente?.Dispose();
            consultarCita?.Dispose();
            // reestableciendo a null las instancias de los formularios
            //inicio = null;
            crearReporte = null;
            consultarExpediente = null;
            consultarCita = null;
            mostrarInicio();
            inicio.Recordatorios();
        }

        private void btnLimpiarPnContenedor_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        // variable estatica para almacenar la referencia a los formularios
        private static frmInicio inicio;
        private static frmCrearReportes crearReporte;
        private static frmConsultarExpedientes consultarExpediente;
        private static frmConsultarCita consultarCita;
        private void btnCrearReporte_Click(object sender, EventArgs e)
        {
            if (crearReporte == null)
            {
                crearReporte = FormFactory.CrearFormCrearReportes();
                crearReporte.TopLevel = false;
                crearReporte.Dock = DockStyle.Fill;
            }
            pnContenido.Controls.Add(crearReporte);
            crearReporte.Show();
            crearReporte.BringToFront();

        }

        private void btnConsultarExpediente_Click(object sender, EventArgs e)
        {
            if (consultarExpediente==null)
            {
                consultarExpediente = FormFactory.CrearFormConsultarExpedientes();
                consultarExpediente.TopLevel = false;
                consultarExpediente.Dock = DockStyle.Fill;
            }
            pnContenido.Controls.Add(consultarExpediente);
            consultarExpediente.Show();
            consultarExpediente.BringToFront();
        }

        private void btnConsultarCita_Click(object sender, EventArgs e)
        {
            if (consultarCita==null)
            {
                consultarCita = FormFactory.CrarFormConsultarCita();
                consultarCita.TopLevel = false;
                consultarCita.Dock = DockStyle.Fill;
            }
            pnContenido.Controls.Add(consultarCita);
            consultarCita.Show();
            consultarCita.BringToFront();
        }

        private void mostrarInicio()
        {
            if (inicio == null)
            {
                inicio = FormFactory.CrearFormInicio(puesto);
                inicio.TopLevel = false;
                inicio.Dock = DockStyle.Fill;            
            }
            pnContenido.Controls.Add(inicio);
            inicio.Show();
            inicio.BringToFront();
        }

        private void frmMenuDoctor_Deactivate(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
