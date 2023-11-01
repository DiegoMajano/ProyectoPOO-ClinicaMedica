using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace ClinicaMedica
{
    public partial class frmAgregarPaciente : ClinicaMedica.frmBase
    {
        Paciente paciente = new Paciente();
        List<Paciente> pacientes = new List<Paciente>();
        public frmAgregarPaciente()
        {
            InitializeComponent();
        }
        private void frmAgregarPaciente_Load(object sender, EventArgs e)
        {
            cbGenero.SelectedIndex = 0;

        }
        private void LimpiarCampos()
        {
            txtP_Nombre.Clear();
            txtS_Nombre.Clear();
            txtP_Apellido.Clear();
            txtS_Apellido.Clear();
            txtDireccion.Clear();
            mtxtTelefono.Clear();
            cbGenero.SelectedIndex = 0;
            mtxtDUI.Clear();
            mtxtNIT.Clear();
            dtpFechaNacimiento.Value = System.DateTime.Now;
        }
        // Validaciones de los campos

        private void txtP_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtS_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtP_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtS_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dtpFechaNaciemiento_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("Seleccionar una fecha válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // Funcionalidad de los botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            paciente.PrimerNombre = txtP_Nombre.Text;
            paciente.SegundoNombre = txtS_Nombre.Text;
            paciente.PrimerApellido = txtP_Apellido.Text;
            paciente.SegundoApellido = txtS_Apellido.Text;
            paciente.FechaNacimiento = dtpFechaNacimiento.Value;
            paciente.Direccion = txtDireccion.Text;
            paciente.Genero = cbGenero.SelectedItem.ToString();
            paciente.Telefono = mtxtTelefono.Text;
            paciente.Dui = mtxtDUI.Text;
            paciente.Nit = mtxtNIT.Text;
            LimpiarCampos();
            txtP_Nombre.Focus();
            //falta mostrar mensaje que se guardo correctamente, uso de catch
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtP_Nombre.Focus();
            //falta mostrar que se borro correctamente o mal, uso de catch
        }

        
    }
}
