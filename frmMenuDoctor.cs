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
        public frmMenuDoctor()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmHome home = new frmHome();
                this.Hide();
                home.Show();
            }
        }

        private void btnLimpiarPnContenedor_Click(object sender, EventArgs e)
        {
            pnContenido.Controls.Clear();
        }

        // variable estatica para almacenar la referencia a los formularios

        private static frmCrearReportes crearReporte;
        private static frmConsultarExpedientes consultarExpediente;
        private static frmConsultarCita consultarCita;
        private void btnCrearReporte_Click(object sender, EventArgs e)
        {
            if (crearReporte == null)
            {
                crearReporte = new frmCrearReportes();
                crearReporte.TopLevel = false;
                pnContenido.Controls.Add(crearReporte);
                crearReporte.Dock = DockStyle.Fill;
            }            
            crearReporte.Show();
            crearReporte.BringToFront();

        }

        private void btnConsultarExpediente_Click(object sender, EventArgs e)
        {
            if (consultarExpediente==null)
            {
                consultarExpediente = new frmConsultarExpedientes();
                consultarExpediente.TopLevel = false;
                pnContenido.Controls.Add(consultarExpediente);
                consultarExpediente.Dock = DockStyle.Fill;
            }            
            consultarExpediente.Show();
            consultarExpediente.BringToFront();
        }

        private void btnConsultarCita_Click(object sender, EventArgs e)
        {
            if (consultarCita==null)
            {
                consultarCita = new frmConsultarCita();
                consultarCita.TopLevel = false;
                pnContenido.Controls.Add(consultarCita);
                consultarCita.Dock = DockStyle.Fill;
            }            
            consultarCita.Show();
            consultarCita.BringToFront();
        }
    }
}
