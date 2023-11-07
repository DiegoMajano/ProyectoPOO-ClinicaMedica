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

        private void frmMenuSoporte_Load(object sender, EventArgs e)
        {
            mostrarInicio();
            inicio.Recordatorios();
        }

        private static frmInicio inicio;
        private static frmRegistrarPersonal registrarMedico;
        private static frmConsultarPersonal consultarPersonal;
                

        public void mostrarInicio()
        {
            if (inicio == null)
            {
                inicio = FormFactory.CrearFormInicio();
                inicio.TopLevel = false;
                inicio.Dock = DockStyle.Fill;
            }
            pnContenido.Controls.Add(inicio);
            inicio.Show();
            inicio.BringToFront();
            inicio.Recordatorios();
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

        private void btnLimpiarPnContenedor_Click(object sender, EventArgs e)
        {
            pnContenido.Controls.Clear();
        }

        private void LimpiarTodo()
        {
            pnContenido.Controls.Clear();
            registrarMedico.Dispose();
            consultarPersonal.Dispose();

            registrarMedico = null;
            consultarPersonal = null;

            mostrarInicio();
            inicio.Recordatorios();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmHome home = new frmHome();
                this.Hide();
                LimpiarTodo();
                home.Show();
            }
        }
    }
}
