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
    public partial class frmMenuAdministrativo : Form
    {
        public frmMenuAdministrativo()
        {
            InitializeComponent();
        }
        
        // variable estatica para almacenar la referencia a los formularios
        private static frmAgendarCita agendarCitas;
        private static frmAgregarPaciente agregarPaciente;
        private static frmConsultarExpedientes consultarExpedientes;
        private static frmConsultarCita consultarCita;

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            if (agregarPaciente==null)
            {
                agregarPaciente = new frmAgregarPaciente();
                agregarPaciente.TopLevel = false;
                agregarPaciente.Dock = DockStyle.Fill;
                pnContenido.Controls.Add(agregarPaciente);
            }            
            agregarPaciente.Show();
            agregarPaciente.BringToFront();
        }

        private void btnConsultarExpediente_Click(object sender, EventArgs e)
        {
            if(consultarExpedientes == null)
            {
                consultarExpedientes = new frmConsultarExpedientes();
                consultarExpedientes.TopLevel = false;
                consultarExpedientes.Dock = DockStyle.Fill;
                pnContenido.Controls.Add(consultarExpedientes);
            }            
            consultarExpedientes.Show();
            consultarExpedientes.BringToFront();
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            if (agendarCitas== null)
            {
                agendarCitas = new frmAgendarCita();
                agendarCitas.TopLevel = false;
                agendarCitas.Dock = DockStyle.Fill;
                pnContenido.Controls.Add(agendarCitas);
            }            
            agendarCitas.Show();
            agendarCitas.BringToFront();
        }   

        private void btnConsultarCita_Click(object sender, EventArgs e)
        {
            if (consultarCita == null)
            {
                consultarCita = new frmConsultarCita();
                consultarCita.TopLevel = false;
                consultarCita.Dock = DockStyle.Fill;
                pnContenido.Controls.Add(consultarCita);
            }            
            consultarCita.Show();
            consultarCita.BringToFront();
        }

        private void btnLimpiarPnContenedor_Click(object sender, EventArgs e)
        {
            pnContenido.Controls.Clear();
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
    }
}
