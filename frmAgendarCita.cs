using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicaMedica
{
    public partial class frmAgendarCita : ClinicaMedica.frmBase
    {
        public frmAgendarCita()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtNombrePaciente.Clear();
            cbDoctores.Items.Clear();
            cbHorarioCitas.Items.Clear();
            txtObservaciones.Clear();
            dtpFechaCita.Value = System.DateTime.Now;
        }
        private void txtNombrePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaCita.Value < DateTime.Now)
            {
                MessageBox.Show("Seleccionar una fecha válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos()
        {
            txtNombrePaciente.Clear();
            /*cbDoctores.SelectedIndex = 0;
            cbHorarioCitas.SelectedIndex = 0;*/
            dtpFechaCita.Value = DateTime.Now;
            txtObservaciones.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
