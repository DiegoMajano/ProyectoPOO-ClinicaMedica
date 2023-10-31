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
    public partial class frmMenuSoporte : Form
    {
        public frmMenuSoporte()
        {
            InitializeComponent();
        }

        private static frmRegistrarMedico registrarMedico;
        private static frmConsultarPersonal consultarPersonal;

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

        private void btnbtnRegistrarPersonal_Click(object sender, EventArgs e)
        {
            if (registrarMedico == null)
            {
                registrarMedico = FormFactory.CrearFormRegistrarMedico();
                registrarMedico.TopLevel = false;
                registrarMedico.Dock = DockStyle.Fill;
            }
            pnContenido.Controls.Add(registrarMedico);
            registrarMedico.Show();
            registrarMedico.BringToFront();
        }

        private void btnLimpiarPnContenedor_Click(object sender, EventArgs e)
        {
            pnContenido.Controls.Clear();
        }

        private void btnConsultarExpediente_Click(object sender, EventArgs e)
        {
            if (consultarPersonal == null)
            {
                consultarPersonal = FormFactory.CrearFormConsultarPersonal();
                consultarPersonal.TopLevel = false;
                consultarPersonal.Dock = DockStyle.Fill;
            }
            pnContenido.Controls.Add(consultarPersonal);
            consultarPersonal.Show();
            consultarPersonal.BringToFront();
        }
    }
}
