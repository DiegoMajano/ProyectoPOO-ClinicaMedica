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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar sesión?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                frmHome home = new frmHome();
                this.Hide();
                home.Show();
            }
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {           
            frmAgregarPaciente agendarPacientes = new frmAgregarPaciente();
            agendarPacientes.TopLevel = false;
            agendarPacientes.Dock = DockStyle.Fill;
            pnContenido.Controls.Add(agendarPacientes);
            agendarPacientes.Show();
            agendarPacientes.BringToFront();
        }

        private void btnConsultarExpediente_Click(object sender, EventArgs e)
        {
            frmConsultarExpedientes consultarpaciente = new frmConsultarExpedientes();
            consultarpaciente.TopLevel = false;
            consultarpaciente.Dock = DockStyle.Fill;
            pnContenido.Controls.Add(consultarpaciente);
            consultarpaciente.Show();
            consultarpaciente.BringToFront();
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            frmAgendarCita agendarCitas = new frmAgendarCita();
            agendarCitas.TopLevel = false;
            agendarCitas.Dock = DockStyle.Fill;
            pnContenido.Controls.Add(agendarCitas);
            agendarCitas.Show();
            agendarCitas.BringToFront();
        }

        private void btnLimpiarPnContenedor_Click(object sender, EventArgs e)
        {
            pnContenido.Controls.Clear();
        }

        private void btnConsultarCita_Click(object sender, EventArgs e)
        {
            frmConsultarCita consultarCita = new frmConsultarCita();
            consultarCita.TopLevel = false;
            consultarCita.Dock = DockStyle.Fill;
            pnContenido.Controls.Add(consultarCita);
            consultarCita.Show();
            consultarCita.BringToFront();
        }
    }
}
