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
        private static frmRegistrarMedico registrarMedico;

        private void btnbtnRegistrarPersonal_Click(object sender, EventArgs e)
        {
            if (registrarMedico == null)
            {
                registrarMedico = new frmRegistrarMedico();
                registrarMedico.TopLevel = false;
                registrarMedico.Dock = DockStyle.Fill;
                pnContenido.Controls.Add(registrarMedico);
            }
            registrarMedico.Show();
            registrarMedico.BringToFront();
        }

        private void btnLimpiarPnContenedor_Click(object sender, EventArgs e)
        {
            pnContenido.Controls.Clear();
        }
    }
}
