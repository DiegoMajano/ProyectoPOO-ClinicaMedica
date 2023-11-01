using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicaMedica
{
    public partial class frmRegistrarMedico : ClinicaMedica.frmBase
    {
        public frmRegistrarMedico()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            mtxtTelefono.Clear();
            dtpFechaNacimiento.Value = System.DateTime.Now;
            cbGenero.Text = "SEleccionar Género";
            cbEspecialidad.Text= "Seleccionar Especialidad";
            txtusuario.Clear();
            txtpaswoord.Clear();
            //falta limpiar la lista del puesto (no supe como jsjsjs)
        }  

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("Ingrese una fecha válida","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                dtpFechaNacimiento.Value = DateTime.Now;
            }
        }

        private void frmRegistrarMedico_Load(object sender, EventArgs e)
        {
            cbGenero.SelectedIndex = 0;
            cbEspecialidad.SelectedIndex = 0;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
